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
using System.IO;

namespace UserLogin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string foldername = @"c:\LoginApp";
            string PathString1 = Path.Combine(foldername, "UsernamePswd");
            string FileN = "UserName.txt";
            PathString1 = Path.Combine(PathString1, FileN);

            string PathString2 = Path.Combine(foldername, "UsernamePswd");
            string FileP = "Password.txt";
            PathString2 = Path.Combine(PathString2, FileP);



            string a = File.ReadAllText(PathString1);//gets what is in UserNames.txt
            string b = File.ReadAllText(PathString2);//gets what is in Pswds.txt


            if (String.Equals(textBox1.Text, "") || String.Equals(textBox2.Text, "") || a.Contains(textBox1.Text) || b.Contains(textBox2.Text))
            {
                MessageBox.Show("Please type in a vaid password");//if user didn't type anything
            }
            else
            {
                string NewN = File.ReadAllText(PathString1) + textBox1.Text;
                string NewP = File.ReadAllText(PathString2) + textBox2.Text;

                File.WriteAllText(PathString1, NewN);
                File.WriteAllText(PathString2, NewP);
                this.Close();
            }
        }
    }
}
