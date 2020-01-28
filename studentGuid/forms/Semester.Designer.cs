namespace studentGuid.forms
{
    partial class Semester
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
            this.SemesterBox = new System.Windows.Forms.GroupBox();
            this.Semester2Check = new System.Windows.Forms.CheckBox();
            this.Semester1Check = new System.Windows.Forms.CheckBox();
            this.SemesterNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpToNowGPA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SemesterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SemesterBox
            // 
            this.SemesterBox.Controls.Add(this.label3);
            this.SemesterBox.Controls.Add(this.label2);
            this.SemesterBox.Controls.Add(this.label1);
            this.SemesterBox.Controls.Add(this.Semester2Check);
            this.SemesterBox.Controls.Add(this.Semester1Check);
            this.SemesterBox.Location = new System.Drawing.Point(78, 66);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(246, 222);
            this.SemesterBox.TabIndex = 0;
            this.SemesterBox.TabStop = false;
            this.SemesterBox.Text = "Select Semester";
            // 
            // Semester2Check
            // 
            this.Semester2Check.AutoSize = true;
            this.Semester2Check.Location = new System.Drawing.Point(28, 150);
            this.Semester2Check.Name = "Semester2Check";
            this.Semester2Check.Size = new System.Drawing.Size(79, 17);
            this.Semester2Check.TabIndex = 2;
            this.Semester2Check.Text = "Semester 2";
            this.Semester2Check.UseVisualStyleBackColor = true;
            // 
            // Semester1Check
            // 
            this.Semester1Check.AutoSize = true;
            this.Semester1Check.Location = new System.Drawing.Point(28, 78);
            this.Semester1Check.Name = "Semester1Check";
            this.Semester1Check.Size = new System.Drawing.Size(79, 17);
            this.Semester1Check.TabIndex = 1;
            this.Semester1Check.Text = "Semester 1";
            this.Semester1Check.UseVisualStyleBackColor = true;
            // 
            // SemesterNext
            // 
            this.SemesterNext.Location = new System.Drawing.Point(249, 321);
            this.SemesterNext.Name = "SemesterNext";
            this.SemesterNext.Size = new System.Drawing.Size(75, 23);
            this.SemesterNext.TabIndex = 1;
            this.SemesterNext.Text = "NEXT";
            this.SemesterNext.UseVisualStyleBackColor = true;
            this.SemesterNext.Click += new System.EventHandler(this.SemesterNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLICK BUTTON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CLICK BUTTON";
            // 
            // UpToNowGPA
            // 
            this.UpToNowGPA.Location = new System.Drawing.Point(106, 321);
            this.UpToNowGPA.Name = "UpToNowGPA";
            this.UpToNowGPA.Size = new System.Drawing.Size(118, 23);
            this.UpToNowGPA.TabIndex = 2;
            this.UpToNowGPA.Text = "NOW GPA VALUE";
            this.UpToNowGPA.UseVisualStyleBackColor = true;
            this.UpToNowGPA.Click += new System.EventHandler(this.UpToNowGPA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CURRENT VALUE";
            // 
            // Semester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 404);
            this.Controls.Add(this.UpToNowGPA);
            this.Controls.Add(this.SemesterNext);
            this.Controls.Add(this.SemesterBox);
            this.Name = "Semester";
            this.Text = "Semester";
            this.SemesterBox.ResumeLayout(false);
            this.SemesterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SemesterBox;
        public System.Windows.Forms.CheckBox Semester2Check;
        public System.Windows.Forms.CheckBox Semester1Check;
        private System.Windows.Forms.Button SemesterNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpToNowGPA;
    }
}