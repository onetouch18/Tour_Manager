namespace TourManager
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSaveDB = new System.Windows.Forms.Button();
            this.buttonDBToExl = new System.Windows.Forms.Button();
            this.buttonAddToDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(486, 255);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonSaveDB
            // 
            this.buttonSaveDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveDB.Location = new System.Drawing.Point(338, 273);
            this.buttonSaveDB.Name = "buttonSaveDB";
            this.buttonSaveDB.Size = new System.Drawing.Size(160, 37);
            this.buttonSaveDB.TabIndex = 1;
            this.buttonSaveDB.Text = "Зберегти базу";
            this.buttonSaveDB.UseVisualStyleBackColor = true;
            this.buttonSaveDB.Click += new System.EventHandler(this.buttonSaveDB_Click);
            // 
            // buttonDBToExl
            // 
            this.buttonDBToExl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDBToExl.Location = new System.Drawing.Point(172, 273);
            this.buttonDBToExl.Name = "buttonDBToExl";
            this.buttonDBToExl.Size = new System.Drawing.Size(160, 37);
            this.buttonDBToExl.TabIndex = 2;
            this.buttonDBToExl.Text = "Вивести у файл";
            this.buttonDBToExl.UseVisualStyleBackColor = true;
            this.buttonDBToExl.Click += new System.EventHandler(this.buttonDBToExl_Click);
            // 
            // buttonAddToDB
            // 
            this.buttonAddToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToDB.Location = new System.Drawing.Point(12, 272);
            this.buttonAddToDB.Name = "buttonAddToDB";
            this.buttonAddToDB.Size = new System.Drawing.Size(154, 37);
            this.buttonAddToDB.TabIndex = 3;
            this.buttonAddToDB.Text = "Додати до бази";
            this.buttonAddToDB.UseVisualStyleBackColor = true;
            this.buttonAddToDB.Click += new System.EventHandler(this.buttonAddToDB_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TourManager.Properties.Resources._114;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(510, 321);
            this.Controls.Add(this.buttonAddToDB);
            this.Controls.Add(this.buttonDBToExl);
            this.Controls.Add(this.buttonSaveDB);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Имя базы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSaveDB;
        private System.Windows.Forms.Button buttonDBToExl;
        private System.Windows.Forms.Button buttonAddToDB;
    }
}