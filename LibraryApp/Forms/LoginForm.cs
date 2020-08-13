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
using System.Text.RegularExpressions;

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
            const string pattern = @"[A-Z0-9._%-]+@[A-Z0-9._%-]+\.[A-Z]{2,4}";
            if (!Regex.IsMatch(TxtUsername.Text.ToUpper(), pattern))
            {
                LblUnderUsername.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adını düzgün yazın. Misal: code.academy@gmail.com");
                return;
            }
            Manager manager = context.Managers.FirstOrDefault(m=>m.Username.ToUpper()==TxtUsername.Text.ToUpper());

            if (manager==null|| TxtPassword.Text != manager.Password)
            {
                LblUnderUsername.BackColor = Color.Maroon;
                LblUnderPassword.BackColor = Color.Maroon;
                MessageBox.Show("Istifadəçi adı və ya parol yanlışdır. Yenidən yoxlayın.");
                return;
            }

            this.Hide();
            MeanForm meanForm = new MeanForm();
            meanForm.Show();


        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}