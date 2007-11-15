namespace Arm
{
    partial class Team_Disp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_winloss = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lst_plrs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_winloss
            // 
            this.lbl_winloss.AutoSize = true;
            this.lbl_winloss.BackColor = System.Drawing.Color.Transparent;
            this.lbl_winloss.ForeColor = System.Drawing.Color.Red;
            this.lbl_winloss.Location = new System.Drawing.Point(319, 57);
            this.lbl_winloss.Name = "lbl_winloss";
            this.lbl_winloss.Size = new System.Drawing.Size(0, 13);
            this.lbl_winloss.TabIndex = 15;
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rating.ForeColor = System.Drawing.Color.Red;
            this.lbl_rating.Location = new System.Drawing.Point(317, 28);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(0, 29);
            this.lbl_rating.TabIndex = 14;
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_teamname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamname.Location = new System.Drawing.Point(12, 0);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(0, 24);
            this.lbl_teamname.TabIndex = 13;
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.BackColor = System.Drawing.Color.Transparent;
            this.lbl_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_size.Location = new System.Drawing.Point(12, 28);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(0, 42);
            this.lbl_size.TabIndex = 12;
            // 
            // lst_plrs
            // 
            this.lst_plrs.BackColor = System.Drawing.Color.Gray;
            this.lst_plrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_plrs.ForeColor = System.Drawing.Color.DarkGreen;
            this.lst_plrs.FormattingEnabled = true;
            this.lst_plrs.Location = new System.Drawing.Point(90, 28);
            this.lst_plrs.MultiColumn = true;
            this.lst_plrs.Name = "lst_plrs";
            this.lst_plrs.Size = new System.Drawing.Size(223, 65);
            this.lst_plrs.TabIndex = 11;
            // 
            // Team_Disp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arm.Properties.Resources.arena_backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_winloss);
            this.Controls.Add(this.lbl_rating);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lst_plrs);
            this.Name = "Team_Disp";
            this.Size = new System.Drawing.Size(386, 109);
            this.Load += new System.EventHandler(this.Team_Disp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_winloss;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.ListBox lst_plrs;
    }
}
