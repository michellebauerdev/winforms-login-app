namespace WinFormsApp
{
    partial class frmRegister
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(10, 67);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.Location = new Point(10, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(10, 123);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LavenderBlush;
            textBox2.Location = new Point(10, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(10, 178);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LavenderBlush;
            textBox3.Location = new Point(10, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 23);
            textBox3.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Times New Roman", 12F);
            checkBox1.ForeColor = Color.DarkRed;
            checkBox1.Location = new Point(113, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 23);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(10, 285);
            button1.Name = "button1";
            button1.Size = new Size(227, 37);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(10, 335);
            button2.Name = "button2";
            button2.Size = new Size(227, 34);
            button2.TabIndex = 9;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 64, 64);
            label5.Location = new Point(46, 395);
            label5.Name = "label5";
            label5.Size = new Size(175, 19);
            label5.TabIndex = 10;
            label5.Text = "Already have an Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(75, 412);
            label6.Name = "label6";
            label6.Size = new Size(103, 19);
            label6.TabIndex = 11;
            label6.Text = "Back to Login";
            label6.Click += label6_Click;
            // 
            // frmRegister
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
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}