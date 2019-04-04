namespace GeomLibUi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.Z1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Z2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalDist = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Point B";
            // 
            // X1
            // 
            this.X1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.X1.Location = new System.Drawing.Point(97, 59);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(38, 22);
            this.X1.TabIndex = 2;
            this.X1.Text = "0.0";
            this.X1.TextChanged += new System.EventHandler(this.DistanceCalculationX1Changed);
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(141, 59);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(38, 22);
            this.Y1.TabIndex = 3;
            this.Y1.Text = "0.0";
            this.Y1.TextChanged += new System.EventHandler(this.DistanceCalculationY1Changed);
            // 
            // Z1
            // 
            this.Z1.Location = new System.Drawing.Point(185, 59);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(38, 22);
            this.Z1.TabIndex = 4;
            this.Z1.Text = "0.0";
            this.Z1.TextChanged += new System.EventHandler(this.DistanceCalculationZ1Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "x";
            // 
            // Z2
            // 
            this.Z2.Location = new System.Drawing.Point(185, 119);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(38, 22);
            this.Z2.TabIndex = 13;
            this.Z2.Text = "0.0";
            this.Z2.TextChanged += new System.EventHandler(this.DistanceCalculationZ2Changed);
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(141, 119);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(38, 22);
            this.Y2.TabIndex = 12;
            this.Y2.Text = "0.0";
            this.Y2.TextChanged += new System.EventHandler(this.DistanceCalculationY2Changed);
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(97, 119);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(38, 22);
            this.X2.TabIndex = 11;
            this.X2.Text = "0.0";
            this.X2.TextChanged += new System.EventHandler(this.DistanceCalculationX2Changed);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalDist);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.X1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Y1);
            this.panel1.Controls.Add(this.Z2);
            this.panel1.Controls.Add(this.Z1);
            this.panel1.Controls.Add(this.Y2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.X2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 212);
            this.panel1.TabIndex = 17;
            // 
            // totalDist
            // 
            this.totalDist.Location = new System.Drawing.Point(97, 174);
            this.totalDist.Name = "totalDist";
            this.totalDist.Size = new System.Drawing.Size(126, 22);
            this.totalDist.TabIndex = 19;
            this.totalDist.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Distance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Distance Between Points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 387);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox Z1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Z2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalDist;
        private System.Windows.Forms.Label label10;
    }
}

