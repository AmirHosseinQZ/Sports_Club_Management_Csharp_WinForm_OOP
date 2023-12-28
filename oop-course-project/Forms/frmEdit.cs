using oop_course_project.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_course_project.Forms
{
    public partial class frmEdit : Form
    {
        MainManager mainManager;
        public frmEdit()
        {
            InitializeComponent();
            mainManager = new MainManager();
        }
        public static string valueForEdit = "";
        public static int opreation = 0;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (opreation == 0)
            {
                valueForEdit = txtSearchForEdit.Text;
                if (mainManager.EditForm() == null)
                {
                    MessageBox.Show("Member Not Found", "Not Found", MessageBoxButtons.OK);
                }
                else if (MainManager.valueForEditInt == 1)
                {
                    frmAddPlayer f = new frmAddPlayer();
                    f.ShowDialog();
                    this.Close();
                }
                else if (MainManager.valueForEditInt == 2)
                {
                    frmAddCoach f = new frmAddCoach();
                    f.ShowDialog();
                    this.Close();
                }
                else if (MainManager.valueForEditInt == 3)
                {
                    frmAddEmployee f = new frmAddEmployee();
                    f.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                try
                {
                    if (mainManager.Delete(txtSearchForEdit.Text))
                    {
                        MessageBox.Show("عضو با موفقیت حذف شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("عضو حذف نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("عضو حذف نشد" + ex, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
