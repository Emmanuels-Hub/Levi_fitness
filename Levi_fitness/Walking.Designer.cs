﻿namespace Levi_fitness
{
    partial class Walking
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
            calculate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            getTime = new TextBox();
            getStep = new TextBox();
            getDis = new TextBox();
            goHome = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(165, 29);
            label1.Name = "label1";
            label1.Size = new Size(469, 39);
            label1.TabIndex = 1;
            label1.Text = "Calculate Your Calory burns.";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 106);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 11;
            label2.Text = "Steps taken";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 49);
            label3.Name = "label3";
            label3.Size = new Size(105, 22);
            label3.TabIndex = 12;
            label3.Text = "Distance(m)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 156);
            label4.Name = "label4";
            label4.Size = new Size(71, 22);
            label4.TabIndex = 13;
            label4.Text = "Time(s)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(getTime);
            groupBox1.Controls.Add(getStep);
            groupBox1.Controls.Add(getDis);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(calculate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(184, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 279);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Walking";
            // 
            // getTime
            // 
            getTime.Location = new Point(207, 149);
            getTime.Name = "getTime";
            getTime.Size = new Size(150, 29);
            getTime.TabIndex = 16;
            // 
            // getStep
            // 
            getStep.Location = new Point(207, 99);
            getStep.Name = "getStep";
            getStep.Size = new Size(150, 29);
            getStep.TabIndex = 15;
            // 
            // getDis
            // 
            getDis.Location = new Point(207, 46);
            getDis.Name = "getDis";
            getDis.Size = new Size(150, 29);
            getDis.TabIndex = 14;
            // 
            // goHome
            // 
            goHome.BackColor = Color.Maroon;
            goHome.FlatStyle = FlatStyle.Flat;
            goHome.ForeColor = Color.White;
            goHome.Location = new Point(28, 29);
            goHome.Name = "goHome";
            goHome.Size = new Size(84, 37);
            goHome.TabIndex = 17;
            goHome.Text = "back";
            goHome.UseVisualStyleBackColor = false;
            goHome.Click += goHome_Click;
            // 
            // Walking
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(goHome);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Walking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Walking";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button calculate;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox getTime;
        private TextBox getStep;
        private TextBox getDis;
        private Button goHome;
    }
}