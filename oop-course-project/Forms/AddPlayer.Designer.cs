namespace oop_course_project
{
    partial class frmAddPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPlayer));
            this.prtClose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPosition = new System.Windows.Forms.ComboBox();
            this.numericContractValue = new System.Windows.Forms.NumericUpDown();
            this.numericGoals = new System.Windows.Forms.NumericUpDown();
            this.numericNumber = new System.Windows.Forms.NumericUpDown();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prtClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericContractValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // prtClose
            // 
            this.prtClose.Image = ((System.Drawing.Image)(resources.GetObject("prtClose.Image")));
            this.prtClose.Location = new System.Drawing.Point(12, 7);
            this.prtClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prtClose.Name = "prtClose";
            this.prtClose.Size = new System.Drawing.Size(26, 25);
            this.prtClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prtClose.TabIndex = 2;
            this.prtClose.TabStop = false;
            this.prtClose.Click += new System.EventHandler(this.prtClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboPosition);
            this.groupBox1.Controls.Add(this.numericContractValue);
            this.groupBox1.Controls.Add(this.numericGoals);
            this.groupBox1.Controls.Add(this.numericNumber);
            this.groupBox1.Controls.Add(this.numericAge);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNationalCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Vazir", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(372, 402);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن  بازیکن";
            // 
            // comboPosition
            // 
            this.comboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPosition.Font = new System.Drawing.Font("Vazir", 12F);
            this.comboPosition.FormattingEnabled = true;
            this.comboPosition.Items.AddRange(new object[] {
            "دروازبان",
            "مدافع",
            "مهاجم",
            "هافبک"});
            this.comboPosition.Location = new System.Drawing.Point(14, 289);
            this.comboPosition.Name = "comboPosition";
            this.comboPosition.Size = new System.Drawing.Size(253, 33);
            this.comboPosition.TabIndex = 6;
            // 
            // numericContractValue
            // 
            this.numericContractValue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericContractValue.Font = new System.Drawing.Font("Vazir", 12F);
            this.numericContractValue.Location = new System.Drawing.Point(14, 248);
            this.numericContractValue.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericContractValue.Name = "numericContractValue";
            this.numericContractValue.Size = new System.Drawing.Size(253, 32);
            this.numericContractValue.TabIndex = 5;
            // 
            // numericGoals
            // 
            this.numericGoals.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericGoals.Font = new System.Drawing.Font("Vazir", 12F);
            this.numericGoals.Location = new System.Drawing.Point(14, 202);
            this.numericGoals.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericGoals.Name = "numericGoals";
            this.numericGoals.Size = new System.Drawing.Size(253, 32);
            this.numericGoals.TabIndex = 4;
            // 
            // numericNumber
            // 
            this.numericNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericNumber.Font = new System.Drawing.Font("Vazir", 12F);
            this.numericNumber.Location = new System.Drawing.Point(14, 157);
            this.numericNumber.Name = "numericNumber";
            this.numericNumber.Size = new System.Drawing.Size(253, 32);
            this.numericNumber.TabIndex = 3;
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
            this.btnSave.Location = new System.Drawing.Point(45, 336);
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
            this.label7.Location = new System.Drawing.Point(295, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "موقعیت : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazir", 10F);
            this.label6.Location = new System.Drawing.Point(275, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "مبلغ قرارداد : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir", 10F);
            this.label5.Location = new System.Drawing.Point(292, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "تعداد گل :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 10F);
            this.label4.Location = new System.Drawing.Point(269, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "شماره بازیکن :";
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
            // frmAddPlayer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prtClose);
            this.Font = new System.Drawing.Font("Vazir", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddPlayer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prtClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericContractValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox prtClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.NumericUpDown numericContractValue;
        private System.Windows.Forms.NumericUpDown numericGoals;
        private System.Windows.Forms.NumericUpDown numericNumber;
        private System.Windows.Forms.ComboBox comboPosition;
    }
}