using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Supermercado
{
    public partial class Tela_login : Form
    {
        public Tela_login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            String User = "cesar";
            String Password = "teste";

            if (UserLogin.Text == User & PasswordLogin.Text == Password)
            {
                Form1 FormMain = new Form1();
                FormMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha errados.");
            }
        }

        private void UserLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
