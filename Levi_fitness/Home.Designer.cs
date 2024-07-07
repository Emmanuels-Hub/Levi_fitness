namespace Levi_fitness
{
    partial class Home
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
            label1 = new Label();
            walkPage = new Button();
            runPage = new Button();
            yogaPage = new Button();
            swimPage = new Button();
            cycPage = new Button();
            stgPage = new Button();
            calData = new Label();
            label3 = new Label();
            setCal = new Button();
            getCal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(152, 23);
            label1.Name = "label1";
            label1.Size = new Size(469, 39);
            label1.TabIndex = 0;
            label1.Text = "Calculate Your Calory burns.";
            // 
            // walkPage
            // 
            walkPage.BackColor = Color.Maroon;
            walkPage.FlatStyle = FlatStyle.Flat;
            walkPage.ForeColor = Color.White;
            walkPage.Location = new Point(176, 102);
            walkPage.Name = "walkPage";
            walkPage.Size = new Size(177, 50);
            walkPage.TabIndex = 1;
            walkPage.Text = "Walking";
            walkPage.UseVisualStyleBackColor = false;
            walkPage.Click += walkPage_Click;
            // 
            // runPage
            // 
            runPage.BackColor = Color.Maroon;
            runPage.FlatStyle = FlatStyle.Flat;
            runPage.ForeColor = Color.White;
            runPage.Location = new Point(176, 175);
            runPage.Name = "runPage";
            runPage.Size = new Size(112, 47);
            runPage.TabIndex = 2;
            runPage.Text = "Running";
            runPage.UseVisualStyleBackColor = false;
            runPage.Click += runPage_Click;
            // 
            // yogaPage
            // 
            yogaPage.BackColor = Color.Maroon;
            yogaPage.FlatStyle = FlatStyle.Flat;
            yogaPage.ForeColor = Color.White;
            yogaPage.Location = new Point(176, 251);
            yogaPage.Name = "yogaPage";
            yogaPage.Size = new Size(177, 44);
            yogaPage.TabIndex = 3;
            yogaPage.Text = "Yoga Exercise";
            yogaPage.UseVisualStyleBackColor = false;
            yogaPage.Click += yogaPage_Click;
            // 
            // swimPage
            // 
            swimPage.BackColor = Color.Maroon;
            swimPage.FlatStyle = FlatStyle.Flat;
            swimPage.ForeColor = Color.White;
            swimPage.Location = new Point(435, 102);
            swimPage.Name = "swimPage";
            swimPage.Size = new Size(172, 50);
            swimPage.TabIndex = 4;
            swimPage.Text = "Swimming";
            swimPage.UseVisualStyleBackColor = false;
            swimPage.Click += swimPage_Click;
            // 
            // cycPage
            // 
            cycPage.BackColor = Color.Maroon;
            cycPage.FlatStyle = FlatStyle.Flat;
            cycPage.ForeColor = Color.White;
            cycPage.Location = new Point(495, 175);
            cycPage.Name = "cycPage";
            cycPage.Size = new Size(112, 47);
            cycPage.TabIndex = 5;
            cycPage.Text = "Cycling";
            cycPage.UseVisualStyleBackColor = false;
            cycPage.Click += cycPage_Click;
            // 
            // stgPage
            // 
            stgPage.BackColor = Color.Maroon;
            stgPage.FlatStyle = FlatStyle.Flat;
            stgPage.ForeColor = Color.White;
            stgPage.Location = new Point(435, 251);
            stgPage.Name = "stgPage";
            stgPage.Size = new Size(172, 44);
            stgPage.TabIndex = 6;
            stgPage.Text = "Strenght Trainng";
            stgPage.UseVisualStyleBackColor = false;
            stgPage.Click += stgPage_Click;
            // 
            // calData
            // 
            calData.AutoSize = true;
            calData.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calData.Location = new Point(358, 183);
            calData.Name = "calData";
            calData.Size = new Size(37, 39);
            calData.TabIndex = 7;
            calData.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 346);
            label3.Name = "label3";
            label3.Size = new Size(173, 22);
            label3.TabIndex = 8;
            label3.Text = "Set your calory limit:";
            // 
            // setCal
            // 
            setCal.BackColor = Color.Maroon;
            setCal.FlatStyle = FlatStyle.Flat;
            setCal.ForeColor = Color.White;
            setCal.Location = new Point(511, 335);
            setCal.Name = "setCal";
            setCal.Size = new Size(68, 37);
            setCal.TabIndex = 9;
            setCal.Text = "set";
            setCal.UseVisualStyleBackColor = false;
            setCal.Click += setCal_Click;
            // 
            // getCal
            // 
            getCal.Location = new Point(387, 343);
            getCal.Name = "getCal";
            getCal.Size = new Size(118, 29);
            getCal.TabIndex = 10;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(getCal);
            Controls.Add(setCal);
            Controls.Add(label3);
            Controls.Add(calData);
            Controls.Add(stgPage);
            Controls.Add(cycPage);
            Controls.Add(swimPage);
            Controls.Add(yogaPage);
            Controls.Add(runPage);
            Controls.Add(walkPage);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button walkPage;
        private Button runPage;
        private Button yogaPage;
        private Button swimPage;
        private Button cycPage;
        private Button stgPage;
        private Label calData;
        private Label label3;
        private Button setCal;
        private TextBox getCal;
    }
}