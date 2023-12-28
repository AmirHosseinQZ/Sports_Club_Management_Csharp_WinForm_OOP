namespace oop_course_project.Forms
{
    partial class frmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            this.txtPosition = new System.Windows.Forms.ComboBox();
            this.prtClose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.numericPersonnalCode = new System.Windows.Forms.NumericUpDown();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prtClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPersonnalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtPosition.Font = new System.Drawing.Font("Vazir", 12F);
            this.txtPosition.FormattingEnabled = true;
            this.txtPosition.Items.AddRange(new object[] {
            "امورمالی",
            "تدارکات",
            "حسابدار",
            "مدیر",
            "مسئول خرید"});
            this.txtPosition.Location = new System.Drawing.Point(14, 243);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(253, 33);
            this.txtPosition.Sorted = true;
            this.txtPosition.TabIndex = 6;
            // 
            // prtClose
            // 
            this.prtClose.Image = ((System.Drawing.Image)(resources.GetObject("prtClose.Image")));
            this.prtClose.Location = new System.Drawing.Point(358, 6);
            this.prtClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prtClose.Name = "prtClose";
            this.prtClose.Size = new System.Drawing.Size(26, 25);
            this.prtClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prtClose.TabIndex = 3;
            this.prtClose.TabStop = false;
            this.prtClose.Click += new System.EventHandler(this.prtClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.numericSalary);
            this.groupBox1.Controls.Add(this.numericPersonnalCode);
            this.groupBox1.Controls.Add(this.numericAge);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNationalCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Vazir", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(372, 358);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن کارمند";
            // 
            // numericSalary
            // 
            this.numericSalary.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericSalary.Font = new System.Drawing.Font("Vazir", 12F);
            this.numericSalary.Location = new System.Drawing.Point(14, 202);
            this.numericSalary.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(253, 32);
            this.numericSalary.TabIndex = 4;
            // 
            // numericPersonnalCode
            // 
            this.numericPersonnalCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericPersonnalCode.Font = new System.Drawing.Font("Vazir", 12F);
            this.numericPersonnalCode.Location = new System.Drawing.Point(14, 157);
            this.numericPersonnalCode.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericPersonnalCode.Name = "numericPersonnalCode";
            this.numericPersonnalCode.Size = new System.Drawing.Size(253, 32);
            this.numericPersonnalCode.TabIndex = 3;
            // 
            // numericAge
            // 
            this.numericAge.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericAge.Font = new System.Drawing.Font("Vazir", 12F);
            this.numericAge.Location = new System.Drawing.Point(14, 113);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(253, 32);
            this.numericAge.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Vazir", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(48, 289);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ثبت اطلاعات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazir", 10F);
            this.label7.Location = new System.Drawing.Point(265, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "پست سازمانی :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir", 10F);
            this.label5.Location = new System.Drawing.Point(278, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "میزان حقوق :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 10F);
            this.label4.Location = new System.Drawing.Point(284, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "کد پرسنلی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 10F);
            this.label3.Location = new System.Drawing.Point(322, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "سن :";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNationalCode.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalCode.Location = new System.Drawing.Point(14, 71);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(253, 32);
            this.txtNationalCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 10F);
            this.label2.Location = new System.Drawing.Point(284, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "شماره ملی :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtName.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(14, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 32);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 10F);
            this.label1.Location = new System.Drawing.Point(324, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام  :";
            // 
            // frmAddEmployee
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prtClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prtClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPersonnalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox prtClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.NumericUpDown numericPersonnalCode;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtPosition;
    }
}