namespace Levi_fitness
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            reisterBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            getuser = new TextBox();
            getpass = new TextBox();
            getcompass = new TextBox();
            loginPage = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(278, 23);
            label1.Name = "label1";
            label1.Size = new Size(210, 39);
            label1.TabIndex = 0;
            label1.Text = "Get Started.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 78);
            label2.Name = "label2";
            label2.Size = new Size(209, 22);
            label2.TabIndex = 1;
            label2.Text = "Create an account below.";
            // 
            // reisterBtn
            // 
            reisterBtn.BackColor = Color.Maroon;
            reisterBtn.FlatStyle = FlatStyle.Flat;
            reisterBtn.ForeColor = Color.White;
            reisterBtn.Location = new Point(349, 295);
            reisterBtn.Name = "reisterBtn";
            reisterBtn.Size = new Size(240, 34);
            reisterBtn.TabIndex = 2;
            reisterBtn.Text = "Submit";
            reisterBtn.UseVisualStyleBackColor = false;
            reisterBtn.Click += reisterBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 140);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 185);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 235);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 5;
            label5.Text = "Confirm Password:";
            // 
            // getuser
            // 
            getuser.Location = new Point(349, 140);
            getuser.Name = "getuser";
            getuser.Size = new Size(240, 29);
            getuser.TabIndex = 6;
            // 
            // getpass
            // 
            getpass.Location = new Point(349, 185);
            getpass.Name = "getpass";
            getpass.PasswordChar = '*';
            getpass.Size = new Size(240, 29);
            getpass.TabIndex = 7;
            // 
            // getcompass
            // 
            getcompass.Location = new Point(349, 235);
            getcompass.Name = "getcompass";
            getcompass.PasswordChar = '*';
            getcompass.Size = new Size(240, 29);
            getcompass.TabIndex = 8;
            // 
            // loginPage
            // 
            loginPage.BackColor = Color.Maroon;
            loginPage.FlatStyle = FlatStyle.Flat;
            loginPage.ForeColor = Color.White;
            loginPage.Location = new Point(501, 344);
            loginPage.Name = "loginPage";
            loginPage.Size = new Size(88, 34);
            loginPage.TabIndex = 9;
            loginPage.Text = "sign in";
            loginPage.UseVisualStyleBackColor = false;
            loginPage.Click += loginPage_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 350);
            label6.Name = "label6";
            label6.Size = new Size(133, 22);
            label6.TabIndex = 10;
            label6.Text = "Already a User?";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(label6);
            Controls.Add(loginPage);
            Controls.Add(getcompass);
            Controls.Add(getpass);
            Controls.Add(getuser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(reisterBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Desktop;
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button reisterBtn;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox getuser;
        private TextBox getpass;
        private TextBox getcompass;
        private Button loginPage;
        private Label label6;
    }
}
