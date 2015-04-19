using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraveyardCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            List<string> Graveyard = new List<string>(); 
            foreach(ComboBox cb in PanelGraveyard.Controls)
            {
                if(cb.Text != "")
                {
                    Graveyard.Add(cb.Text);
                }
            }

            List<string> RoleList = new List<string>();
            foreach(ComboBox cb in PanelRoleList.Controls)
            {
                if (cb.Text != "")
                {
                    RoleList.Add(cb.Text);
                }
            }
            //Compare(Graveyard, RoleList);
            Sweeper sweeper = new Sweeper(Graveyard, RoleList);
            sweeper.DoSweeps();
            //done eliminating
            ListBoxRemainingRoles.Items.Clear();
            foreach (string z in sweeper.RoleList)
            {
                ListBoxRemainingRoles.Items.Add(z);
            }
        }

        private void Compare(List<string> Graveyard, List<string> RoleList)
        {
            /*
            //sweep one
            for (int i = Graveyard.Count - 1; i >= 0; i--)
            {                
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == Graveyard[i]);
                for(int x = RoleList.Count -1; x >= 0; x--)
                {
                    //exact match?
                    if(Graveyard[i] == RoleList[x])
                    {
                        Graveyard.RemoveAt(i);
                        RoleList.RemoveAt(x);
                        break;
                    }
                    else
                    {                        
                        if(r.Categories.Count == 1)
                        {
                            if(r.Categories[0] == RoleList[x])
                            {
                                Graveyard.RemoveAt(i);
                                RoleList.RemoveAt(x);
                                break;
                            }
                        }
                        else
                        {
                            //Pass
                        }
                    }
                }
            }
            //sweep 2 now I only have multi-category graveyard items
            for (int i = Graveyard.Count - 1; i >= 0; i--)
            {
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == Graveyard[i]);
                int Count = 0;
                string Match = "";
                foreach(string c in r.Categories)
                {
                    if (RoleList.Contains(c))
                    {
                        Count++;
                        Match = c;
                    }
                }
                if(Count == 1)
                {
                    //ya we can kill the first matching cat we see in RoleList
                    for(int x = RoleList.Count -1; x >= 0; x--)
                    {
                        if(RoleList[x] == Match)
                        {
                            Graveyard.RemoveAt(i);
                            RoleList.RemoveAt(x);
                            break;
                        }
                    }
                }
            }

            //sweep 3
            List<string> CategoriesRemainingInGraveyard = new List<string>();
            foreach(string GYR in Graveyard)
            {
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == GYR);
                foreach(string cat in r.Categories)
                {
                    if (!CategoriesRemainingInGraveyard.Contains(cat)) CategoriesRemainingInGraveyard.Add(cat);
                }                
            }
            int MatchesInRoleList = 0;
            foreach(string RLR in RoleList)
            {
                if (CategoriesRemainingInGraveyard.Contains(RLR)) MatchesInRoleList++;
            }
            //CHANGE TO >= because randoms could cause more to be in graveyard than in role lie
            if(Graveyard.Count >= MatchesInRoleList)
            {
                for (int i = Graveyard.Count - 1; i >= 0; i--)
                {
                    for(int x = RoleList.Count -1; x >= 0; x--)
                    {
                        if(CategoriesRemainingInGraveyard.Contains(RoleList[x]))
                        {
                            Graveyard.RemoveAt(i);
                            RoleList.RemoveAt(x);
                            break;
                        }
                    }
                }
            }

            //sweep 4 - randoms
            for (int i = Graveyard.Count - 1; i >= 0; i--)
            {
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == Graveyard[i]);
                Boolean Match = false;
                foreach (string cat in r.Categories)
                {
                    if (RoleList.Contains(cat)) Match = true;
                }
                if(!Match)
                {
                    for (int x = RoleList.Count - 1; x >= 0; x--)
                    {
                        if(RoleList[x] == "Town Random")
                        {
                            Graveyard.RemoveAt(i);
                            RoleList.RemoveAt(x);
                            break;
                        }
                    }
                }
            }


            //done eliminating
            ListBoxRemainingRoles.Items.Clear();
            foreach(string z in RoleList)
            {
                ListBoxRemainingRoles.Items.Add(z);
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++ )
            {
                ComboBox cb = new ComboBox();
                ComboBox cb2 = new ComboBox();
                foreach (Role r in Roles.ListRoles)
                {                    
                    cb.Items.Add(r.Name);
                    cb2.Items.Add(r.Name);
                }
                cb.TextChanged += new EventHandler(DropDownChange);
                PanelGraveyard.Controls.Add(cb);
                //------------------------------
                foreach(Category c in Categories.ListCategories)
                {
                    cb2.Items.Add(c.Name);
                }
                cb2.Items.Add("Town Random");
                cb2.TextChanged += new EventHandler(DropDownChange);
                PanelRoleList.Controls.Add(cb2);
            }

            
        }
        private void DropDownChange(object sender, EventArgs e)
        {
            //Console.WriteLine("Combo changed");
            btnCompare_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(ComboBox cb in PanelGraveyard.Controls)
            {
                cb.Text = "";
            }
            foreach (ComboBox cb in PanelRoleList.Controls)
            {
                cb.Text = "";
            }
            ListBoxRemainingRoles.Items.Clear();
        }
    }
}
