namespace Levi_fitness
{
    partial class Strenght
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
            goHome = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            getMass = new TextBox();
            getSer = new TextBox();
            getRep = new TextBox();
            calculate = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // goHome
            // 
            goHome.BackColor = Color.Maroon;
            goHome.FlatStyle = FlatStyle.Flat;
            goHome.ForeColor = Color.White;
            goHome.Location = new Point(43, 27);
            goHome.Name = "goHome";
            goHome.Size = new Size(84, 37);
            goHome.TabIndex = 20;
            goHome.Text = "back";
            goHome.UseVisualStyleBackColor = false;
            goHome.Click += goHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(180, 27);
            label1.Name = "label1";
            label1.Size = new Size(469, 39);
            label1.TabIndex = 18;
            label1.Text = "Calculate Your Calory burns.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 49);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 12;
            label3.Text = "Repetition";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 156);
            label4.Name = "label4";
            label4.Size = new Size(49, 22);
            label4.TabIndex = 13;
            label4.Text = "Mass";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 106);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 11;
            label2.Text = "Series";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(getMass);
            groupBox1.Controls.Add(getSer);
            groupBox1.Controls.Add(getRep);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(calculate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(199, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 279);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Strenght Training";
            // 
            // getMass
            // 
            getMass.Location = new Point(207, 149);
            getMass.Name = "getMass";
            getMass.Size = new Size(150, 29);
            getMass.TabIndex = 16;
            // 
            // getSer
            // 
            getSer.Location = new Point(207, 99);
            getSer.Name = "getSer";
            getSer.Size = new Size(150, 29);
            getSer.TabIndex = 15;
            // 
            // getRep
            // 
            getRep.Location = new Point(207, 46);
            getRep.Name = "getRep";
            getRep.Size = new Size(150, 29);
            getRep.TabIndex = 14;
            // 
            // calculate
            // 
            calculate.BackColor = Color.Maroon;
            calculate.FlatStyle = FlatStyle.Flat;
            calculate.ForeColor = Color.White;
            calculate.Location = new Point(207, 198);
            calculate.Name = "calculate";
            calculate.Size = new Size(150, 37);
            calculate.TabIndex = 10;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
            // 
            // Strenght
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(goHome);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Strenght";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Strenght";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goHome;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox getMass;
        private TextBox getSer;
        private TextBox getRep;
        private Button calculate;
    }
}