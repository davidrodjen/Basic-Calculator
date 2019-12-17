namespace Basic_Calculator
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
            this.opOne = new System.Windows.Forms.TextBox();
            this.opBox = new System.Windows.Forms.TextBox();
            this.opTwo = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.calcResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opOne
            // 
            this.opOne.Location = new System.Drawing.Point(123, 23);
            this.opOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opOne.Name = "opOne";
            this.opOne.Size = new System.Drawing.Size(132, 22);
            this.opOne.TabIndex = 0;
            this.opOne.TextChanged += new System.EventHandler(this.opOne_TextChanged);
            // 
            // opBox
            // 
            this.opBox.Location = new System.Drawing.Point(123, 57);
            this.opBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(43, 22);
            this.opBox.TabIndex = 1;
            this.opBox.TextChanged += new System.EventHandler(this.opOne_TextChanged);
            // 
            // opTwo
            // 
            this.opTwo.Location = new System.Drawing.Point(123, 90);
            this.opTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opTwo.Name = "opTwo";
            this.opTwo.Size = new System.Drawing.Size(132, 22);
            this.opTwo.TabIndex = 2;
            this.opTwo.TextChanged += new System.EventHandler(this.opOne_TextChanged);
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(123, 123);
            this.result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(132, 22);
            this.result.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operand 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operand 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result:";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(155, 156);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 28);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // calcResult
            // 
            this.calcResult.Location = new System.Drawing.Point(29, 156);
            this.calcResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcResult.Name = "calcResult";
            this.calcResult.Size = new System.Drawing.Size(100, 28);
            this.calcResult.TabIndex = 9;
            this.calcResult.Text = "Calculate";
            this.calcResult.UseVisualStyleBackColor = true;
            this.calcResult.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(323, 248);
            this.Controls.Add(this.calcResult);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.opTwo);
            this.Controls.Add(this.opBox);
            this.Controls.Add(this.opOne);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox opOne;
        private System.Windows.Forms.TextBox opBox;
        private System.Windows.Forms.TextBox opTwo;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button calcResult;
    }
}

