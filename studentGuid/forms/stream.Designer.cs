namespace studentGuid.forms
{
    partial class Stream
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
            this.StreamSelect = new System.Windows.Forms.GroupBox();
            this.bcsRadioBtn = new System.Windows.Forms.RadioButton();
            this.PhyRadioBtn = new System.Windows.Forms.RadioButton();
            this.BioRadioBtn = new System.Windows.Forms.RadioButton();
            this.StrNextBtn = new System.Windows.Forms.Button();
            this.CalGPA = new System.Windows.Forms.Button();
            this.StreamSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // StreamSelect
            // 
            this.StreamSelect.Controls.Add(this.BioRadioBtn);
            this.StreamSelect.Controls.Add(this.PhyRadioBtn);
            this.StreamSelect.Controls.Add(this.bcsRadioBtn);
            this.StreamSelect.Location = new System.Drawing.Point(48, 43);
            this.StreamSelect.Name = "StreamSelect";
            this.StreamSelect.Size = new System.Drawing.Size(200, 214);
            this.StreamSelect.TabIndex = 0;
            this.StreamSelect.TabStop = false;
            this.StreamSelect.Text = "Stream";
            // 
            // bcsRadioBtn
            // 
            this.bcsRadioBtn.AutoSize = true;
            this.bcsRadioBtn.Location = new System.Drawing.Point(38, 46);
            this.bcsRadioBtn.Name = "bcsRadioBtn";
            this.bcsRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.bcsRadioBtn.TabIndex = 0;
            this.bcsRadioBtn.TabStop = true;
            this.bcsRadioBtn.Text = "BCS";
            this.bcsRadioBtn.UseVisualStyleBackColor = true;
            this.bcsRadioBtn.CheckedChanged += new System.EventHandler(this.bcsRadioBtn_CheckedChanged);
            // 
            // PhyRadioBtn
            // 
            this.PhyRadioBtn.AutoSize = true;
            this.PhyRadioBtn.Location = new System.Drawing.Point(38, 98);
            this.PhyRadioBtn.Name = "PhyRadioBtn";
            this.PhyRadioBtn.Size = new System.Drawing.Size(64, 17);
            this.PhyRadioBtn.TabIndex = 1;
            this.PhyRadioBtn.TabStop = true;
            this.PhyRadioBtn.Text = "Physical";
            this.PhyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BioRadioBtn
            // 
            this.BioRadioBtn.AutoSize = true;
            this.BioRadioBtn.Location = new System.Drawing.Point(38, 148);
            this.BioRadioBtn.Name = "BioRadioBtn";
            this.BioRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.BioRadioBtn.TabIndex = 2;
            this.BioRadioBtn.TabStop = true;
            this.BioRadioBtn.Text = "Biology";
            this.BioRadioBtn.UseVisualStyleBackColor = true;
            // 
            // StrNextBtn
            // 
            this.StrNextBtn.Location = new System.Drawing.Point(236, 317);
            this.StrNextBtn.Name = "StrNextBtn";
            this.StrNextBtn.Size = new System.Drawing.Size(75, 23);
            this.StrNextBtn.TabIndex = 1;
            this.StrNextBtn.Text = "NEXT";
            this.StrNextBtn.UseVisualStyleBackColor = true;
            this.StrNextBtn.Click += new System.EventHandler(this.StrNextBtn_Click);
            // 
            // CalGPA
            // 
            this.CalGPA.Location = new System.Drawing.Point(99, 317);
            this.CalGPA.Name = "CalGPA";
            this.CalGPA.Size = new System.Drawing.Size(75, 23);
            this.CalGPA.TabIndex = 2;
            this.CalGPA.Text = "SHOW GPA";
            this.CalGPA.UseVisualStyleBackColor = true;
            // 
            // Stream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 390);
            this.Controls.Add(this.CalGPA);
            this.Controls.Add(this.StrNextBtn);
            this.Controls.Add(this.StreamSelect);
            this.Name = "Stream";
            this.Text = "stream";
            this.StreamSelect.ResumeLayout(false);
            this.StreamSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StreamSelect;
        public System.Windows.Forms.RadioButton BioRadioBtn;
        public System.Windows.Forms.RadioButton PhyRadioBtn;
        public System.Windows.Forms.RadioButton bcsRadioBtn;
        private System.Windows.Forms.Button StrNextBtn;
        private System.Windows.Forms.Button CalGPA;
    }
}