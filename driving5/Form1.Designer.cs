namespace driving5
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
            this.button1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(86, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 17);
            this.button1.TabIndex = 1;
            this.button1.TabStop = true;
            this.button1.Text = "radioButton1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(422, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 17);
            this.button4.TabIndex = 2;
            this.button4.TabStop = true;
            this.button4.Text = "radioButton1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(422, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 17);
            this.button3.TabIndex = 3;
            this.button3.TabStop = true;
            this.button3.Text = "radioButton1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(86, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 17);
            this.button2.TabIndex = 4;
            this.button2.TabStop = true;
            this.button2.Text = "radioButton1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(452, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton button1;
        private System.Windows.Forms.RadioButton button4;
        private System.Windows.Forms.RadioButton button3;
        private System.Windows.Forms.RadioButton button2;
        private System.Windows.Forms.Button button5;
    }
}

