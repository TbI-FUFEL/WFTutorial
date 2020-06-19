namespace Esoft_Project
{
    partial class Menu
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenDemands = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Esoft_Project.Properties.Resources.avatar_146154;
            this.pictureBox2.Location = new System.Drawing.Point(146, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 114);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.avatar_100696;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.Location = new System.Drawing.Point(12, 188);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenClients.TabIndex = 2;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = true;
            this.buttonOpenClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.Location = new System.Drawing.Point(12, 251);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenAgents.TabIndex = 3;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseVisualStyleBackColor = true;
            // 
            // buttonOpenRealEstates
            // 
            this.buttonOpenRealEstates.Location = new System.Drawing.Point(12, 315);
            this.buttonOpenRealEstates.Name = "buttonOpenRealEstates";
            this.buttonOpenRealEstates.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenRealEstates.TabIndex = 4;
            this.buttonOpenRealEstates.Text = "Объекты недвижимости";
            this.buttonOpenRealEstates.UseVisualStyleBackColor = true;
            // 
            // buttonOpenDemands
            // 
            this.buttonOpenDemands.Location = new System.Drawing.Point(12, 382);
            this.buttonOpenDemands.Name = "buttonOpenDemands";
            this.buttonOpenDemands.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenDemands.TabIndex = 5;
            this.buttonOpenDemands.Text = "Предложения";
            this.buttonOpenDemands.UseVisualStyleBackColor = true;
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.Location = new System.Drawing.Point(12, 451);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenSupplies.TabIndex = 6;
            this.buttonOpenSupplies.Text = "Потребности";
            this.buttonOpenSupplies.UseVisualStyleBackColor = true;
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.Location = new System.Drawing.Point(12, 516);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenDeals.TabIndex = 7;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 561);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenDemands);
            this.Controls.Add(this.buttonOpenRealEstates);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Антейку";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenRealEstates;
        private System.Windows.Forms.Button buttonOpenDemands;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenDeals;
    }
}

