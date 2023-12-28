namespace oop_course_project.Forms
{
    partial class frmAddCoach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCoach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboField = new System.Windows.Forms.ComboBox();
            this.numericContractValue = new System.Windows.Forms.NumericUpDown();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prtClose = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericContractValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboField);
            this.groupBox1.Controls.Add(this.numericContractValue);
            this.groupBox1.Controls.Add(this.numericAge);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNationalCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Vazir", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(379, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن مربی";
            // 
            // comboField
            // 
            this.comboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboField.Font = new System.Drawing.Font("Vazir", 12F);
            this.comboField.Items.AddRange(new object[] {
            "سر مربی",
            "کمک مربی",
            "مربی"});
            this.comboField.Location = new System.Drawing.Point(14, 192);
            this.comboField.Name = "comboField";
            this.comboField.Size = new System.Drawing.Size(253, 33);
            this.comboField.Sorted = true;
            this.comboField.TabIndex = 6;
            this.comboField.SelectedIndexChanged += new System.EventHandler(this.comboField_SelectedIndexChanged);
            // 
            // numericContractValue
            // 
            this.numericContractValue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericContractValue.Font = new System.Drawing.Font("Vazir", 12F);
            this.numericContractValue.Location = new System.Drawing.Point(14, 151);
            this.numericContractValue.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericContractValue.Name = "numericContractValue";
            this.numericContractValue.Size = new System.Drawing.Size(253, 32);
            this.numericContractValue.TabIndex = 5;
            // 
            // numericAge
            // 
            this.numericAge.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericAge.Font = new System.Drawing.Font("Vazir", 12F);
            this.numericAge.Location = new System.Drawing.Point(14, 110);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(253, 32);
            this.numericAge.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Vazir", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(45, 239);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ثبت اطلاعات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazir", 10F);
            this.label7.Location = new System.Drawing.Point(291, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "زمینه کاری : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazir", 10F);
            this.label6.Location = new System.Drawing.Point(286, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "مبلغ قرارداد : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 10F);
            this.label3.Location = new System.Drawing.Point(333, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "سن :";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNationalCode.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalCode.Location = new System.Drawing.Point(14, 68);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(253, 32);
            this.txtNationalCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 10F);
            this.label2.Location = new System.Drawing.Point(295, 74);
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
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام  :";
            // 
            // prtClose
            // 
            this.prtClose.Image = ((System.Drawing.Image)(resources.GetObject("prtClose.Image")));
            this.prtClose.Location = new System.Drawing.Point(365, 10);
            this.prtClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prtClose.Name = "prtClose";
            this.prtClose.Size = new System.Drawing.Size(26, 25);
            this.prtClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prtClose.TabIndex = 4;
            this.prtClose.TabStop = false;
            this.prtClose.Click += new System.EventHandler(this.prtClose_Click);
            // 
            // frmAddCoach
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prtClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCoach";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCoach";
            this.Load += new System.EventHandler(this.frmAddCoach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericContractValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prtClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericContractValue;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox prtClose;
        private System.Windows.Forms.ComboBox comboField;
    }
}