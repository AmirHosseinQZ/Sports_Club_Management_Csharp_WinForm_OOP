using oop_course_project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_course_project.Forms
{
    public partial class frmAddEmployee : Form
    {
        MainManager mainManager;
        public frmAddEmployee()
        {
            InitializeComponent();
            mainManager = new MainManager();
        }

        private void prtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            if (MainManager.valueForEditInt == 3)
            {
                this.groupBox1.Text = "ویراش کارمند";
                this.StartPosition = FormStartPosition.CenterParent;
                string a = mainManager.EditForm();
                string[] s = a.Split(',');
                txtName.Text = s[1];
                txtNationalCode.Text = s[0];
                numericAge.Value = Convert.ToInt32(s[2]);
                numericPersonnalCode.Value = Convert.ToInt32(s[3]);
                txtPosition.Text = s[4];
                numericSalary.Value = Convert.ToInt32(s[5]);
            }

            else
            {
                this.groupBox1.Text = "افزودن کارمند";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtNationalCode.Text != "" && numericPersonnalCode.Value != 0 && txtPosition.Text != "")
            {
                bool l = true;

                if (!mainManager.IsRepeated(txtNationalCode.Text))
                {
                    try
                    {                       
                        Employee p1 = new Employee(numericPersonnalCode.Value.ToString(), txtPosition.Text, Convert.ToInt32(numericSalary.Value), txtName.Text, txtNationalCode.Text, Convert.ToInt32(numericAge.Value));
                        mainManager.AddNewEmployee(p1);
                        mainManager.SaveDataToFile("Employee.txt");
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception error)
                    {
                        DialogResult = DialogResult.No;
                        MessageBox.Show(error.Message, "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("این شماره ملی قبلا ثیت شده است ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
