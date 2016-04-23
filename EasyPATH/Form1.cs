using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;


namespace EasyPATH
{
    public partial class Form1 : Form
    {

        Boolean[] system_env_path_exists = null;
        Boolean[] user_env_path_exists = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh_path();
            

       
        }

        private string[] path_splitter(string rawstr)
        {
            // remove things like ";;", ";;;", etc...
            rawstr = Regex.Replace(rawstr, ";+", ";");
            // remove first ";"
            rawstr = Regex.Replace(rawstr, "^;", "");
            // remove last ";"
            rawstr = Regex.Replace(rawstr, ";$", "");

            return rawstr.Split(';');
        }

        private Boolean[] path_existence_checker(string[] paths){
            Boolean[] path_exists = new Boolean[paths.Length];
            for (int i = 0; i < paths.Length; i++)
            {
                string s = paths[i];
                path_exists[i] = Directory.Exists(s) | File.Exists(s);
            }
            return path_exists;
        }

            


        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();


            // if ListBox is empty, do nothing
            if (e.Index == -1) return;

            Brush b = null;

            if (system_env_path_exists[e.Index])
                b = new SolidBrush(Color.Black);
            else
                b = new SolidBrush(Color.Red);

            // show strings
            string str = ((ListBox)sender).Items[e.Index].ToString();
            e.Graphics.DrawString(str, e.Font, b, e.Bounds);
            
            // release resource
            b.Dispose();
            
            e.DrawFocusRectangle();
        }

        private void listBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();


            // if ListBox is empty, do nothing
            if (e.Index == -1) return;

            Brush b = null;

            if (user_env_path_exists[e.Index])
                b = new SolidBrush(Color.Black);
            else
                b = new SolidBrush(Color.Red);

            // show strings
            string str = ((ListBox)sender).Items[e.Index].ToString();
            e.Graphics.DrawString(str, e.Font, b, e.Bounds);

            // release resource
            b.Dispose();

            e.DrawFocusRectangle();
        }



        private void button_refresh_Click(object sender, EventArgs e)
        {
            Refresh_path();
        }

        private void Refresh_path()
        {
            // initialize
            listBox_system.Items.Clear();
            listBox_user.Items.Clear();
           
            // set system environment PATH to listbox
            listBox_system.DrawMode = DrawMode.OwnerDrawFixed;
            listBox_system.ItemHeight = 20;

            string system_env_path_raw = null;
            foreach (System.Collections.DictionaryEntry de
                in System.Environment.GetEnvironmentVariables(
                System.EnvironmentVariableTarget.Machine))
            {
                if ((string)de.Key == "PATH") system_env_path_raw = (string)de.Value;
            }
            string[] system_env_path = path_splitter(system_env_path_raw);
            listBox_system.Items.AddRange(system_env_path);

            // set user environment PATH to listbox
            listBox_user.DrawMode = DrawMode.OwnerDrawFixed;
            listBox_user.ItemHeight = 20;

            string user_env_path_raw = System.Environment.GetEnvironmentVariable(
        "PATH", System.EnvironmentVariableTarget.User);
            string[] user_env_path = path_splitter(user_env_path_raw);
            listBox_user.Items.AddRange(user_env_path);

            // update path existence state
            Update_existence_state();
        }

        private void Update_existence_state(){
            system_env_path_exists = null;
            user_env_path_exists = null;

            string[] paths_sys  = listBox_system.Items.Cast<string>().ToArray();
            string[] paths_user = listBox_user.Items.Cast<string>().ToArray();

            system_env_path_exists = path_existence_checker(paths_sys);
            user_env_path_exists = path_existence_checker(paths_user);

        }


        private void button_clean_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to delete non-existent path?", "Dialog",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No) return;
            
            
            for (int i = system_env_path_exists.Length - 1; i >= 0; i--)
            {
                if (!system_env_path_exists[i])
                {
                    listBox_system.Items.RemoveAt(i);
                }
            }

            for (int i = user_env_path_exists.Length - 1; i >= 0; i--)
            {
                if (!user_env_path_exists[i])
                {
                    listBox_user.Items.RemoveAt(i);
                }
            }

            Update_existence_state();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to save to PATH?", "Dialog",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No) return;
            
            string[] env_path_system_array = listBox_system.Items.Cast<string>().ToArray();
            string env_path_system = String.Join(";", env_path_system_array) + ";";
            Environment.SetEnvironmentVariable("PATH", env_path_system, EnvironmentVariableTarget.Machine);

            string[] env_path_user_array = listBox_user.Items.Cast<string>().ToArray();
            string env_path_user = String.Join(";", env_path_user_array) + ";";
            Environment.SetEnvironmentVariable("PATH", env_path_user, EnvironmentVariableTarget.User);
        }

        private void button_add_sys_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Input a path to add", "Input dialog", "", -1, -1);
            if (input == "") return;
            listBox_system.Items.Add(input);
            Update_existence_state();
            
        }

        private void button_add_user_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Input a path to add", "Input dialog", "", -1, -1);
            // if no input, finish
            if (input == "") return;
            listBox_user.Items.Add(input);
            Update_existence_state();
        }

        private void button_delete_sys_Click(object sender, EventArgs e)
        {
            int sel = listBox_system.SelectedIndex;
            if (sel == -1) return;
            listBox_system.Items.RemoveAt(sel);

            // select valid line after deletion
            if (sel == listBox_system.Items.Count)
            {
                if(sel != 0)
                    listBox_system.SelectedIndex = sel-1;
            }
            else
            {
                listBox_system.SelectedIndex = sel;
            }
            
            Update_existence_state();
        }

        private void button_delete_user_Click(object sender, EventArgs e)
        {
            int sel = listBox_user.SelectedIndex;
            if (sel == -1) return;
            listBox_user.Items.RemoveAt(sel);

            // select valid line after deletion
            if (sel == listBox_user.Items.Count)
            {
                if (sel != 0)
                    listBox_user.SelectedIndex = sel - 1;
            }
            else
            {
                listBox_user.SelectedIndex = sel;
            }

            Update_existence_state();
        }

        private void button_up_sys_Click(object sender, EventArgs e)
        {
            int sel = listBox_system.SelectedIndex;
            if(sel == 0 || sel == -1) return;
            string removed = (string) listBox_system.Items[sel];
            listBox_system.Items.RemoveAt(sel);
            listBox_system.Items.Insert(sel-1, removed);
            listBox_system.SelectedIndex = sel - 1;

            Update_existence_state();
        }

        private void button_down_sys_Click(object sender, EventArgs e)
        {
            int sel = listBox_system.SelectedIndex;
            if (sel == listBox_system.Items.Count - 1 || sel == -1) return;
            string removed = (string)listBox_system.Items[sel];
            listBox_system.Items.RemoveAt(sel);
            if (sel == listBox_system.Items.Count - 1)
            {
                listBox_system.Items.Add(removed);
            }
            else
            {
                listBox_system.Items.Insert(sel + 1, removed);
            }
            listBox_system.SelectedIndex = sel + 1;

            Update_existence_state();
        }

        private void button_up_user_Click(object sender, EventArgs e)
        {
            int sel = listBox_user.SelectedIndex;
            if (sel == 0 || sel == -1) return;
            string removed = (string)listBox_user.Items[sel];
            listBox_user.Items.RemoveAt(sel);
            listBox_user.Items.Insert(sel - 1, removed);
            listBox_user.SelectedIndex = sel - 1;

            Update_existence_state();
        }

        private void button_down_user_Click(object sender, EventArgs e)
        {
            int sel = listBox_user.SelectedIndex;
            if (sel == listBox_user.Items.Count - 1 || sel == -1) return;
            string removed = (string)listBox_user.Items[sel];
            listBox_user.Items.RemoveAt(sel);
            if (sel == listBox_user.Items.Count - 1)
            {
                listBox_user.Items.Add(removed);
            }
            else
            {
                listBox_user.Items.Insert(sel + 1, removed);
            }
            listBox_user.SelectedIndex = sel + 1;

            Update_existence_state();
        }

        private void button_user_to_sys_Click(object sender, EventArgs e)
        {
            int sel = listBox_user.SelectedIndex;
            if (sel == -1) return;
            string removed = (string)listBox_user.Items[sel];
            listBox_user.Items.RemoveAt(sel);
            listBox_system.Items.Add(removed);

            Update_existence_state();
        }

        private void button_sys_to_user_Click(object sender, EventArgs e)
        {
            int sel = listBox_system.SelectedIndex;
            if (sel == -1) return;
            string removed = (string)listBox_system.Items[sel];
            listBox_system.Items.RemoveAt(sel);
            listBox_user.Items.Add(removed);

            Update_existence_state();
        }

       

    }
}
