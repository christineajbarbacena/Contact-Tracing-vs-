namespace Contact_Tracing
{
    partial class S
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
            this.title = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtboxFN = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.Label();
            this.txtboxMN = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.Suffix = new System.Windows.Forms.Label();
            this.txtboxLN = new System.Windows.Forms.TextBox();
            this.txtboxSuffix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(212, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(277, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Contact Tracing Form";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(14, 86);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(60, 13);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name:";
            // 
            // txtboxFN
            // 
            this.txtboxFN.Location = new System.Drawing.Point(80, 79);
            this.txtboxFN.Name = "txtboxFN";
            this.txtboxFN.Size = new System.Drawing.Size(133, 20);
            this.txtboxFN.TabIndex = 2;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(229, 86);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(72, 13);
            this.MiddleName.TabIndex = 3;
            this.MiddleName.Text = "Middle Name:";
            this.MiddleName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxMN
            // 
            this.txtboxMN.Location = new System.Drawing.Point(310, 79);
            this.txtboxMN.Name = "txtboxMN";
            this.txtboxMN.Size = new System.Drawing.Size(74, 20);
            this.txtboxMN.TabIndex = 4;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(400, 86);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Last Name:";
            // 
            // Suffix
            // 
            this.Suffix.AutoSize = true;
            this.Suffix.Location = new System.Drawing.Point(610, 86);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(36, 13);
            this.Suffix.TabIndex = 6;
            this.Suffix.Text = "Suffix:";
            // 
            // txtboxLN
            // 
            this.txtboxLN.Location = new System.Drawing.Point(467, 79);
            this.txtboxLN.Name = "txtboxLN";
            this.txtboxLN.Size = new System.Drawing.Size(114, 20);
            this.txtboxLN.TabIndex = 7;
            // 
            // txtboxSuffix
            // 
            this.txtboxSuffix.Location = new System.Drawing.Point(652, 79);
            this.txtboxSuffix.Name = "txtboxSuffix";
            this.txtboxSuffix.Size = new System.Drawing.Size(74, 20);
            this.txtboxSuffix.TabIndex = 8;
            // 
            // S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 413);
            this.Controls.Add(this.txtboxSuffix);
            this.Controls.Add(this.txtboxLN);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtboxMN);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.txtboxFN);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.title);
            this.Name = "S";
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtboxFN;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.TextBox txtboxMN;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Suffix;
        private System.Windows.Forms.TextBox txtboxLN;
        private System.Windows.Forms.TextBox txtboxSuffix;
    }
}

