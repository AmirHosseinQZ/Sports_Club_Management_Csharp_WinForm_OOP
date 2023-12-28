using oop_course_project.Forms;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oop_course_project.Classes
{
    public class MainManager
    {
        private static List<Player> playerList = new List<Player>();
        private static List<Coach> coacheList = new List<Coach>();
        private static List<Employee> employeeList = new List<Employee>();

        public static int valueForEditInt = 0;

        public MainManager()
        {

            // TODO Load members data from files we saved in previous runs
        }
        public void AddNewPlayer(Player p)/*(string name, string national, int age, int number, int gaols, int contractValue, string position)*/
        {
            // Player a = new Player(name, national, age, number, gaols, contractValue, position);
            // Get a new player info from user
            foreach (Player item in playerList)
            {
                if (item.GetNationalCode == frmEdit.valueForEdit)
                {
                    playerList[playerList.IndexOf(item)] = p;
                    return;
                }
            }
            playerList.Add(p);
        }

        public void AddNewCoach(Coach c)
        {
            foreach (Coach i in coacheList)
            {
                if (i.GetNationalCode == frmEdit.valueForEdit)
                {
                    coacheList[coacheList.IndexOf(i)] = c;
                    valueForEditInt = 0;
                    return;
                }
            }
            coacheList.Add(c);
            valueForEditInt = 0;
        }

        public void AddNewEmployee(Employee e)
        {
            foreach (Employee i in employeeList)
            {
                if (i.GetNationalCode == frmEdit.valueForEdit)
                {
                    employeeList[employeeList.IndexOf(i)] = e;
                    valueForEditInt = 0;
                    return;
                }
            }
            employeeList.Add(e);
            valueForEditInt = 0;
        }
        public List<string> GetListPlayer()
        {
            List<string> list = new List<string>();
            foreach (var item in playerList)
            {
                list.Add(item.GetDataAsString());
            }
            return list;
        }
        public List<string> GetListCoach()
        {
            List<string> list = new List<string>();
            foreach (var item in coacheList)
            {
                list.Add(item.GetDataAsString());
            }
            return list;
        }
        public List<string> GetListEployee()
        {
            List<string> list = new List<string>();
            foreach (var item in employeeList)
            {
                list.Add(item.GetDataAsString());
            }
            return list;
        }

        // سرچ در تمام اعضا بر اساس نام
        public List<string> SearchByName(string name)
        {
            List<string> list = new List<string>();
            foreach (var item in playerList)
            {
                if (item.GetName() == name)
                {
                    list.Add(item.GetDataAsString());
                }
            }
            foreach (var item in coacheList)
            {
                if (item.GetName() == name)
                {
                    list.Add(item.GetDataAsString());
                }

            }
            foreach (var item in employeeList)
            {
                if (item.GetName() == name)
                {
                    list.Add(item.GetDataAsString());
                }
            }

            return list;

        }
        // Search all members by age
        public List<string> SearchByAge(int age)
        {
            List<string> list = new List<string>();
            foreach (var item in playerList)
            {
                if (item.GetAge() == age)
                {
                    list.Add(item.GetDataAsString());
                }
            }
            foreach (var item in coacheList)
            {
                if (item.GetAge() == age)
                {
                    list.Add(item.GetDataAsString());
                }

            }
            foreach (var item in employeeList)
            {
                if (item.GetAge() == age)
                {
                    list.Add(item.GetDataAsString());
                }
            }

            return list;
        }
        // Search all members based on work field
        public List<string> SearchByField(string fieldName)
        {
            List<string> list = new List<string>();
            foreach (var item in coacheList)
            {
                if (item.GetField() == fieldName)
                {
                    list.Add(item.GetDataAsString());
                }
            }

            return list;
        }
        public void LoadDataFromFile(string path)
        {
            // TODO: Read all members data from the files we saved in previous runs
            StreamReader r1 = new StreamReader(path);
            try
            {
                if (path == "Player.txt")
                {
                    while (r1.Peek() != -1)
                    {
                        string[] s = r1.ReadLine().Split(',');
                        Player p1 = new Player(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToInt32(s[4]), Convert.ToInt32(s[5]), Convert.ToInt32(s[3]), s[6]);
                        playerList.Add(p1);
                    }
                }
                else if (path == "Coach.txt")
                {
                    while (r1.Peek() != -1)
                    {
                        string[] s = r1.ReadLine().Split(',');
                        Coach p1 = new Coach(s[1], s[0], Convert.ToInt32(s[2]), s[4], Convert.ToInt32(s[3]));
                        coacheList.Add(p1);
                    }
                }
                else if (path == "Employee.txt")
                {
                    while (r1.Peek() != -1)
                    {
                        string[] s = r1.ReadLine().Split(',');
                        Employee p1 = new Employee(s[3], s[4], Convert.ToInt32(s[5]), s[1], s[0], Convert.ToInt32(s[2]));
                        employeeList.Add(p1);
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                r1.Close();
            }


        }
        public void SaveDataToFile(string path)
        {
            bool isExist = false;
            StreamWriter s1 = new StreamWriter(path, isExist);
            if (path == "Coach.txt")
            {
                foreach (var item in coacheList)
                {
                    s1.WriteLine(item.GetStringToSaveFile());
                }
            }
            else if (path == "Player.txt")
            {
                foreach (var item in playerList)
                {
                    s1.WriteLine(item.GetStringToSaveFile());
                }
            }
            else if (path == "Employee.txt")
            {
                foreach (var item in employeeList)
                {
                    s1.WriteLine(item.GetStringToSaveFile());
                }
            }
            s1.Flush();
            s1.Close();
        }
        public string EditForm()
        {
            string uData = null;
            foreach (Player player in playerList)
            {
                if (frmEdit.valueForEdit == player.GetNationalCode)
                {
                    uData = player.GetStringToSaveFile();

                    valueForEditInt = 1;
                    return uData;
                }
            }
            foreach (Coach coach in coacheList)
            {
                if (frmEdit.valueForEdit == coach.GetNationalCode)
                {
                    uData = coach.GetStringToSaveFile();
                    valueForEditInt = 2;
                    return uData;
                }
            }
            foreach (Employee employee in employeeList)
            {
                if (frmEdit.valueForEdit == employee.GetNationalCode)
                {
                    uData = employee.GetStringToSaveFile();
                    valueForEditInt = 3;
                    return uData;
                }
            }
            return null;
        }
        public List<string> GetListPlayerSortedWithName()
        {
            List<string> list = new List<string>();
            foreach (var item in playerList)
            {
                list.Add(item.GetStringToSaveFile());
            }
            list.Sort();
            List<string> result = new List<string>();
            foreach (var item in list)
            {
                string b;
                string[] a = item.Split(',');
                b = $" شماره بازیکن : {a[4]} | نام بازیکن  : {a[0]} | شماره ملی بازیکن : {a[1]} | " +
                $"سن بازیکن : {a[2]} |  تعداد گل ها : {a[5]} | مبلغ قرارداد : {a[3]} | موقعیت : {a[6]} ";
                result.Add(b);
            }
            return result;
        }
        public List<string> GetListPlayerSortedWithAge()
        {
            List<string> list = new List<string>();
            foreach (var item in playerList)
            {
                list.Add(item.GetStringToSaveFile());
            }
            list.Sort();
            List<int> age = new List<int>();
            foreach (var item in list)
            {
                string[] d = item.Split(',');
                age.Add(Convert.ToInt32(d[2]));
            }
            age.Sort();
            list.Clear();
            for (int i = 0; i < age.Count; i++)
            {
                foreach (var item in playerList)
                {
                    if (age[i] == item.GetAge())
                    {
                        list.Add(item.GetDataAsString());
                        break;
                    }
                }
            }
            return list;
        }
        public List<string> GetListPlayerSortedWithContractValue()
        {
            List<string> list = new List<string>();
            foreach (var item in playerList)
            {
                list.Add(item.GetStringToSaveFile());
            }
            list.Sort();
            List<int> contractvalue = new List<int>();
            foreach (var item in list)
            {
                string[] d = item.Split(',');
                contractvalue.Add(Convert.ToInt32(d[3]));
            }
            contractvalue.Sort();
            list.Clear();
            for (int i = 0; i < contractvalue.Count; i++)
            {
                foreach (var item in playerList)
                {
                    if (contractvalue[i] == item.GetContractValue)
                    {
                        list.Add(item.GetDataAsString());
                        break;
                    }
                }
            }
            return list;
        }
        public List<string> GetListPlayerByPosition(string position)
        {
            List<string> list = new List<string>();
            foreach (var item in playerList)
            {
                if (position == item.GetPosition)
                {
                    list.Add(item.GetDataAsString());
                }
            }
            return list;
        }
        public List<string> GetTheardBestGoaler()
        {
            List<string> list = new List<string>();
            foreach (var item in playerList)
            {
                list.Add(item.GetStringToSaveFile());
            }
            List<int> goales = new List<int>();
            foreach (var item in list)
            {
                string[] d = item.Split(',');
                goales.Add(Convert.ToInt32(d[5]));
            }
            goales.Sort();
            list.Clear();
            for (int i = goales.Count - 3; i < goales.Count ; i++)
            {
                foreach (var item in playerList)
                {
                    if (goales[i] == item.GetGoals)
                    {
                        list.Add(item.GetDataAsString());
                        break;
                    }
                }
            }
            return list;
        }
        public bool IsRepeated(string nationalCode)
        {
            foreach (var item in playerList)
            {
                if (item.GetNationalCode == nationalCode)
                {
                    return true;
                }
            }
            foreach (var item in coacheList)
            {
                if (item.GetNationalCode == nationalCode)
                {
                    return true;
                }

            }
            foreach (var item in employeeList)
            {
                if (item.GetNationalCode == nationalCode)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Delete(string nationalCode)
        {
            foreach (var item in playerList)
            {
                if (item.GetNationalCode == nationalCode)
                {
                    playerList.Remove(item);
                    SaveDataToFile("Player.txt");
                    return true;
                }
            }
            foreach (var item in coacheList)
            {
                if (item.GetNationalCode == nationalCode)
                {
                    coacheList.Remove(item);
                    SaveDataToFile("Coach.txt");
                    return true;
                }

            }
            foreach (var item in employeeList)
            {
                if (item.GetNationalCode == nationalCode)
                {
                    employeeList.Remove(item);
                    SaveDataToFile("Employee.txt");
                    return true;
                }
            }
            return false;

        }
    }
} 
