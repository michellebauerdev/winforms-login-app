using System;
using System.Windows.Forms;
namespace WinFormsApp
{
    public partial class frmRegister : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        public frmRegister()
        {
            InitializeComponent();
            db.InitializeDatabase();
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Passwort muss mindestens 6 Zeichen haben!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwörter stimmen nicht überein!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool success = db.Register(username, password, "");
            if (success)
            {
                MessageBox.Show("Registrierung erfolgreich!", "Erfolg",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();  // ← Close → Hide
            }
            else
            {
                MessageBox.Show("Benutzername bereits vergeben!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
        private void label6_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}