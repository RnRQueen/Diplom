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
            this.btnDB.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDB.Image = global::Diplom.Properties.Resources.w48h481337349837Database;
            this.btnDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDB.Location = new System.Drawing.Point(12, 12);
            this.btnDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(89, 86);
            this.btnDB.TabIndex = 0;
            this.btnDB.Text = "База данных";
            this.btnDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnAccaunts
            // 
            this.btnAccaunts.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccaunts.Image = global::Diplom.Properties.Resources.users;
            this.btnAccaunts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccaunts.Location = new System.Drawing.Point(124, 12);
            this.btnAccaunts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccaunts.Name = "btnAccaunts";
            this.btnAccaunts.Size = new System.Drawing.Size(88, 86);
            this.btnAccaunts.TabIndex = 1;
            this.btnAccaunts.Text = "Аккаунты";
            this.btnAccaunts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccaunts.UseVisualStyleBackColor = true;
            this.btnAccaunts.Click += new System.EventHandler(this.btnAccaunts_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcelExport.Image = global::Diplom.Properties.Resources._6a6822a3_b4a6_45fa_80c1_94a56f2ecee6;
            this.btnExcelExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcelExport.Location = new System.Drawing.Point(654, 12);
            this.btnExcelExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(105, 95);
            this.btnExcelExport.TabIndex = 2;
            this.btnExcelExport.Text = "Экспорт в Excel";
            this.btnExcelExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnExcelImport
            // 
            this.btnExcelImport.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcelImport.Image = global::Diplom.Properties.Resources._3a023987_f999_4243_8725_f08e9fa31905;
            this.btnExcelImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcelImport.Location = new System.Drawing.Point(780, 12);
            this.btnExcelImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcelImport.Name = "btnExcelImport";
            this.btnExcelImport.Size = new System.Drawing.Size(99, 95);
            this.btnExcelImport.TabIndex = 3;
            this.btnExcelImport.Text = "Импорт из Excel";
            this.btnExcelImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcelImport.UseVisualStyleBackColor = true;
            this.btnExcelImport.Click += new System.EventHandler(this.btnExcelImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddAnAd
            // 
            this.btnAddAnAd.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnAd.Image = global::Diplom.Properties.Resources.Ok;
            this.btnAddAnAd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddAnAd.Location = new System.Drawing.Point(418, 12);
            this.btnAddAnAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAnAd.Name = "btnAddAnAd";
            this.btnAddAnAd.Size = new System.Drawing.Size(99, 95);
            this.btnAddAnAd.TabIndex = 4;
            this.btnAddAnAd.Text = "Разместить объявление";
            this.btnAddAnAd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAnAd.UseVisualStyleBackColor = true;
            // 
            // btnGetList
            // 
            this.btnGetList.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetList.Image = global::Diplom.Properties.Resources.download;
            this.btnGetList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGetList.Location = new System.Drawing.Point(533, 12);
            this.btnGetList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(105, 95);
            this.btnGetList.TabIndex = 5;
            this.btnGetList.Text = "Получить список объявлений";
            this.btnGetList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 555);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.btnAddAnAd);
            this.Controls.Add(this.btnExcelImport);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.btnAccaunts);
            this.Controls.Add(this.btnDB);
            this.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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