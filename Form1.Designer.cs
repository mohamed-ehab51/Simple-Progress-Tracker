namespace Progress_Tracker
{
    partial class Form1
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
            circularProgressBar1 = new CircularProgressBar();
            button1 = new Button();
            total = new TextBox();
            current = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.BackColor = SystemColors.Control;
            circularProgressBar1.BarColor1 = Color.Orange;
            circularProgressBar1.BarColor2 = Color.Orange;
            circularProgressBar1.BarWidth = 14F;
            circularProgressBar1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.DimGray;
            circularProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            circularProgressBar1.LineColor = Color.DimGray;
            circularProgressBar1.LineWidth = 1;
            circularProgressBar1.Location = new Point(238, 206);
            circularProgressBar1.Maximum = 100L;
            circularProgressBar1.MinimumSize = new Size(100, 100);
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.ProgressShape = CircularProgressBar._ProgressShape.Flat;
            circularProgressBar1.Size = new Size(311, 311);
            circularProgressBar1.TabIndex = 0;
            circularProgressBar1.Text = "57.00";
            circularProgressBar1.TextMode = CircularProgressBar._TextMode.Percentage;
            circularProgressBar1.Value = 57L;
            // 
            // button1
            // 
            button1.Location = new Point(347, 160);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Track";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // total
            // 
            total.Location = new Point(112, 71);
            total.Name = "total";
            total.Size = new Size(125, 27);
            total.TabIndex = 2;
            // 
            // current
            // 
            current.Location = new Point(524, 71);
            current.Name = "current";
            current.Size = new Size(125, 27);
            current.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 36);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 4;
            label1.Text = "The Goal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 36);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 5;
            label2.Text = "Current progress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 529);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(current);
            Controls.Add(total);
            Controls.Add(button1);
            Controls.Add(circularProgressBar1);
            Name = "Form1";
            Text = "Progress tracker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularProgressBar circularProgressBar1;
        private Button button1;
        private TextBox total;
        private TextBox current;
        private Label label1;
        private Label label2;
    }
}