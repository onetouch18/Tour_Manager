namespace TourManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonTours = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.buttonRequests = new System.Windows.Forms.Button();
            this.buttonCountries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.Location = new System.Drawing.Point(158, 60);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(239, 39);
            this.buttonOrder.TabIndex = 0;
            this.buttonOrder.Text = "Замовити путівку";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.Location = new System.Drawing.Point(158, 100);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(239, 39);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клієнти";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonTours
            // 
            this.buttonTours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTours.Location = new System.Drawing.Point(158, 180);
            this.buttonTours.Name = "buttonTours";
            this.buttonTours.Size = new System.Drawing.Size(239, 39);
            this.buttonTours.TabIndex = 2;
            this.buttonTours.Text = "Тури";
            this.buttonTours.UseVisualStyleBackColor = true;
            this.buttonTours.Click += new System.EventHandler(this.buttonTours_Click);
            // 
            // buttonAddService
            // 
            this.buttonAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddService.Location = new System.Drawing.Point(158, 220);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(239, 39);
            this.buttonAddService.TabIndex = 3;
            this.buttonAddService.Text = "Додат. послуги";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // buttonRequests
            // 
            this.buttonRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRequests.Location = new System.Drawing.Point(158, 260);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(239, 39);
            this.buttonRequests.TabIndex = 4;
            this.buttonRequests.Text = "Звіти";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonCountries
            // 
            this.buttonCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCountries.Location = new System.Drawing.Point(158, 140);
            this.buttonCountries.Name = "buttonCountries";
            this.buttonCountries.Size = new System.Drawing.Size(239, 39);
            this.buttonCountries.TabIndex = 5;
            this.buttonCountries.Text = "Країни";
            this.buttonCountries.UseVisualStyleBackColor = true;
            this.buttonCountries.Click += new System.EventHandler(this.buttonCountries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TourManager.Properties.Resources._113;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(554, 352);
            this.Controls.Add(this.buttonCountries);
            this.Controls.Add(this.buttonRequests);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.buttonTours);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Туристична фірма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonTours;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Button buttonRequests;
        private System.Windows.Forms.Button buttonCountries;
    }
}

