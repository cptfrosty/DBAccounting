
namespace DBAccounting
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dgEmplooyes = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnExperience = new System.Windows.Forms.Button();
            this.BtnRatingSalary = new System.Windows.Forms.Button();
            this.BtnEducation = new System.Windows.Forms.Button();
            this.BtnAllEmp = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmplooyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сотрудники";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.InfoLabel);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.BtnExperience);
            this.panel1.Controls.Add(this.BtnRatingSalary);
            this.panel1.Controls.Add(this.BtnEducation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnAllEmp);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 94);
            this.panel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(806, 441);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dgEmplooyes
            // 
            this.dgEmplooyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmplooyes.Location = new System.Drawing.Point(12, 95);
            this.dgEmplooyes.Name = "dgEmplooyes";
            this.dgEmplooyes.Size = new System.Drawing.Size(701, 282);
            this.dgEmplooyes.TabIndex = 5;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Image = global::DBAccounting.Properties.Resources.Поиск;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(702, 0);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(104, 50);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnExperience
            // 
            this.BtnExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnExperience.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExperience.Image = global::DBAccounting.Properties.Resources.Сотрудник;
            this.BtnExperience.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExperience.Location = new System.Drawing.Point(454, 0);
            this.BtnExperience.Name = "BtnExperience";
            this.BtnExperience.Size = new System.Drawing.Size(84, 50);
            this.BtnExperience.TabIndex = 5;
            this.BtnExperience.Text = "Стаж";
            this.BtnExperience.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExperience.UseVisualStyleBackColor = false;
            this.BtnExperience.Click += new System.EventHandler(this.BtnExperience_Click);
            // 
            // BtnRatingSalary
            // 
            this.BtnRatingSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRatingSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRatingSalary.Image = global::DBAccounting.Properties.Resources.Деньги;
            this.BtnRatingSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRatingSalary.Location = new System.Drawing.Point(327, 0);
            this.BtnRatingSalary.Name = "BtnRatingSalary";
            this.BtnRatingSalary.Size = new System.Drawing.Size(130, 50);
            this.BtnRatingSalary.TabIndex = 4;
            this.BtnRatingSalary.Text = "Рейтинг оплаты";
            this.BtnRatingSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRatingSalary.UseVisualStyleBackColor = false;
            this.BtnRatingSalary.Click += new System.EventHandler(this.BtnRatingSalary_Click);
            // 
            // BtnEducation
            // 
            this.BtnEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEducation.Image = global::DBAccounting.Properties.Resources.Образование_96;
            this.BtnEducation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEducation.Location = new System.Drawing.Point(210, 0);
            this.BtnEducation.Name = "BtnEducation";
            this.BtnEducation.Size = new System.Drawing.Size(125, 50);
            this.BtnEducation.TabIndex = 3;
            this.BtnEducation.Text = "Образование  ";
            this.BtnEducation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEducation.UseVisualStyleBackColor = false;
            this.BtnEducation.Click += new System.EventHandler(this.BtnEducation_Click);
            // 
            // BtnAllEmp
            // 
            this.BtnAllEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAllEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllEmp.Image = global::DBAccounting.Properties.Resources.Все_сотрудники;
            this.BtnAllEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAllEmp.Location = new System.Drawing.Point(97, 0);
            this.BtnAllEmp.Name = "BtnAllEmp";
            this.BtnAllEmp.Size = new System.Drawing.Size(118, 50);
            this.BtnAllEmp.TabIndex = 0;
            this.BtnAllEmp.Text = "Все      ";
            this.BtnAllEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAllEmp.UseVisualStyleBackColor = false;
            this.BtnAllEmp.Click += new System.EventHandler(this.BtnAllEmp_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 383);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(315, 123);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(16, 60);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(51, 13);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "InfoLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgEmplooyes);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Бухгалтерия";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmplooyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAllEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnExperience;
        private System.Windows.Forms.Button BtnRatingSalary;
        private System.Windows.Forms.Button BtnEducation;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dgEmplooyes;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

