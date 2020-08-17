namespace Oefening5
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
            this.cbSchool = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbJaar = new System.Windows.Forms.ComboBox();
            this.lblRichting = new System.Windows.Forms.Label();
            this.cbRichting = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLeerling = new System.Windows.Forms.ComboBox();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMedian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddPunten = new System.Windows.Forms.TextBox();
            this.btnAddPunten = new System.Windows.Forms.Button();
            this.lbPunten = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVakken = new System.Windows.Forms.ComboBox();
            this.txtAddStudent = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSchool
            // 
            this.cbSchool.FormattingEnabled = true;
            this.cbSchool.Location = new System.Drawing.Point(67, 49);
            this.cbSchool.Name = "cbSchool";
            this.cbSchool.Size = new System.Drawing.Size(160, 21);
            this.cbSchool.TabIndex = 0;
            this.cbSchool.SelectedIndexChanged += new System.EventHandler(this.cbSchool_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "School:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jaar:";
            // 
            // cbJaar
            // 
            this.cbJaar.FormattingEnabled = true;
            this.cbJaar.Location = new System.Drawing.Point(67, 87);
            this.cbJaar.Name = "cbJaar";
            this.cbJaar.Size = new System.Drawing.Size(160, 21);
            this.cbJaar.TabIndex = 2;
            // 
            // lblRichting
            // 
            this.lblRichting.AutoSize = true;
            this.lblRichting.Location = new System.Drawing.Point(18, 131);
            this.lblRichting.Name = "lblRichting";
            this.lblRichting.Size = new System.Drawing.Size(49, 13);
            this.lblRichting.TabIndex = 5;
            this.lblRichting.Text = "Richting:";
            // 
            // cbRichting
            // 
            this.cbRichting.FormattingEnabled = true;
            this.cbRichting.Location = new System.Drawing.Point(67, 128);
            this.cbRichting.Name = "cbRichting";
            this.cbRichting.Size = new System.Drawing.Size(160, 21);
            this.cbRichting.TabIndex = 4;
            this.cbRichting.SelectedIndexChanged += new System.EventHandler(this.cbRichting_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Leerling:";
            // 
            // cbLeerling
            // 
            this.cbLeerling.FormattingEnabled = true;
            this.cbLeerling.Location = new System.Drawing.Point(67, 167);
            this.cbLeerling.Name = "cbLeerling";
            this.cbLeerling.Size = new System.Drawing.Size(160, 21);
            this.cbLeerling.TabIndex = 6;
            this.cbLeerling.SelectedIndexChanged += new System.EventHandler(this.cbLeerling_SelectedIndexChanged);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudent.Location = new System.Drawing.Point(234, 200);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(35, 23);
            this.btnNewStudent.TabIndex = 11;
            this.btnNewStudent.Text = "+";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.txtMedian);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddPunten);
            this.groupBox1.Controls.Add(this.btnAddPunten);
            this.groupBox1.Controls.Add(this.lbPunten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbVakken);
            this.groupBox1.Location = new System.Drawing.Point(287, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapport";
            // 
            // txtMedian
            // 
            this.txtMedian.Enabled = false;
            this.txtMedian.Location = new System.Drawing.Point(102, 172);
            this.txtMedian.Name = "txtMedian";
            this.txtMedian.Size = new System.Drawing.Size(70, 20);
            this.txtMedian.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gemiddelde:";
            // 
            // txtAddPunten
            // 
            this.txtAddPunten.Location = new System.Drawing.Point(102, 58);
            this.txtAddPunten.Name = "txtAddPunten";
            this.txtAddPunten.Size = new System.Drawing.Size(70, 20);
            this.txtAddPunten.TabIndex = 15;
            // 
            // btnAddPunten
            // 
            this.btnAddPunten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPunten.Location = new System.Drawing.Point(175, 58);
            this.btnAddPunten.Name = "btnAddPunten";
            this.btnAddPunten.Size = new System.Drawing.Size(25, 20);
            this.btnAddPunten.TabIndex = 13;
            this.btnAddPunten.Text = "+";
            this.btnAddPunten.UseVisualStyleBackColor = true;
            this.btnAddPunten.Click += new System.EventHandler(this.btnAddPunten_Click);
            // 
            // lbPunten
            // 
            this.lbPunten.FormattingEnabled = true;
            this.lbPunten.Location = new System.Drawing.Point(31, 58);
            this.lbPunten.Name = "lbPunten";
            this.lbPunten.Size = new System.Drawing.Size(65, 134);
            this.lbPunten.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vak:";
            // 
            // cbVakken
            // 
            this.cbVakken.FormattingEnabled = true;
            this.cbVakken.Location = new System.Drawing.Point(79, 19);
            this.cbVakken.Name = "cbVakken";
            this.cbVakken.Size = new System.Drawing.Size(121, 21);
            this.cbVakken.TabIndex = 0;
            this.cbVakken.SelectedIndexChanged += new System.EventHandler(this.cbVakken_SelectedIndexChanged);
            // 
            // txtAddStudent
            // 
            this.txtAddStudent.Location = new System.Drawing.Point(67, 200);
            this.txtAddStudent.Name = "txtAddStudent";
            this.txtAddStudent.Size = new System.Drawing.Size(160, 20);
            this.txtAddStudent.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 243);
            this.Controls.Add(this.txtAddStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLeerling);
            this.Controls.Add(this.lblRichting);
            this.Controls.Add(this.cbRichting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbJaar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSchool);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbJaar;
        private System.Windows.Forms.Label lblRichting;
        private System.Windows.Forms.ComboBox cbRichting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLeerling;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPunten;
        private System.Windows.Forms.ListBox lbPunten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVakken;
        private System.Windows.Forms.TextBox txtMedian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddPunten;
        private System.Windows.Forms.TextBox txtAddStudent;
    }
}

