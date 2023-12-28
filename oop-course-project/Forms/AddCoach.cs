using oop_course_project.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace oop_course_project.Forms
{
    public partial class frmAddCoach : Form
    {
        MainManager mainManager;
        public frmAddCoach()
        {
            InitializeComponent();
            mainManager = new MainManager();
        }

        private void prtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCoach_Load(object sender, EventArgs e)
        {
            if (MainManager.valueForEditInt == 2)
            {
                this.groupBox1.Text = "ویراش مربی";
                this.StartPosition = FormStartPosition.CenterParent;
                string a = mainManager.EditForm();
                string[] s = a.Split(',');
                txtName.Text = s[1];
                txtNationalCode.Text = s[0];
                numericAge.Value = Convert.ToInt32(s[2]);
                numericContractValue.Value = Convert.ToInt32(s[3]);
                comboField.Text = s[4];

            }

            else
            {
                this.groupBox1.Text = "افزودن مربی";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtNationalCode.Text != "" & comboField.Text != "")
            {
                bool l = false;
                if (MainManager.valueForEditInt == 2)
                {
                    l = mainManager.IsRepeated(txtNationalCode.Text);
                }
                if (l)
                {
                    try
                    {
                        
                        Coach a = new Coach(txtName.Text, txtNationalCode.Text, Convert.ToInt32(numericAge.Value), comboField.Text, Convert.ToInt32(numericContractValue.Value));
                        mainManager.AddNewCoach(a);
                        mainManager.SaveDataToFile("Coach.txt");
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        DialogResult = DialogResult.No;
                        MessageBox.Show(ex.Message, "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("این شماره ملی قبلا ثیت شده است ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void comboField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
