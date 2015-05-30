namespace Diplom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDB = new System.Windows.Forms.Button();
            this.btnAccaunts = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnExcelImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddAnAd = new System.Windows.Forms.Button();
            this.btnGetList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(47, 50);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(149, 45);
            this.btnDB.TabIndex = 0;
            this.btnDB.Text = "БАЗА ДАННЫХ";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnAccaunts
            // 
            this.btnAccaunts.Location = new System.Drawing.Point(47, 126);
            this.btnAccaunts.Name = "btnAccaunts";
            this.btnAccaunts.Size = new System.Drawing.Size(149, 46);
            this.btnAccaunts.TabIndex = 1;
            this.btnAccaunts.Text = "Аккаунты";
            this.btnAccaunts.UseVisualStyleBackColor = true;
            this.btnAccaunts.Click += new System.EventHandler(this.btnAccaunts_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(304, 51);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(169, 45);
            this.btnExcelExport.TabIndex = 2;
            this.btnExcelExport.Text = "Экспорт в Excel";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnExcelImport
            // 
            this.btnExcelImport.Location = new System.Drawing.Point(304, 129);
            this.btnExcelImport.Name = "btnExcelImport";
            this.btnExcelImport.Size = new System.Drawing.Size(169, 43);
            this.btnExcelImport.TabIndex = 3;
            this.btnExcelImport.Text = "Импорт из Excel";
            this.btnExcelImport.UseVisualStyleBackColor = true;
            this.btnExcelImport.Click += new System.EventHandler(this.btnExcelImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddAnAd
            // 
            this.btnAddAnAd.Location = new System.Drawing.Point(555, 51);
            this.btnAddAnAd.Name = "btnAddAnAd";
            this.btnAddAnAd.Size = new System.Drawing.Size(155, 44);
            this.btnAddAnAd.TabIndex = 4;
            this.btnAddAnAd.Text = "Разместить объявление";
            this.btnAddAnAd.UseVisualStyleBackColor = true;
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(555, 126);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(155, 46);
            this.btnGetList.TabIndex = 5;
            this.btnGetList.Text = "Получить список объявлений";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 566);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.btnAddAnAd);
            this.Controls.Add(this.btnExcelImport);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.btnAccaunts);
            this.Controls.Add(this.btnDB);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnAccaunts;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Button btnExcelImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddAnAd;
        private System.Windows.Forms.Button btnGetList;
    }
}