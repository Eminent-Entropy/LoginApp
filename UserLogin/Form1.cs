using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLogin.Properties;
using System.Resources;
using System.Reflection;
using System.IO;

namespace UserLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserN = textBox1.Text; //what user put in username textbox
            string UserP = textBox2.Text; //what user put in password textbox

            try
            {
                string foldername = @"c:\LoginApp";
                string PathString1 = Path.Combine(foldername, "UsernamePswd");
                string FileN = "UserName.txt";
                PathString1 = Path.Combine(PathString1, FileN);

                string PathString2 = Path.Combine(foldername, "UsernamePswd");
                string FileP = "Password.txt";
                PathString2 = Path.Combine(PathString2, FileP);


                if (Convert.ToString(File.ReadAllText(PathString1)).Contains(UserN) && Convert.ToString(File.ReadAllText(PathString2)).Contains(UserP)) //checks if user typed in correct username and password
                {
                    Form2 form2 = new UserLogin.Form2();
                    form2.Show(); //opens form2
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");//if incorrect username or password
                }
            }
            catch
            {
                MessageBox.Show("Error reading files");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new UserLogin.Form3();
            form3.Show();//opens form3
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string foldername = @"c:\LoginApp";
            string PathString1 = Path.Combine(foldername, "UsernamePswd");
            Directory.CreateDirectory(PathString1);
            string FileN = "UserName.txt";
            PathString1 = Path.Combine(PathString1, FileN);
            File.Create(PathString1);

            string PathString2 = Path.Combine(foldername, "UsernamePswd");
            string FileP = "Password.txt";
            PathString2 = Path.Combine(PathString2, FileP);
            File.Create(PathString2);
        }
    }
}
