namespace Diplom
{
    partial class DBForm
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
            this.btnRead = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnAddApartament = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(36, 241);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(122, 40);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Обновить базу";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(204, 28);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(1066, 532);
            this.dgvMain.TabIndex = 3;
            // 
            // btnAddApartament
            // 
            this.btnAddApartament.Location = new System.Drawing.Point(36, 102);
            this.btnAddApartament.Name = "btnAddApartament";
            this.btnAddApartament.Size = new System.Drawing.Size(122, 41);
            this.btnAddApartament.TabIndex = 4;
            this.btnAddApartament.Text = "Добавить объект";
            this.btnAddApartament.UseVisualStyleBackColor = true;
            this.btnAddApartament.Click += new System.EventHandler(this.btnAddApartament_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(36, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить запись";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 610);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddApartament);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnRead);
            this.Name = "DBForm";
            this.Text = "БАЗА ДАННЫХ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnAddApartament;
        private System.Windows.Forms.Button btnDelete;
    }
}

