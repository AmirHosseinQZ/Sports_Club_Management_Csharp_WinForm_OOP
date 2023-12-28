using oop_course_project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_course_project
{
    public partial class frmAddPlayer : Form
    {
        MainManager mainManager;

        public frmAddPlayer()
        {
            InitializeComponent();
            mainManager = new MainManager();
        }

        private void prtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            if (MainManager.valueForEditInt == 1)
            {
                this.groupBox1.Text = "ویراش بازیکن";
                this.StartPosition = FormStartPosition.CenterParent;
                string a = mainManager.EditForm();
                string[] s = a.Split(',');
                txtName.Text = s[0];
                txtNationalCode.Text = s[1];
                numericAge.Value = Convert.ToInt32(s[2]);
                numericContractValue.Value = Convert.ToInt32(s[3]);
                numericNumber.Value = Convert.ToInt32(s[4]);
                numericGoals.Value = Convert.ToInt32(s[5]);
                comboPosition.Text = s[6];
            }

            else
            {
                this.groupBox1.Text = "افزودن  بازیکن";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtNationalCode.Text != "" && comboPosition.Text != "")
            {
                try
                {
                    bool l = true;

                    if (l)
                    {
                        Player p1 = new Player(txtName.Text, txtNationalCode.Text, Convert.ToInt32(numericAge.Value), Convert.ToInt32(numericNumber.Value), Convert.ToInt32(numericGoals.Value), Convert.ToInt32(numericContractValue.Value), comboPosition.SelectedItem.ToString());
                        mainManager.AddNewPlayer(p1);
                        mainManager.SaveDataToFile("Player.txt");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("این شماره ملی قبلا ثیت شده است ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    
                }
                catch (Exception error)
                {
                    DialogResult = DialogResult.No;
                    MessageBox.Show(error.Message, "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }

        }
    }
}
