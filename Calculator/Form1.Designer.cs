namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Btn_AC = new System.Windows.Forms.Button();
            this.Btn_C = new System.Windows.Forms.Button();
            this.Btn_square = new System.Windows.Forms.Button();
            this.Btn_divide = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_multiply = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_minus = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_plus = new System.Windows.Forms.Button();
            this.Btn_modulus = new System.Windows.Forms.Button();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.Btn_dot = new System.Windows.Forms.Button();
            this.Btn_equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(36, 53);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox.Size = new System.Drawing.Size(318, 37);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_AC
            // 
            this.Btn_AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_AC.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AC.ForeColor = System.Drawing.Color.White;
            this.Btn_AC.Location = new System.Drawing.Point(16, 148);
            this.Btn_AC.Name = "Btn_AC";
            this.Btn_AC.Size = new System.Drawing.Size(85, 37);
            this.Btn_AC.TabIndex = 2;
            this.Btn_AC.Text = "AC";
            this.Btn_AC.UseVisualStyleBackColor = false;
            this.Btn_AC.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Btn_C
            // 
            this.Btn_C.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_C.Location = new System.Drawing.Point(107, 148);
            this.Btn_C.Name = "Btn_C";
            this.Btn_C.Size = new System.Drawing.Size(85, 37);
            this.Btn_C.TabIndex = 2;
            this.Btn_C.Text = "C";
            this.Btn_C.UseVisualStyleBackColor = true;
            this.Btn_C.Click += new System.EventHandler(this.Btn_C_Click);
            // 
            // Btn_square
            // 
            this.Btn_square.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_square.Location = new System.Drawing.Point(198, 148);
            this.Btn_square.Name = "Btn_square";
            this.Btn_square.Size = new System.Drawing.Size(85, 37);
            this.Btn_square.TabIndex = 2;
            this.Btn_square.Text = "x²";
            this.Btn_square.UseVisualStyleBackColor = true;
            this.Btn_square.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Btn_divide
            // 
            this.Btn_divide.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_divide.Location = new System.Drawing.Point(289, 148);
            this.Btn_divide.Name = "Btn_divide";
            this.Btn_divide.Size = new System.Drawing.Size(85, 37);
            this.Btn_divide.TabIndex = 2;
            this.Btn_divide.Text = "÷";
            this.Btn_divide.UseVisualStyleBackColor = true;
            this.Btn_divide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_7.Location = new System.Drawing.Point(16, 205);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(85, 37);
            this.Btn_7.TabIndex = 2;
            this.Btn_7.Text = "7";
            this.Btn_7.UseVisualStyleBackColor = true;
            this.Btn_7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_8.Location = new System.Drawing.Point(107, 205);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(85, 37);
            this.Btn_8.TabIndex = 2;
            this.Btn_8.Text = "8";
            this.Btn_8.UseVisualStyleBackColor = true;
            this.Btn_8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_9
            // 
            this.Btn_9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_9.Location = new System.Drawing.Point(198, 205);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(85, 37);
            this.Btn_9.TabIndex = 2;
            this.Btn_9.Text = "9";
            this.Btn_9.UseVisualStyleBackColor = true;
            this.Btn_9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_multiply
            // 
            this.Btn_multiply.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_multiply.Location = new System.Drawing.Point(289, 205);
            this.Btn_multiply.Name = "Btn_multiply";
            this.Btn_multiply.Size = new System.Drawing.Size(85, 37);
            this.Btn_multiply.TabIndex = 2;
            this.Btn_multiply.Text = "x";
            this.Btn_multiply.UseVisualStyleBackColor = true;
            this.Btn_multiply.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_4.Location = new System.Drawing.Point(16, 261);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(85, 37);
            this.Btn_4.TabIndex = 2;
            this.Btn_4.Text = "4";
            this.Btn_4.UseVisualStyleBackColor = true;
            this.Btn_4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_5.Location = new System.Drawing.Point(107, 261);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(85, 37);
            this.Btn_5.TabIndex = 2;
            this.Btn_5.Text = "5";
            this.Btn_5.UseVisualStyleBackColor = true;
            this.Btn_5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_6.Location = new System.Drawing.Point(198, 261);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(85, 37);
            this.Btn_6.TabIndex = 2;
            this.Btn_6.Text = "6";
            this.Btn_6.UseVisualStyleBackColor = true;
            this.Btn_6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_minus
            // 
            this.Btn_minus.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_minus.Location = new System.Drawing.Point(289, 261);
            this.Btn_minus.Name = "Btn_minus";
            this.Btn_minus.Size = new System.Drawing.Size(85, 37);
            this.Btn_minus.TabIndex = 2;
            this.Btn_minus.Text = "-";
            this.Btn_minus.UseVisualStyleBackColor = true;
            this.Btn_minus.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_1.Location = new System.Drawing.Point(16, 316);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(85, 37);
            this.Btn_1.TabIndex = 2;
            this.Btn_1.Text = "1";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_2.Location = new System.Drawing.Point(107, 316);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(85, 37);
            this.Btn_2.TabIndex = 2;
            this.Btn_2.Text = "2";
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_3.Location = new System.Drawing.Point(198, 316);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(85, 37);
            this.Btn_3.TabIndex = 2;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_plus
            // 
            this.Btn_plus.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_plus.Location = new System.Drawing.Point(289, 316);
            this.Btn_plus.Name = "Btn_plus";
            this.Btn_plus.Size = new System.Drawing.Size(85, 37);
            this.Btn_plus.TabIndex = 2;
            this.Btn_plus.Text = "+";
            this.Btn_plus.UseVisualStyleBackColor = true;
            this.Btn_plus.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Btn_modulus
            // 
            this.Btn_modulus.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modulus.Location = new System.Drawing.Point(16, 370);
            this.Btn_modulus.Name = "Btn_modulus";
            this.Btn_modulus.Size = new System.Drawing.Size(85, 37);
            this.Btn_modulus.TabIndex = 2;
            this.Btn_modulus.Text = "%";
            this.Btn_modulus.UseVisualStyleBackColor = true;
            this.Btn_modulus.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Btn_0
            // 
            this.Btn_0.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_0.Location = new System.Drawing.Point(107, 370);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(85, 37);
            this.Btn_0.TabIndex = 2;
            this.Btn_0.Text = "0";
            this.Btn_0.UseVisualStyleBackColor = true;
            this.Btn_0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Btn_dot
            // 
            this.Btn_dot.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dot.Location = new System.Drawing.Point(198, 370);
            this.Btn_dot.Name = "Btn_dot";
            this.Btn_dot.Size = new System.Drawing.Size(85, 37);
            this.Btn_dot.TabIndex = 2;
            this.Btn_dot.Text = ".";
            this.Btn_dot.UseVisualStyleBackColor = true;
            this.Btn_dot.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // Btn_equal
            // 
            this.Btn_equal.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_equal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equal.ForeColor = System.Drawing.Color.White;
            this.Btn_equal.Location = new System.Drawing.Point(289, 370);
            this.Btn_equal.Name = "Btn_equal";
            this.Btn_equal.Size = new System.Drawing.Size(85, 37);
            this.Btn_equal.TabIndex = 2;
            this.Btn_equal.Text = "=";
            this.Btn_equal.UseVisualStyleBackColor = false;
            this.Btn_equal.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 457);
            this.Controls.Add(this.Btn_equal);
            this.Controls.Add(this.Btn_plus);
            this.Controls.Add(this.Btn_minus);
            this.Controls.Add(this.Btn_multiply);
            this.Controls.Add(this.Btn_divide);
            this.Controls.Add(this.Btn_dot);
            this.Controls.Add(this.Btn_3);
            this.Controls.Add(this.Btn_6);
            this.Controls.Add(this.Btn_9);
            this.Controls.Add(this.Btn_square);
            this.Controls.Add(this.Btn_0);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.Btn_5);
            this.Controls.Add(this.Btn_8);
            this.Controls.Add(this.Btn_C);
            this.Controls.Add(this.Btn_modulus);
            this.Controls.Add(this.Btn_1);
            this.Controls.Add(this.Btn_4);
            this.Controls.Add(this.Btn_7);
            this.Controls.Add(this.Btn_AC);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(406, 496);
            this.MinimumSize = new System.Drawing.Size(406, 496);
            this.Name = "Form1";
            this.Text = "Calculator by Zain Ashraf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Btn_AC;
        private System.Windows.Forms.Button Btn_C;
        private System.Windows.Forms.Button Btn_square;
        private System.Windows.Forms.Button Btn_divide;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_multiply;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_minus;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_plus;
        private System.Windows.Forms.Button Btn_modulus;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.Button Btn_dot;
        private System.Windows.Forms.Button Btn_equal;
    }
}

