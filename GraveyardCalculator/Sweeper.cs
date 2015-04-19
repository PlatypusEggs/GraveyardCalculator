using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardCalculator
{
    class Sweeper
    {
        public List<string> Graveyard;
        public List<string> RoleList;

        public Sweeper(List<string> Graveyard, List<string> RoleList)
        {
            this.Graveyard = Graveyard;
            this.RoleList = RoleList;
        }

        public void DoSweeps()
        {
            this.ExactOrSingleCategory();
            this.MultiCategoryWithOneMatch();
            this.GraveyardItemCategoriesVsRoleList();
            //experiment
            this.MultiCategoryWithOneMatch();
            this.AllCategoriesLeftInGraveyardVsRoleList();
            this.Randoms();
        }

        public void ExactOrSingleCategory()
        {
            for (int i = Graveyard.Count - 1; i >= 0; i--)
            {
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == Graveyard[i]);
                for (int x = RoleList.Count - 1; x >= 0; x--)
                {
                    //exact match?
                    if (Graveyard[i] == RoleList[x])
                    {
                        Graveyard.RemoveAt(i);
                        RoleList.RemoveAt(x);
                        break;
                    }
                    else
                    {
                        if (r.Categories.Count == 1)
                        {
                            if (r.Categories[0] == RoleList[x])
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
        }
        public void MultiCategoryWithOneMatch()
        {
            for (int i = Graveyard.Count - 1; i >= 0; i--)
            {
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == Graveyard[i]);
                int Count = 0;
                string Match = "";
                foreach (string c in r.Categories)
                {
                    if (RoleList.Contains(c))
                    {
                        Count++;
                        Match = c;
                    }
                }
                if (Count == 1)
                {
                    //ya we can kill the first matching cat we see in RoleList
                    for (int x = RoleList.Count - 1; x >= 0; x--)
                    {
                        if (RoleList[x] == Match)
                        {
                            Graveyard.RemoveAt(i);
                            RoleList.RemoveAt(x);
                            break;
                        }
                    }
                }
            }
        }
        public void GraveyardItemCategoriesVsRoleList()
        {
            for (int i = Graveyard.Count - 1; i >= 0; i--)
            {
                int MatchCount = 0;
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == Graveyard[i]);
                for (int ii = Graveyard.Count - 1; ii >= 0; ii--)
                {
                    Role rr = Roles.ListRoles.FirstOrDefault(obj => obj.Name == Graveyard[ii]);
                    if(rr.Categories.SequenceEqual(r.Categories))
                    {
                        MatchCount++;
                    }
                }
                int MatchCount2 = 0;
                for(int x = RoleList.Count - 1; x >= 0; x--)
                {
                    if(r.Categories.Contains(RoleList[x]))
                    {
                        MatchCount2++;
                    }
                }
                if(MatchCount == MatchCount2)
                {
                    for (int x = RoleList.Count - 1; x >= 0; x--)
                    {
                        if (r.Categories.Contains(RoleList[x]))
                        {
                            Graveyard.RemoveAt(i);
                            RoleList.RemoveAt(x);
                            break;
                        }
                    }
                }
            }
        }
        public void AllCategoriesLeftInGraveyardVsRoleList()
        {
            List<string> CategoriesRemainingInGraveyard = new List<string>();
            foreach (string GYR in Graveyard)
            {
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == GYR);
                foreach (string cat in r.Categories)
                {
                    if (!CategoriesRemainingInGraveyard.Contains(cat)) CategoriesRemainingInGraveyard.Add(cat);
                }
            }
            int MatchesInRoleList = 0;
            foreach (string RLR in RoleList)
            {
                if (CategoriesRemainingInGraveyard.Contains(RLR)) MatchesInRoleList++;
            }
            //CHANGE TO >= because randoms could cause more to be in graveyard than in role lie
            if (Graveyard.Count >= MatchesInRoleList)
            {
                for (int i = Graveyard.Count - 1; i >= 0; i--)
                {
                    for (int x = RoleList.Count - 1; x >= 0; x--)
                    {
                        if (CategoriesRemainingInGraveyard.Contains(RoleList[x]))
                        {
                            Graveyard.RemoveAt(i);
                            RoleList.RemoveAt(x);
                            break;
                        }
                    }
                }
            }
        }
        public void Randoms()
        {
            for (int i = Graveyard.Count - 1; i >= 0; i--)
            {
                Role r = Roles.ListRoles.FirstOrDefault(obj => obj.Name == Graveyard[i]);
                Boolean Match = false;
                foreach (string cat in r.Categories)
                {
                    if (RoleList.Contains(cat)) Match = true;
                }
                if (!Match)
                {
                    for (int x = RoleList.Count - 1; x >= 0; x--)
                    {
                        if (RoleList[x] == "Town Random")
                        {
                            Graveyard.RemoveAt(i);
                            RoleList.RemoveAt(x);
                            break;
                        }
                    }
                }
            }
        }
    }
}
