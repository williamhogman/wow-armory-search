namespace Arm
{
    partial class viewer
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mana = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_race = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_resc = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_spec = new System.Windows.Forms.Label();
            this.team3 = new Arm.Team_Disp();
            this.team2 = new Arm.Team_Disp();
            this.team1 = new Arm.Team_Disp();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(158, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 31);
            this.lbl_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "HP";
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hp.Location = new System.Drawing.Point(54, 0);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(0, 29);
            this.lbl_hp.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mana";
            // 
            // lbl_mana
            // 
            this.lbl_mana.AutoSize = true;
            this.lbl_mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mana.Location = new System.Drawing.Point(54, 50);
            this.lbl_mana.Name = "lbl_mana";
            this.lbl_mana.Size = new System.Drawing.Size(52, 29);
            this.lbl_mana.TabIndex = 4;
            this.lbl_mana.Text = "600";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(159, 40);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(0, 26);
            this.lbl_class.TabIndex = 5;
            // 
            // lbl_race
            // 
            this.lbl_race.AutoSize = true;
            this.lbl_race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_race.Location = new System.Drawing.Point(308, 9);
            this.lbl_race.Name = "lbl_race";
            this.lbl_race.Size = new System.Drawing.Size(0, 20);
            this.lbl_race.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_hp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_resc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label22, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_spec, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_mana, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(61, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 100);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(112, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 18);
            this.label20.TabIndex = 5;
            this.label20.Text = "resc";
            // 
            // lbl_resc
            // 
            this.lbl_resc.AutoSize = true;
            this.lbl_resc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resc.Location = new System.Drawing.Point(155, 0);
            this.lbl_resc.Name = "lbl_resc";
            this.lbl_resc.Size = new System.Drawing.Size(0, 29);
            this.lbl_resc.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(112, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Talent";
            // 
            // lbl_spec
            // 
            this.lbl_spec.AutoSize = true;
            this.lbl_spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spec.Location = new System.Drawing.Point(155, 50);
            this.lbl_spec.Name = "lbl_spec";
            this.lbl_spec.Size = new System.Drawing.Size(0, 24);
            this.lbl_spec.TabIndex = 8;
            // 
            // team3
            // 
            this.team3.Location = new System.Drawing.Point(14, 513);
            this.team3.Name = "team3";
            this.team3.Size = new System.Drawing.Size(386, 104);
            this.team3.TabIndex = 25;
            // 
            // team2
            // 
            this.team2.Location = new System.Drawing.Point(14, 411);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(386, 104);
            this.team2.TabIndex = 24;
            // 
            // team1
            // 
            this.team1.Location = new System.Drawing.Point(14, 298);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(386, 104);
            this.team1.TabIndex = 23;

            // 
            // viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 626);
            this.Controls.Add(this.team3);
            this.Controls.Add(this.team2);
            this.Controls.Add(this.team1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_race);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.lbl_name);
            this.Name = "viewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_mana;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_race;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_resc;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_spec;
        private Team_Disp team1;
        private Team_Disp team2;
        private Team_Disp team3;
    }
}

