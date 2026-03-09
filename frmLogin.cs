using System;
using System.Windows.Forms;
namespace WinFormsApp
{
    public partial class frmLogin : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        public frmLogin()
        {
            InitializeComponent();
            db.InitializeDatabase();
            textBox2.PasswordChar = '*';
        }
        // Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.Login(username, password))
            {
                MessageBox.Show("Login erfolgreich! Willkommen " + username, "Erfolg",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falscher Benutzername oder Passwort!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Clear Button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        // Show Password Checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
        // Create Account Label
        private void label2_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
    }
}