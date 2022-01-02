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
            this.button1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.RadioButton();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 44);
            this.button1.TabIndex = 0;
            this.button1.TabStop = true;
            this.button1.Text = "radioButton1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.CheckedChanged += new System.EventHandler(this.button6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 41);
            this.button2.TabIndex = 2;
            this.button2.TabStop = true;
            this.button2.Text = "radioButton2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 44);
            this.button3.TabIndex = 3;
            this.button3.TabStop = true;
            this.button3.Text = "radioButton3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(449, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(307, 41);
            this.button4.TabIndex = 4;
            this.button4.TabStop = true;
            this.button4.Text = "radioButton4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(358, 310);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 5;
            this.button10.Text = "СЛЕДВАЩ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(52, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "ИЗХОД";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(776, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шофьорски курсове";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(358, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "НАЧАЛО!";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton button2;
        private System.Windows.Forms.RadioButton button3;
        private System.Windows.Forms.RadioButton button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
    }
}

