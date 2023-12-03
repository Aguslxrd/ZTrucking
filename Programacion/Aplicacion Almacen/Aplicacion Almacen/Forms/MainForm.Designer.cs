namespace Aplicacion_Almacen.Forms
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
            this.leftPanelContainer = new System.Windows.Forms.Panel();
            this.buttonStoreHouse = new System.Windows.Forms.Button();
            this.settingsManagerPanel = new System.Windows.Forms.Panel();
            this.buttonEnglishLanguage = new System.Windows.Forms.Button();
            this.buttonLanguageSpanish = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelProductsAndBatchsContainer = new System.Windows.Forms.Panel();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.buttonTruckerCarryBatch = new System.Windows.Forms.Button();
            this.buttonAssignProducts = new System.Windows.Forms.Button();
            this.buttonProductsManager = new System.Windows.Forms.Button();
            this.buttonBatchManager = new System.Windows.Forms.Button();
            this.panelFormsLoader = new System.Windows.Forms.Panel();
            this.labelWorkerName = new System.Windows.Forms.Label();
            this.labelUserJob = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.leftPanelContainer.SuspendLayout();
            this.settingsManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelProductsAndBatchsContainer.SuspendLayout();
            this.panelFormsLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanelContainer
            // 
            this.leftPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.leftPanelContainer.Controls.Add(this.buttonStoreHouse);
            this.leftPanelContainer.Controls.Add(this.settingsManagerPanel);
            this.leftPanelContainer.Controls.Add(this.pictureBox1);
            this.leftPanelContainer.Controls.Add(this.panelProductsAndBatchsContainer);
            this.leftPanelContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.leftPanelContainer.Name = "leftPanelContainer";
            this.leftPanelContainer.Size = new System.Drawing.Size(250, 568);
            this.leftPanelContainer.TabIndex = 0;
            // 
            // buttonStoreHouse
            // 
            this.buttonStoreHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStoreHouse.FlatAppearance.BorderSize = 0;
            this.buttonStoreHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStoreHouse.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStoreHouse.Location = new System.Drawing.Point(0, 110);
            this.buttonStoreHouse.Name = "buttonStoreHouse";
            this.buttonStoreHouse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonStoreHouse.Size = new System.Drawing.Size(250, 45);
            this.buttonStoreHouse.TabIndex = 2;
            this.buttonStoreHouse.Text = "Distribucion de productos y lotes";
            this.buttonStoreHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStoreHouse.UseVisualStyleBackColor = true;
            this.buttonStoreHouse.Click += new System.EventHandler(this.buttonStoreHouse_Click);
            // 
            // settingsManagerPanel
            // 
            this.settingsManagerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsManagerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.settingsManagerPanel.Controls.Add(this.buttonEnglishLanguage);
            this.settingsManagerPanel.Controls.Add(this.buttonLanguageSpanish);
            this.settingsManagerPanel.Location = new System.Drawing.Point(0, 501);
            this.settingsManagerPanel.Name = "settingsManagerPanel";
            this.settingsManagerPanel.Size = new System.Drawing.Size(250, 67);
            this.settingsManagerPanel.TabIndex = 1;
            // 
            // buttonEnglishLanguage
            // 
            this.buttonEnglishLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEnglishLanguage.FlatAppearance.BorderSize = 0;
            this.buttonEnglishLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnglishLanguage.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEnglishLanguage.Location = new System.Drawing.Point(0, 3);
            this.buttonEnglishLanguage.Name = "buttonEnglishLanguage";
            this.buttonEnglishLanguage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonEnglishLanguage.Size = new System.Drawing.Size(247, 29);
            this.buttonEnglishLanguage.TabIndex = 5;
            this.buttonEnglishLanguage.Text = "English";
            this.buttonEnglishLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnglishLanguage.UseVisualStyleBackColor = true;
            this.buttonEnglishLanguage.Click += new System.EventHandler(this.buttonEnglishLanguage_Click);
            // 
            // buttonLanguageSpanish
            // 
            this.buttonLanguageSpanish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLanguageSpanish.FlatAppearance.BorderSize = 0;
            this.buttonLanguageSpanish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLanguageSpanish.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLanguageSpanish.Location = new System.Drawing.Point(0, 35);
            this.buttonLanguageSpanish.Name = "buttonLanguageSpanish";
            this.buttonLanguageSpanish.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLanguageSpanish.Size = new System.Drawing.Size(244, 29);
            this.buttonLanguageSpanish.TabIndex = 4;
            this.buttonLanguageSpanish.Text = "Spanish";
            this.buttonLanguageSpanish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLanguageSpanish.UseVisualStyleBackColor = true;
            this.buttonLanguageSpanish.Click += new System.EventHandler(this.buttonLanguageSpanish_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Aplicacion_Almacen.Properties.Resources.Zblanca__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelProductsAndBatchsContainer
            // 
            this.panelProductsAndBatchsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonEmail);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonTruckerCarryBatch);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonAssignProducts);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonProductsManager);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonBatchManager);
            this.panelProductsAndBatchsContainer.Location = new System.Drawing.Point(0, 154);
            this.panelProductsAndBatchsContainer.Name = "panelProductsAndBatchsContainer";
            this.panelProductsAndBatchsContainer.Size = new System.Drawing.Size(250, 164);
            this.panelProductsAndBatchsContainer.TabIndex = 0;
            // 
            // buttonEmail
            // 
            this.buttonEmail.FlatAppearance.BorderSize = 0;
            this.buttonEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmail.Location = new System.Drawing.Point(0, 135);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonEmail.Size = new System.Drawing.Size(240, 26);
            this.buttonEmail.TabIndex = 7;
            this.buttonEmail.Text = "Emails";
            this.buttonEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // buttonTruckerCarryBatch
            // 
            this.buttonTruckerCarryBatch.FlatAppearance.BorderSize = 0;
            this.buttonTruckerCarryBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTruckerCarryBatch.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTruckerCarryBatch.Location = new System.Drawing.Point(0, 103);
            this.buttonTruckerCarryBatch.Name = "buttonTruckerCarryBatch";
            this.buttonTruckerCarryBatch.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTruckerCarryBatch.Size = new System.Drawing.Size(240, 26);
            this.buttonTruckerCarryBatch.TabIndex = 6;
            this.buttonTruckerCarryBatch.Text = "Asignar lote a camionero";
            this.buttonTruckerCarryBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTruckerCarryBatch.UseVisualStyleBackColor = true;
            this.buttonTruckerCarryBatch.Click += new System.EventHandler(this.buttonTruckerCarryBatch_Click);
            // 
            // buttonAssignProducts
            // 
            this.buttonAssignProducts.FlatAppearance.BorderSize = 0;
            this.buttonAssignProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAssignProducts.Location = new System.Drawing.Point(0, 71);
            this.buttonAssignProducts.Name = "buttonAssignProducts";
            this.buttonAssignProducts.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAssignProducts.Size = new System.Drawing.Size(240, 26);
            this.buttonAssignProducts.TabIndex = 5;
            this.buttonAssignProducts.Text = "Asignar Productos";
            this.buttonAssignProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssignProducts.UseVisualStyleBackColor = true;
            this.buttonAssignProducts.Click += new System.EventHandler(this.buttonAssignProducts_Click);
            // 
            // buttonProductsManager
            // 
            this.buttonProductsManager.FlatAppearance.BorderSize = 0;
            this.buttonProductsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductsManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProductsManager.Location = new System.Drawing.Point(0, 4);
            this.buttonProductsManager.Name = "buttonProductsManager";
            this.buttonProductsManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonProductsManager.Size = new System.Drawing.Size(240, 29);
            this.buttonProductsManager.TabIndex = 3;
            this.buttonProductsManager.Text = "Gestionar Productos";
            this.buttonProductsManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductsManager.UseVisualStyleBackColor = true;
            this.buttonProductsManager.Click += new System.EventHandler(this.buttonProductsManager_Click);
            // 
            // buttonBatchManager
            // 
            this.buttonBatchManager.FlatAppearance.BorderSize = 0;
            this.buttonBatchManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBatchManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBatchManager.Location = new System.Drawing.Point(0, 39);
            this.buttonBatchManager.Name = "buttonBatchManager";
            this.buttonBatchManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonBatchManager.Size = new System.Drawing.Size(240, 26);
            this.buttonBatchManager.TabIndex = 4;
            this.buttonBatchManager.Text = "Gestionar Lotes";
            this.buttonBatchManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBatchManager.UseVisualStyleBackColor = true;
            this.buttonBatchManager.Click += new System.EventHandler(this.buttonBatchManager_Click);
            // 
            // panelFormsLoader
            // 
            this.panelFormsLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormsLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.panelFormsLoader.Controls.Add(this.labelWorkerName);
            this.panelFormsLoader.Controls.Add(this.labelUserJob);
            this.panelFormsLoader.Controls.Add(this.pictureBox2);
            this.panelFormsLoader.Controls.Add(this.labelUserID);
            this.panelFormsLoader.Location = new System.Drawing.Point(256, 41);
            this.panelFormsLoader.Name = "panelFormsLoader";
            this.panelFormsLoader.Size = new System.Drawing.Size(753, 503);
            this.panelFormsLoader.TabIndex = 3;
            // 
            // labelWorkerName
            // 
            this.labelWorkerName.AutoSize = true;
            this.labelWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkerName.Location = new System.Drawing.Point(19, 16);
            this.labelWorkerName.Name = "labelWorkerName";
            this.labelWorkerName.Size = new System.Drawing.Size(69, 20);
            this.labelWorkerName.TabIndex = 4;
            this.labelWorkerName.Text = "Nombre:";
            // 
            // labelUserJob
            // 
            this.labelUserJob.AutoSize = true;
            this.labelUserJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserJob.Location = new System.Drawing.Point(19, 190);
            this.labelUserJob.Name = "labelUserJob";
            this.labelUserJob.Size = new System.Drawing.Size(60, 20);
            this.labelUserJob.TabIndex = 3;
            this.labelUserJob.Text = "Sector:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplicacion_Almacen.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(23, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(19, 164);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(30, 20);
            this.labelUserID.TabIndex = 0;
            this.labelUserID.Text = "ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1021, 568);
            this.Controls.Add(this.panelFormsLoader);
            this.Controls.Add(this.leftPanelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Aplicacion Almacen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanelContainer.ResumeLayout(false);
            this.settingsManagerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelProductsAndBatchsContainer.ResumeLayout(false);
            this.panelFormsLoader.ResumeLayout(false);
            this.panelFormsLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel leftPanelContainer;
        private System.Windows.Forms.Button buttonStoreHouse;
        private System.Windows.Forms.Panel settingsManagerPanel;
        private System.Windows.Forms.Button buttonLanguageSpanish;
        private System.Windows.Forms.Panel panelProductsAndBatchsContainer;
        private System.Windows.Forms.Button buttonAssignProducts;
        private System.Windows.Forms.Button buttonProductsManager;
        private System.Windows.Forms.Button buttonBatchManager;
        private System.Windows.Forms.Panel panelFormsLoader;
        private System.Windows.Forms.Button buttonTruckerCarryBatch;
        private System.Windows.Forms.Button buttonEnglishLanguage;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelUserJob;
        private System.Windows.Forms.Label labelWorkerName;
        private System.Windows.Forms.Button buttonEmail;
    }
}