namespace BasicContacts_LocalDBWinForm_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.btn_AddEdit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lb_Clear = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(130, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по контактам";
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(133, 43);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(254, 20);
            this.tbx_Search.TabIndex = 1;
            this.tbx_Search.TextChanged += new System.EventHandler(this.tbx_Search_TextChanged);
            // 
            // btn_AddEdit
            // 
            this.btn_AddEdit.Location = new System.Drawing.Point(27, 57);
            this.btn_AddEdit.Name = "btn_AddEdit";
            this.btn_AddEdit.Size = new System.Drawing.Size(131, 22);
            this.btn_AddEdit.TabIndex = 1;
            this.btn_AddEdit.Text = "Добавить контакт";
            this.btn_AddEdit.UseVisualStyleBackColor = true;
            this.btn_AddEdit.Click += new System.EventHandler(this.btn_AddEdit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Добавить контакт",
            "Изменить контакт",
            "Удалить"});
            this.comboBox1.Location = new System.Drawing.Point(27, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 416);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_AddEdit);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 416);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_Clear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbx_Search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 100);
            this.panel2.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(200, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(566, 316);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lb_Clear
            // 
            this.lb_Clear.AutoSize = true;
            this.lb_Clear.BackColor = System.Drawing.SystemColors.Window;
            this.lb_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Clear.Location = new System.Drawing.Point(371, 46);
            this.lb_Clear.Name = "lb_Clear";
            this.lb_Clear.Size = new System.Drawing.Size(14, 13);
            this.lb_Clear.TabIndex = 3;
            this.lb_Clear.Text = "X";
            this.lb_Clear.Click += new System.EventHandler(this.lb_Clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 416);
            this.Controls.Add(this.panel3);
            this.Name = "MainForm";
            this.Text = "BasicContacts(LocalDBWinForm)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Search;
        private System.Windows.Forms.Button btn_AddEdit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_Clear;
        private System.Windows.Forms.Panel panel1;
    }
}

