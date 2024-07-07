namespace Levi_fitness
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            loginPage = new Button();
            getlogpass = new TextBox();
            getloguser = new TextBox();
            label4 = new Label();
            label3 = new Label();
            loginBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 282);
            label6.Name = "label6";
            label6.Size = new Size(198, 22);
            label6.TabIndex = 21;
            label6.Text = "Don't have an Account?";
            // 
            // loginPage
            // 
            loginPage.BackColor = Color.Maroon;
            loginPage.FlatStyle = FlatStyle.Flat;
            loginPage.ForeColor = Color.White;
            loginPage.Location = new Point(310, 314);
            loginPage.Name = "loginPage";
            loginPage.Size = new Size(204, 34);
            loginPage.TabIndex = 20;
            loginPage.Text = "Create an Account";
            loginPage.UseVisualStyleBackColor = false;
            loginPage.Click += loginPage_Click;
            // 
            // getlogpass
            // 
            getlogpass.Location = new Point(287, 177);
            getlogpass.Name = "getlogpass";
            getlogpass.PasswordChar = '*';
            getlogpass.Size = new Size(240, 29);
            getlogpass.TabIndex = 18;
            // 
            // getloguser
            // 
            getloguser.Location = new Point(287, 137);
            getloguser.Name = "getloguser";
            getloguser.Size = new Size(240, 29);
            getloguser.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 177);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 15;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 137);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 14;
            label3.Text = "Username:";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Maroon;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(287, 233);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(240, 30);
            loginBtn.TabIndex = 13;
            loginBtn.Text = "Submit";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 79);
            label2.Name = "label2";
            label2.Size = new Size(167, 22);
            label2.TabIndex = 12;
            label2.Text = "Sign in and explore.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(201, 27);
            label1.Name = "label1";
            label1.Size = new Size(405, 39);
            label1.TabIndex = 11;
            label1.Text = "Welcome to Levi Fitness";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(label6);
            Controls.Add(loginPage);
            Controls.Add(getlogpass);
            Controls.Add(getloguser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button loginPage;
        private TextBox getlogpass;
        private TextBox getloguser;
        private Label label4;
        private Label label3;
        private Button loginBtn;
        private Label label2;
        private Label label1;
    }
}