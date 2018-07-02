namespace Calculator_Better_Design
{
    partial class CalculatorForm
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
            this.digit_7 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.decimal_point = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.digit_0 = new System.Windows.Forms.Button();
            this.digit_3 = new System.Windows.Forms.Button();
            this.digit_2 = new System.Windows.Forms.Button();
            this.digit_5 = new System.Windows.Forms.Button();
            this.digit_1 = new System.Windows.Forms.Button();
            this.digit_6 = new System.Windows.Forms.Button();
            this.digit_4 = new System.Windows.Forms.Button();
            this.mulitply = new System.Windows.Forms.Button();
            this.digit_9 = new System.Windows.Forms.Button();
            this.digit_8 = new System.Windows.Forms.Button();
            this.change_sign = new System.Windows.Forms.Button();
            this.square_root = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // digit_7
            // 
            this.digit_7.Location = new System.Drawing.Point(20, 96);
            this.digit_7.Name = "digit_7";
            this.digit_7.Size = new System.Drawing.Size(35, 28);
            this.digit_7.TabIndex = 1;
            this.digit_7.Tag = "7";
            this.digit_7.Text = "7";
            this.digit_7.UseVisualStyleBackColor = true;
            this.digit_7.Click += new System.EventHandler(this.Digit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(20, 62);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(157, 28);
            this.clear.TabIndex = 2;
            this.clear.Tag = "clear";
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Operation_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(142, 198);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(35, 28);
            this.add.TabIndex = 3;
            this.add.Tag = "+";
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Operation_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(141, 164);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(35, 28);
            this.subtract.TabIndex = 4;
            this.subtract.Tag = "-";
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.Operation_Click);
            // 
            // decimal_point
            // 
            this.decimal_point.Location = new System.Drawing.Point(101, 198);
            this.decimal_point.Name = "decimal_point";
            this.decimal_point.Size = new System.Drawing.Size(35, 28);
            this.decimal_point.TabIndex = 5;
            this.decimal_point.Tag = "decimal_point";
            this.decimal_point.Text = ".";
            this.decimal_point.UseVisualStyleBackColor = true;
            this.decimal_point.Click += new System.EventHandler(this.Operation_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(142, 96);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(35, 28);
            this.divide.TabIndex = 6;
            this.divide.Tag = "/";
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Operation_Click);
            // 
            // digit_0
            // 
            this.digit_0.Location = new System.Drawing.Point(19, 198);
            this.digit_0.Name = "digit_0";
            this.digit_0.Size = new System.Drawing.Size(75, 28);
            this.digit_0.TabIndex = 7;
            this.digit_0.Tag = "0";
            this.digit_0.Text = "0";
            this.digit_0.UseVisualStyleBackColor = true;
            this.digit_0.Click += new System.EventHandler(this.Digit_Click);
            // 
            // digit_3
            // 
            this.digit_3.Location = new System.Drawing.Point(101, 164);
            this.digit_3.Name = "digit_3";
            this.digit_3.Size = new System.Drawing.Size(35, 28);
            this.digit_3.TabIndex = 8;
            this.digit_3.Tag = "3";
            this.digit_3.Text = "3";
            this.digit_3.UseVisualStyleBackColor = true;
            this.digit_3.Click += new System.EventHandler(this.Digit_Click);
            // 
            // digit_2
            // 
            this.digit_2.Location = new System.Drawing.Point(60, 164);
            this.digit_2.Name = "digit_2";
            this.digit_2.Size = new System.Drawing.Size(35, 28);
            this.digit_2.TabIndex = 9;
            this.digit_2.Tag = "2";
            this.digit_2.Text = "2";
            this.digit_2.UseVisualStyleBackColor = true;
            this.digit_2.Click += new System.EventHandler(this.Digit_Click);
            // 
            // digit_5
            // 
            this.digit_5.Location = new System.Drawing.Point(59, 130);
            this.digit_5.Name = "digit_5";
            this.digit_5.Size = new System.Drawing.Size(35, 28);
            this.digit_5.TabIndex = 10;
            this.digit_5.Tag = "5";
            this.digit_5.Text = "5";
            this.digit_5.UseVisualStyleBackColor = true;
            this.digit_5.Click += new System.EventHandler(this.Digit_Click);
            // 
            // digit_1
            // 
            this.digit_1.Location = new System.Drawing.Point(19, 164);
            this.digit_1.Name = "digit_1";
            this.digit_1.Size = new System.Drawing.Size(35, 28);
            this.digit_1.TabIndex = 11;
            this.digit_1.Tag = "1";
            this.digit_1.Text = "1";
            this.digit_1.UseVisualStyleBackColor = true;
            this.digit_1.Click += new System.EventHandler(this.Digit_Click);
            // 
            // digit_6
            // 
            this.digit_6.Location = new System.Drawing.Point(101, 130);
            this.digit_6.Name = "digit_6";
            this.digit_6.Size = new System.Drawing.Size(35, 28);
            this.digit_6.TabIndex = 12;
            this.digit_6.Tag = "6";
            this.digit_6.Text = "6";
            this.digit_6.UseVisualStyleBackColor = true;
            this.digit_6.Click += new System.EventHandler(this.Digit_Click);
            // 
            // digit_4
            // 
            this.digit_4.Location = new System.Drawing.Point(20, 130);
            this.digit_4.Name = "digit_4";
            this.digit_4.Size = new System.Drawing.Size(35, 28);
            this.digit_4.TabIndex = 13;
            this.digit_4.Tag = "4";
            this.digit_4.Text = "4";
            this.digit_4.UseVisualStyleBackColor = true;
            this.digit_4.Click += new System.EventHandler(this.Digit_Click);
            // 
            // mulitply
            // 
            this.mulitply.Location = new System.Drawing.Point(141, 130);
            this.mulitply.Name = "mulitply";
            this.mulitply.Size = new System.Drawing.Size(35, 28);
            this.mulitply.TabIndex = 14;
            this.mulitply.Tag = "*";
            this.mulitply.Text = "*";
            this.mulitply.UseVisualStyleBackColor = true;
            this.mulitply.Click += new System.EventHandler(this.Operation_Click);
            // 
            // digit_9
            // 
            this.digit_9.Location = new System.Drawing.Point(101, 96);
            this.digit_9.Name = "digit_9";
            this.digit_9.Size = new System.Drawing.Size(35, 28);
            this.digit_9.TabIndex = 15;
            this.digit_9.Tag = "9";
            this.digit_9.Text = "9";
            this.digit_9.UseVisualStyleBackColor = true;
            this.digit_9.Click += new System.EventHandler(this.Digit_Click);
            // 
            // digit_8
            // 
            this.digit_8.Location = new System.Drawing.Point(59, 96);
            this.digit_8.Name = "digit_8";
            this.digit_8.Size = new System.Drawing.Size(35, 28);
            this.digit_8.TabIndex = 16;
            this.digit_8.Tag = "8";
            this.digit_8.Text = "8";
            this.digit_8.UseVisualStyleBackColor = true;
            this.digit_8.Click += new System.EventHandler(this.Digit_Click);
            // 
            // change_sign
            // 
            this.change_sign.Location = new System.Drawing.Point(183, 62);
            this.change_sign.Name = "change_sign";
            this.change_sign.Size = new System.Drawing.Size(35, 28);
            this.change_sign.TabIndex = 17;
            this.change_sign.Tag = "change_sign";
            this.change_sign.Text = "±";
            this.change_sign.UseVisualStyleBackColor = true;
            this.change_sign.Click += new System.EventHandler(this.Operation_Click);
            // 
            // square_root
            // 
            this.square_root.Location = new System.Drawing.Point(183, 96);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(35, 28);
            this.square_root.TabIndex = 18;
            this.square_root.Tag = "square_root";
            this.square_root.Text = "√";
            this.square_root.UseVisualStyleBackColor = true;
            this.square_root.Click += new System.EventHandler(this.Operation_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.Location = new System.Drawing.Point(182, 130);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(35, 28);
            this.reciprocal.TabIndex = 19;
            this.reciprocal.Tag = "reciprocal";
            this.reciprocal.Text = "1/x";
            this.reciprocal.UseVisualStyleBackColor = true;
            this.reciprocal.Click += new System.EventHandler(this.Operation_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(182, 164);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(35, 62);
            this.equals.TabIndex = 20;
            this.equals.Tag = "=";
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.Operation_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.Window;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(20, 9);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(196, 41);
            this.display.TabIndex = 21;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 240);
            this.Controls.Add(this.display);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.square_root);
            this.Controls.Add(this.change_sign);
            this.Controls.Add(this.digit_8);
            this.Controls.Add(this.digit_9);
            this.Controls.Add(this.mulitply);
            this.Controls.Add(this.digit_4);
            this.Controls.Add(this.digit_6);
            this.Controls.Add(this.digit_1);
            this.Controls.Add(this.digit_5);
            this.Controls.Add(this.digit_2);
            this.Controls.Add(this.digit_3);
            this.Controls.Add(this.digit_0);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.decimal_point);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.digit_7);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button digit_7;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button decimal_point;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button digit_0;
        private System.Windows.Forms.Button digit_3;
        private System.Windows.Forms.Button digit_2;
        private System.Windows.Forms.Button digit_5;
        private System.Windows.Forms.Button digit_1;
        private System.Windows.Forms.Button digit_6;
        private System.Windows.Forms.Button digit_4;
        private System.Windows.Forms.Button mulitply;
        private System.Windows.Forms.Button digit_9;
        private System.Windows.Forms.Button digit_8;
        private System.Windows.Forms.Button change_sign;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label display;
    }
}