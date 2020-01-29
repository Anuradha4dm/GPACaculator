namespace studentGuid.forms
{
    partial class Year
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
            this.YearBox = new System.Windows.Forms.GroupBox();
            this.Year4check = new System.Windows.Forms.CheckBox();
            this.Year3check = new System.Windows.Forms.CheckBox();
            this.Year2check = new System.Windows.Forms.CheckBox();
            this.Year1check = new System.Windows.Forms.CheckBox();
            this.YearNextBtn = new System.Windows.Forms.Button();
            this.YearGPA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YearBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // YearBox
            // 
            this.YearBox.Controls.Add(this.label5);
            this.YearBox.Controls.Add(this.label4);
            this.YearBox.Controls.Add(this.label3);
            this.YearBox.Controls.Add(this.label2);
            this.YearBox.Controls.Add(this.label1);
            this.YearBox.Controls.Add(this.Year4check);
            this.YearBox.Controls.Add(this.Year3check);
            this.YearBox.Controls.Add(this.Year2check);
            this.YearBox.Controls.Add(this.Year1check);
            this.YearBox.Location = new System.Drawing.Point(44, 54);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(334, 282);
            this.YearBox.TabIndex = 0;
            this.YearBox.TabStop = false;
            this.YearBox.Text = "Select Year";
            // 
            // Year4check
            // 
            this.Year4check.AutoSize = true;
            this.Year4check.Location = new System.Drawing.Point(77, 225);
            this.Year4check.Name = "Year4check";
            this.Year4check.Size = new System.Drawing.Size(57, 17);
            this.Year4check.TabIndex = 3;
            this.Year4check.Text = "Year 4";
            this.Year4check.UseVisualStyleBackColor = true;
            // 
            // Year3check
            // 
            this.Year3check.AutoSize = true;
            this.Year3check.Location = new System.Drawing.Point(77, 180);
            this.Year3check.Name = "Year3check";
            this.Year3check.Size = new System.Drawing.Size(57, 17);
            this.Year3check.TabIndex = 2;
            this.Year3check.Text = "Year 3";
            this.Year3check.UseVisualStyleBackColor = true;
            // 
            // Year2check
            // 
            this.Year2check.AutoSize = true;
            this.Year2check.Location = new System.Drawing.Point(77, 129);
            this.Year2check.Name = "Year2check";
            this.Year2check.Size = new System.Drawing.Size(57, 17);
            this.Year2check.TabIndex = 1;
            this.Year2check.Text = "Year 2";
            this.Year2check.UseVisualStyleBackColor = true;
            // 
            // Year1check
            // 
            this.Year1check.AutoSize = true;
            this.Year1check.Location = new System.Drawing.Point(77, 86);
            this.Year1check.Name = "Year1check";
            this.Year1check.Size = new System.Drawing.Size(57, 17);
            this.Year1check.TabIndex = 0;
            this.Year1check.Text = "Year 1";
            this.Year1check.UseVisualStyleBackColor = true;
            // 
            // YearNextBtn
            // 
            this.YearNextBtn.Location = new System.Drawing.Point(303, 359);
            this.YearNextBtn.Name = "YearNextBtn";
            this.YearNextBtn.Size = new System.Drawing.Size(75, 23);
            this.YearNextBtn.TabIndex = 1;
            this.YearNextBtn.Text = "NEXT";
            this.YearNextBtn.UseVisualStyleBackColor = true;
            this.YearNextBtn.Click += new System.EventHandler(this.YearNextBtn_Click);
            // 
            // YearGPA
            // 
            this.YearGPA.Location = new System.Drawing.Point(177, 359);
            this.YearGPA.Name = "YearGPA";
            this.YearGPA.Size = new System.Drawing.Size(75, 23);
            this.YearGPA.TabIndex = 2;
            this.YearGPA.Text = "UP GPA";
            this.YearGPA.UseVisualStyleBackColor = true;
            this.YearGPA.Click += new System.EventHandler(this.YearGPA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "GPA VALUE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Not Yet Add";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Not Yet Add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Not Yet Add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Not Yet Add";
            // 
            // Year
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 419);
            this.Controls.Add(this.YearGPA);
            this.Controls.Add(this.YearNextBtn);
            this.Controls.Add(this.YearBox);
            this.Name = "Year";
            this.Text = "Year";
            this.YearBox.ResumeLayout(false);
            this.YearBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox YearBox;
        private System.Windows.Forms.CheckBox Year4check;
        public System.Windows.Forms.CheckBox Year3check;
        public System.Windows.Forms.CheckBox Year2check;
        public System.Windows.Forms.CheckBox Year1check;
        private System.Windows.Forms.Button YearNextBtn;
        private System.Windows.Forms.Button YearGPA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}