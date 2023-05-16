
namespace DBAccounting
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.TbSalary = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPAdmissionWork = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPositionWork = new System.Windows.Forms.TextBox();
            this.CbEducation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbFullName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbSalary
            // 
            this.TbSalary.Location = new System.Drawing.Point(114, 225);
            this.TbSalary.Name = "TbSalary";
            this.TbSalary.Size = new System.Drawing.Size(255, 20);
            this.TbSalary.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 112);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(114, 263);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(113, 58);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Заработная плата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Дата поступления на работу";
            // 
            // DTPAdmissionWork
            // 
            this.DTPAdmissionWork.Location = new System.Drawing.Point(114, 173);
            this.DTPAdmissionWork.Name = "DTPAdmissionWork";
            this.DTPAdmissionWork.Size = new System.Drawing.Size(255, 20);
            this.DTPAdmissionWork.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Должность";
            // 
            // TbPositionWork
            // 
            this.TbPositionWork.Location = new System.Drawing.Point(114, 125);
            this.TbPositionWork.Name = "TbPositionWork";
            this.TbPositionWork.Size = new System.Drawing.Size(255, 20);
            this.TbPositionWork.TabIndex = 19;
            // 
            // CbEducation
            // 
            this.CbEducation.FormattingEnabled = true;
            this.CbEducation.Location = new System.Drawing.Point(114, 78);
            this.CbEducation.Name = "CbEducation";
            this.CbEducation.Size = new System.Drawing.Size(255, 21);
            this.CbEducation.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Образование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ФИО";
            // 
            // TbFullName
            // 
            this.TbFullName.Location = new System.Drawing.Point(114, 34);
            this.TbFullName.Name = "TbFullName";
            this.TbFullName.Size = new System.Drawing.Size(255, 20);
            this.TbFullName.TabIndex = 15;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.TbSalary);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPAdmissionWork);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbPositionWork);
            this.Controls.Add(this.CbEducation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbFullName);
            this.Name = "AddUser";
            this.Text = "Добавление сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbSalary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPAdmissionWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPositionWork;
        private System.Windows.Forms.ComboBox CbEducation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbFullName;
    }
}