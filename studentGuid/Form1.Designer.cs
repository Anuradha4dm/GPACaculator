namespace studentGuid
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
            this.GPACalculation = new System.Windows.Forms.Button();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GPACalculation
            // 
            this.GPACalculation.Location = new System.Drawing.Point(145, 74);
            this.GPACalculation.Name = "GPACalculation";
            this.GPACalculation.Size = new System.Drawing.Size(116, 23);
            this.GPACalculation.TabIndex = 0;
            this.GPACalculation.Text = "GPA CHECK";
            this.GPACalculation.UseVisualStyleBackColor = true;
            this.GPACalculation.Click += new System.EventHandler(this.GPACalculation_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(292, 324);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(102, 23);
            this.LogInBtn.TabIndex = 1;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = true;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(29, 324);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(116, 23);
            this.SignUpBtn.TabIndex = 2;
            this.SignUpBtn.Text = "SIGN UP";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 398);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.GPACalculation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GPACalculation;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button SignUpBtn;
    }
}

