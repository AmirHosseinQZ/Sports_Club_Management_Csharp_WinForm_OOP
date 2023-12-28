using oop_course_project.Classes;
using oop_course_project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_course_project
{
    public partial class frmMain : Form
    {
        #region Move Form
        private bool dragging;
        private Point pointClicked;
        #endregion
        MainManager mainManager;
        public frmMain()
        {
            InitializeComponent();
            mainManager = new MainManager();               
        }

        private void prtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void prtMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region  The section related to adding members
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            frmAddPlayer player = new frmAddPlayer();
            player.DialogResult = DialogResult.Yes;
            player.ShowDialog();
            
            if (player.DialogResult == DialogResult.OK)
            {
                mainManager.SaveDataToFile("Player.txt");
                toolLableOpreation.ForeColor = Color.Green;
                toolLableOpreation.Text = "بازیکن جدید با موفقیت افزوده شد";
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee employee = new frmAddEmployee();
            employee.ShowDialog();
            if (employee.DialogResult == DialogResult.OK)
            {
                toolLableOpreation.ForeColor = Color.Green;
                toolLableOpreation.Text = "کارمند جدید با موفقیت افزوده شد";
            }
        }
        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            frmAddCoach coach = new frmAddCoach();
            coach.ShowDialog();
            if (coach.DialogResult == DialogResult.OK)
            {
                toolLableOpreation.ForeColor = Color.Green;
                toolLableOpreation.Text = "مربی جدید با موفقیت افزوده شد";
            }
        }
        #endregion

        #region The section related to moving the forms 
        //  حرکت دادن فرم
        private void frmMain_MouseDown_1(object sender, MouseEventArgs e)
        {
            #region Move Form
            if (e.Button == MouseButtons.Left)
            {
                // turn drag mode on and store the point clicked.
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
            #endregion
        }
        private void frmMain_MouseUp_1(object sender, MouseEventArgs e)
        {
            #region Move Form
            dragging = false;
            #endregion
        }
        private void frmMain_MouseMove_1(object sender, MouseEventArgs e)
        {
            #region Move Form
            if (dragging)
            {
                Point pointMoveTo;
                // Find the current mouse position in screen coordinates.
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                // Compensate for the position the control was clicked.
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                // Move the form.
                this.Location = pointMoveTo;
            }
            #endregion
        }
        #endregion

        // In this section, information from the files must be loaded at the same time as the program is running
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Loading the saved data file
            mainManager.LoadDataFromFile("Player.txt");
            mainManager.LoadDataFromFile("Coach.txt");
            mainManager.LoadDataFromFile("Employee.txt");
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit edit = new frmEdit();
            edit.ShowDialog();
        }

        #region The section related to displaying lists
        //////////////// Lists ///////////////////////
        // Print the list of players
        private void btnPlayersList_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListPlayer())
            {
                richTextBox1.Text += item + "\a\n" + "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }
        // Print the list of coaches
        private void btnCoachesList_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListCoach())
            {
                richTextBox1.Text += item + "\a\n" + "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }
        // Print the list of employees
        private void btnEmployeesList_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListEployee())
            {
                richTextBox1.Text += item + "\a\n" + "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }
        // Print the whole list
        private void btnListAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListEployee())
            {
                richTextBox1.Text += item + "\a\n" + "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
            foreach (var item in mainManager.GetListCoach())
            {
                richTextBox1.Text += item + "\a\n" + "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
            foreach (var item in mainManager.GetListPlayer())
            {
                richTextBox1.Text += item + "\a\n" + "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }
        //////////////////////////////////////////////////
        #endregion


        #region The section related to sorting openers based on the desired field
        private void نامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListPlayerSortedWithName())
            {
                richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
            
        }
        private void سنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListPlayerSortedWithAge())
            {
                richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }
        private void فیلدکاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListPlayerSortedWithContractValue())
            {
                richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
            
        }
        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboSearch.Text == "بر اساس نام اعضا")
                {
                    richTextBox1.Text = null;
                    foreach (var item in mainManager.SearchByName(txtSearch.Text))
                    {
                        richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
                    }
                }
                else if (comboSearch.Text == "بر اساس فیلد کاری")
                {
                    richTextBox1.Text = null;
                    foreach (var item in mainManager.SearchByField(txtSearch.Text))
                    {
                        richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
                    }
                }
                else if (comboSearch.Text == "بر اساس سن اعضا")
                {
                    richTextBox1.Text = null;
                    foreach (var item in mainManager.SearchByAge(Convert.ToInt32(txtSearch.Text)))
                    {
                        richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("مقدار صحیح وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmEdit f = new frmEdit();
            frmEdit.opreation = 1;
            f.ShowDialog();
        }

        private void هافبکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListPlayerByPosition("هافبک"))
            {
                richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }

        private void مدافعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListPlayerByPosition("مدافع"))
            {
                richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }

        private void مهاجمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListPlayerByPosition("مهاجم"))
            {
                richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }

        private void دروازهبانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetListPlayerByPosition("دروازبان"))
            {
                richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in mainManager.GetTheardBestGoaler())
            {
                richTextBox1.Text += item + "\a\n" + "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\a\n";
            }
        }

        private void prtClose_MouseHover(object sender, EventArgs e)
        {
            prtClose.BackColor = Color.Pink;
        }
    }
}
