namespace WinFormsApp
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(74, 404);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 23;
            label6.Text = "Create Account";
            label6.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 64, 64);
            label5.Location = new Point(56, 387);
            label5.Name = "label5";
            label5.Size = new Size(159, 19);
            label5.TabIndex = 22;
            label5.Text = "Don't have an Account";
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(10, 323);
            button2.Name = "button2";
            button2.Size = new Size(228, 34);
            button2.TabIndex = 21;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(10, 272);
            button1.Name = "button1";
            button1.Size = new Size(228, 37);
            button1.TabIndex = 20;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Times New Roman", 12F);
            checkBox1.ForeColor = Color.DarkRed;
            checkBox1.Location = new Point(115, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 23);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LavenderBlush;
            textBox2.Location = new Point(10, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(10, 143);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.Location = new Point(10, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(10, 82);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(249, 480);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}