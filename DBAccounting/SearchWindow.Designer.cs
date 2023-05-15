
namespace DBAccounting
{
    partial class SearchWindow
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
            this.TbFullName = new System.Windows.Forms.TextBox();
            this.LbStaff = new System.Windows.Forms.ListBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // TbFullName
            // 
            this.TbFullName.Location = new System.Drawing.Point(53, 10);
            this.TbFullName.Name = "TbFullName";
            this.TbFullName.Size = new System.Drawing.Size(244, 20);
            this.TbFullName.TabIndex = 1;
            // 
            // LbStaff
            // 
            this.LbStaff.FormattingEnabled = true;
            this.LbStaff.Location = new System.Drawing.Point(12, 73);
            this.LbStaff.Name = "LbStaff";
            this.LbStaff.Size = new System.Drawing.Size(285, 368);
            this.LbStaff.TabIndex = 2;
            this.LbStaff.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbStaff_MouseDoubleClick);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(222, 44);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LbStaff);
            this.Controls.Add(this.TbFullName);
            this.Controls.Add(this.label1);
            this.Name = "SearchWindow";
            this.Text = "Поиск сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbFullName;
        private System.Windows.Forms.ListBox LbStaff;
        private System.Windows.Forms.Button BtnSearch;
    }
}