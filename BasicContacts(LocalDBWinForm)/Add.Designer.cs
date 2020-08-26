namespace BasicContacts_LocalDBWinForm_
{
    partial class Add
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
            this.btn_Accept = new System.Windows.Forms.Button();
            this.mtbx_Age = new System.Windows.Forms.MaskedTextBox();
            this.tbx_Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_SurName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.tbx_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Accept
            // 
            this.btn_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Accept.Location = new System.Drawing.Point(124, 178);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 32;
            this.btn_Accept.Text = "Добавить";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // mtbx_Age
            // 
            this.mtbx_Age.Location = new System.Drawing.Point(104, 116);
            this.mtbx_Age.Mask = "00/00/0000";
            this.mtbx_Age.Name = "mtbx_Age";
            this.mtbx_Age.Size = new System.Drawing.Size(65, 20);
            this.mtbx_Age.TabIndex = 31;
            this.mtbx_Age.ValidatingType = typeof(System.DateTime);
            // 
            // tbx_Phone
            // 
            this.tbx_Phone.Location = new System.Drawing.Point(74, 142);
            this.tbx_Phone.Name = "tbx_Phone";
            this.tbx_Phone.Size = new System.Drawing.Size(221, 20);
            this.tbx_Phone.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Дата рождения";
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(74, 90);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(221, 20);
            this.tbx_Email.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Эл.почта";
            // 
            // tbx_SurName
            // 
            this.tbx_SurName.Location = new System.Drawing.Point(74, 64);
            this.tbx_SurName.Name = "tbx_SurName";
            this.tbx_SurName.Size = new System.Drawing.Size(221, 20);
            this.tbx_SurName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Отчество";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(74, 38);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(221, 20);
            this.tbx_Name.TabIndex = 23;
            // 
            // tbx_FirstName
            // 
            this.tbx_FirstName.Location = new System.Drawing.Point(74, 12);
            this.tbx_FirstName.Name = "tbx_FirstName";
            this.tbx_FirstName.Size = new System.Drawing.Size(221, 20);
            this.tbx_FirstName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Фамилия";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(220, 178);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.Text = "Отмена";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 227);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.mtbx_Age);
            this.Controls.Add(this.tbx_Phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_SurName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.tbx_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.MaskedTextBox mtbx_Age;
        private System.Windows.Forms.TextBox tbx_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_SurName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.TextBox tbx_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
    }
}