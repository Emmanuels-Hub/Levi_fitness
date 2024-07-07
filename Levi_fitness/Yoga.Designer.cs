namespace Levi_fitness
{
    partial class Yoga
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
            levelInt = new NumericUpDown();
            getPose = new TextBox();
            getDur = new TextBox();
            calculate = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)levelInt).BeginInit();
            SuspendLayout();
            // 
            // goHome
            // 
            goHome.BackColor = Color.Maroon;
            goHome.FlatStyle = FlatStyle.Flat;
            goHome.ForeColor = Color.White;
            goHome.Location = new Point(39, 27);
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
            label1.Location = new Point(176, 27);
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
            label3.Size = new Size(77, 22);
            label3.TabIndex = 12;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 156);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 13;
            label4.Text = "Pose Count";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 106);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 11;
            label2.Text = "Intensity";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(levelInt);
            groupBox1.Controls.Add(getPose);
            groupBox1.Controls.Add(getDur);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(calculate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(195, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 279);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yoga";
            // 
            // levelInt
            // 
            levelInt.Location = new Point(207, 106);
            levelInt.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            levelInt.Name = "levelInt";
            levelInt.Size = new Size(150, 29);
            levelInt.TabIndex = 17;
            // 
            // getPose
            // 
            getPose.Location = new Point(207, 149);
            getPose.Name = "getPose";
            getPose.Size = new Size(150, 29);
            getPose.TabIndex = 16;
            // 
            // getDur
            // 
            getDur.Location = new Point(207, 46);
            getDur.Name = "getDur";
            getDur.Size = new Size(150, 29);
            getDur.TabIndex = 14;
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
            // Yoga
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(goHome);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Yoga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yoga";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)levelInt).EndInit();
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
        private TextBox getPose;
        private TextBox getDur;
        private Button calculate;
        private NumericUpDown levelInt;
    }
}