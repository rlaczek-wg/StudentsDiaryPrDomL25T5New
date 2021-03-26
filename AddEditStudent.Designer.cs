
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentsDiary
{
    partial class AddEditStudent
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTechnology = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhysic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPolishLang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbForeignLang = new System.Windows.Forms.TextBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbExtraActivities = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGroupId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(132, 32);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(216, 26);
            this.tbId.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(24, 32);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(23, 20);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matematyka";
            // 
            // tbTechnology
            // 
            this.tbTechnology.Location = new System.Drawing.Point(132, 165);
            this.tbTechnology.Name = "tbTechnology";
            this.tbTechnology.Size = new System.Drawing.Size(216, 26);
            this.tbTechnology.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(132, 95);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(216, 26);
            this.tbLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(132, 132);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(216, 26);
            this.tbMath.TabIndex = 2;
            this.tbMath.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(132, 65);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(216, 26);
            this.tbFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Imie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Technologia";
            // 
            // tbPhysic
            // 
            this.tbPhysic.Location = new System.Drawing.Point(132, 197);
            this.tbPhysic.Name = "tbPhysic";
            this.tbPhysic.Size = new System.Drawing.Size(216, 26);
            this.tbPhysic.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fizyka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jez. polski";
            // 
            // tbPolishLang
            // 
            this.tbPolishLang.Location = new System.Drawing.Point(132, 229);
            this.tbPolishLang.Name = "tbPolishLang";
            this.tbPolishLang.Size = new System.Drawing.Size(216, 26);
            this.tbPolishLang.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jez. obcy";
            // 
            // tbForeignLang
            // 
            this.tbForeignLang.Location = new System.Drawing.Point(132, 262);
            this.tbForeignLang.Name = "tbForeignLang";
            this.tbForeignLang.Size = new System.Drawing.Size(216, 26);
            this.tbForeignLang.TabIndex = 11;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(129, 388);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(216, 107);
            this.rtbComments.TabIndex = 12;
            this.rtbComments.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Uwagi";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(246, 503);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 35);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Zatwierdz";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(129, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbExtraActivities
            // 
            this.chbExtraActivities.AutoSize = true;
            this.chbExtraActivities.Location = new System.Drawing.Point(178, 305);
            this.chbExtraActivities.Name = "chbExtraActivities";
            this.chbExtraActivities.Size = new System.Drawing.Size(22, 21);
            this.chbExtraActivities.TabIndex = 16;
            this.chbExtraActivities.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 305);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dodatkowe zajecia";
            // 
            // cbGroupId
            // 
            this.cbGroupId.FormattingEnabled = true;
            this.cbGroupId.Location = new System.Drawing.Point(132, 334);
            this.cbGroupId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGroupId.Name = "cbGroupId";
            this.cbGroupId.Size = new System.Drawing.Size(180, 28);
            this.cbGroupId.TabIndex = 18;
            this.cbGroupId.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Klasa";
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbGroupId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chbExtraActivities);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.tbForeignLang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPolishLang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhysic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbTechnology);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.MaximumSize = new System.Drawing.Size(589, 600);
            this.MinimumSize = new System.Drawing.Size(490, 500);
            this.Name = "AddEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie ucznia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTechnology;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhysic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPolishLang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbForeignLang;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbExtraActivities;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGroupId;
        private System.Windows.Forms.Label label10;

    }
}