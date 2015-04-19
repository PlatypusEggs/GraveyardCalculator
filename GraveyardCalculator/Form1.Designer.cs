namespace GraveyardCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelGraveyard = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelRoleList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.ListBoxRemainingRoles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelGraveyard
            // 
            this.PanelGraveyard.Location = new System.Drawing.Point(12, 49);
            this.PanelGraveyard.Name = "PanelGraveyard";
            this.PanelGraveyard.Size = new System.Drawing.Size(141, 419);
            this.PanelGraveyard.TabIndex = 1;
            // 
            // PanelRoleList
            // 
            this.PanelRoleList.Location = new System.Drawing.Point(174, 49);
            this.PanelRoleList.Name = "PanelRoleList";
            this.PanelRoleList.Size = new System.Drawing.Size(141, 419);
            this.PanelRoleList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Graveyard:";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(498, 49);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(148, 32);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // ListBoxRemainingRoles
            // 
            this.ListBoxRemainingRoles.FormattingEnabled = true;
            this.ListBoxRemainingRoles.Location = new System.Drawing.Point(343, 49);
            this.ListBoxRemainingRoles.Name = "ListBoxRemainingRoles";
            this.ListBoxRemainingRoles.Size = new System.Drawing.Size(149, 420);
            this.ListBoxRemainingRoles.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remaining Roles:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxRemainingRoles);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelRoleList);
            this.Controls.Add(this.PanelGraveyard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelGraveyard;
        private System.Windows.Forms.FlowLayoutPanel PanelRoleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.ListBox ListBoxRemainingRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

