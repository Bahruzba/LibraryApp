using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.Models;
using LibraryApp.DAL;

namespace LibraryApp.Forms
{
    public partial class LoginForm : Form
    {
        private LibraryAppContext context;
        public LoginForm()
        {
            context = new LibraryAppContext();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Manager> Manager = context.Managers.Where(m => m.Username == TxtUsername.Text).ToList();
            LblUnderUsername.BackColor = Color.Orange;
            LblUnderPassword.BackColor = Color.Orange;
            if (TxtUsername.Text == "" || TxtPassword.Text == "")
            {
                if (TxtUsername.Text == "")
                {
                    LblUnderUsername.BackColor = Color.Maroon;
                }
                if (TxtPassword.Text == "")
                {
                    LblUnderPassword.BackColor = Color.Maroon;
                }
                    MessageBox.Show("Xanaları doldurun.");
                    return;
            }
            else if (!TxtUsername.Text.Contains("@"))
            {
                LblUnderUsername.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adındı düzgün yazın. Misal: code.academy@gmail.com");
                return;
            }
            else if (!TxtUsername.Text.Substring(TxtUsername.Text.LastIndexOf('@') + 1).Contains(".") || TxtUsername.Text.EndsWith("."))
            {
                LblUnderUsername.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adındı düzgün yazın. Misal: code.academy@gmail.com");
                return;
            }
            else if (Manager.Count == 0)
            {
                LblUnderUsername.BackColor = Color.Maroon;
                MessageBox.Show("Istifadəçi adı yanlışdır. Yenidən yoxlayın.");
                return;
            }
            else if (Manager.Count == 1)
            {
                string password = "";
                foreach (Manager manager in Manager)
                {
                    password = manager.Password;
                }
                if (TxtPassword.Text != password)
                {
                    LblUnderPassword.BackColor = Color.Maroon;
                    MessageBox.Show("Parol düzgün deyil. Yenidən cəhd edin.");
                    return;
                }
                else
                {
                    if (TxtUsername.Text.ToUpper() == "YOLCHU@CODE.EDU.AZ")
                    {
                        DialogResult r = MessageBox.Show("Maa 100 bal verəjəhsizsə girə bilərsiz", "Axırıncı variant", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {

                        }
                        else{
                            MessageBox.Show("Özünüz bilərsiz...");
                            return;
                        } 
                    }
                    this.Hide();
                    MeanForm meanForm = new MeanForm();
                    meanForm.Show();
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}