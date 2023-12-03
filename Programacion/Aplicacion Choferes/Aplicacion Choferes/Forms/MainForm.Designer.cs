namespace Aplicacion_Choferes.Forms
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
            this.panelFormsLoader = new System.Windows.Forms.Panel();
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.buttonTruckersManagement = new System.Windows.Forms.Button();
            this.buttonAssignedTruckToTrucker = new System.Windows.Forms.Button();
            this.buttonDestinations = new System.Windows.Forms.Button();
            this.buttonProductsManager = new System.Windows.Forms.Button();
            this.buttonShippments = new System.Windows.Forms.Button();
            this.leftPanelContainer = new System.Windows.Forms.Panel();
            this.settingsManagerPanel = new System.Windows.Forms.Panel();
            this.buttonEnglishLanguage = new System.Windows.Forms.Button();
            this.buttonLanguageSpanish = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTruckersManagementContainer = new System.Windows.Forms.Panel();
            this.buttonTruckerCarryManagement = new System.Windows.Forms.Button();
            this.labelTruckerID = new System.Windows.Forms.Label();
            this.panelFormsLoader.SuspendLayout();
            this.leftPanelContainer.SuspendLayout();
            this.settingsManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTruckersManagementContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormsLoader
            // 
            this.panelFormsLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFormsLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.panelFormsLoader.Controls.Add(this.webBrowserMap);
            this.panelFormsLoader.Location = new System.Drawing.Point(258, 26);
            this.panelFormsLoader.Name = "panelFormsLoader";
            this.panelFormsLoader.Size = new System.Drawing.Size(752, 544);
            this.panelFormsLoader.TabIndex = 5;
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.Size = new System.Drawing.Size(752, 544);
            this.webBrowserMap.TabIndex = 0;
            this.webBrowserMap.Url = new System.Uri("https://www.bing.com/maps?cp=-34.884241~-56.155243&lvl=11.0", System.UriKind.Absolute);
            // 
            // buttonTruckersManagement
            // 
            this.buttonTruckersManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTruckersManagement.FlatAppearance.BorderSize = 0;
            this.buttonTruckersManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTruckersManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTruckersManagement.Location = new System.Drawing.Point(0, 80);
            this.buttonTruckersManagement.Name = "buttonTruckersManagement";
            this.buttonTruckersManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTruckersManagement.Size = new System.Drawing.Size(250, 45);
            this.buttonTruckersManagement.TabIndex = 2;
            this.buttonTruckersManagement.Text = "Camiones y lotes";
            this.buttonTruckersManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTruckersManagement.UseVisualStyleBackColor = true;
            this.buttonTruckersManagement.Click += new System.EventHandler(this.buttonTruckersManagement_Click);
            // 
            // buttonAssignedTruckToTrucker
            // 
            this.buttonAssignedTruckToTrucker.FlatAppearance.BorderSize = 0;
            this.buttonAssignedTruckToTrucker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignedTruckToTrucker.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAssignedTruckToTrucker.Location = new System.Drawing.Point(0, 135);
            this.buttonAssignedTruckToTrucker.Name = "buttonAssignedTruckToTrucker";
            this.buttonAssignedTruckToTrucker.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAssignedTruckToTrucker.Size = new System.Drawing.Size(240, 26);
            this.buttonAssignedTruckToTrucker.TabIndex = 6;
            this.buttonAssignedTruckToTrucker.Text = "Camion asignado";
            this.buttonAssignedTruckToTrucker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssignedTruckToTrucker.UseVisualStyleBackColor = true;
            this.buttonAssignedTruckToTrucker.Click += new System.EventHandler(this.buttonAssignedTruckToTrucker_Click);
            // 
            // buttonDestinations
            // 
            this.buttonDestinations.FlatAppearance.BorderSize = 0;
            this.buttonDestinations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDestinations.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDestinations.Location = new System.Drawing.Point(0, 103);
            this.buttonDestinations.Name = "buttonDestinations";
            this.buttonDestinations.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonDestinations.Size = new System.Drawing.Size(240, 26);
            this.buttonDestinations.TabIndex = 5;
            this.buttonDestinations.Text = "Destinos";
            this.buttonDestinations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDestinations.UseVisualStyleBackColor = true;
            this.buttonDestinations.Click += new System.EventHandler(this.buttonDestinations_Click);
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
            this.buttonProductsManager.Text = "Gestionar Envios";
            this.buttonProductsManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductsManager.UseVisualStyleBackColor = true;
            this.buttonProductsManager.Click += new System.EventHandler(this.buttonProductsManager_Click);
            // 
            // buttonShippments
            // 
            this.buttonShippments.FlatAppearance.BorderSize = 0;
            this.buttonShippments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShippments.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonShippments.Location = new System.Drawing.Point(0, 39);
            this.buttonShippments.Name = "buttonShippments";
            this.buttonShippments.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonShippments.Size = new System.Drawing.Size(240, 26);
            this.buttonShippments.TabIndex = 4;
            this.buttonShippments.Text = "Recorridos";
            this.buttonShippments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShippments.UseVisualStyleBackColor = true;
            this.buttonShippments.Click += new System.EventHandler(this.buttonShippments_Click);
            // 
            // leftPanelContainer
            // 
            this.leftPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.leftPanelContainer.Controls.Add(this.buttonTruckersManagement);
            this.leftPanelContainer.Controls.Add(this.settingsManagerPanel);
            this.leftPanelContainer.Controls.Add(this.pictureBox1);
            this.leftPanelContainer.Controls.Add(this.panelTruckersManagementContainer);
            this.leftPanelContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.leftPanelContainer.Name = "leftPanelContainer";
            this.leftPanelContainer.Size = new System.Drawing.Size(250, 580);
            this.leftPanelContainer.TabIndex = 4;
            // 
            // settingsManagerPanel
            // 
            this.settingsManagerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.settingsManagerPanel.Controls.Add(this.buttonEnglishLanguage);
            this.settingsManagerPanel.Controls.Add(this.buttonLanguageSpanish);
            this.settingsManagerPanel.Location = new System.Drawing.Point(0, 505);
            this.settingsManagerPanel.Name = "settingsManagerPanel";
            this.settingsManagerPanel.Size = new System.Drawing.Size(250, 72);
            this.settingsManagerPanel.TabIndex = 1;
            // 
            // buttonEnglishLanguage
            // 
            this.buttonEnglishLanguage.FlatAppearance.BorderSize = 0;
            this.buttonEnglishLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnglishLanguage.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEnglishLanguage.Location = new System.Drawing.Point(3, -1);
            this.buttonEnglishLanguage.Name = "buttonEnglishLanguage";
            this.buttonEnglishLanguage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonEnglishLanguage.Size = new System.Drawing.Size(244, 29);
            this.buttonEnglishLanguage.TabIndex = 7;
            this.buttonEnglishLanguage.Text = "English";
            this.buttonEnglishLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnglishLanguage.UseVisualStyleBackColor = true;
            this.buttonEnglishLanguage.Click += new System.EventHandler(this.buttonEnglishLanguage_Click);
            // 
            // buttonLanguageSpanish
            // 
            this.buttonLanguageSpanish.FlatAppearance.BorderSize = 0;
            this.buttonLanguageSpanish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLanguageSpanish.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLanguageSpanish.Location = new System.Drawing.Point(3, 37);
            this.buttonLanguageSpanish.Name = "buttonLanguageSpanish";
            this.buttonLanguageSpanish.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLanguageSpanish.Size = new System.Drawing.Size(244, 28);
            this.buttonLanguageSpanish.TabIndex = 6;
            this.buttonLanguageSpanish.Text = "Spanish";
            this.buttonLanguageSpanish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLanguageSpanish.UseVisualStyleBackColor = true;
            this.buttonLanguageSpanish.Click += new System.EventHandler(this.buttonLanguageSpanish_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Aplicacion_Choferes.Properties.Resources.ZENNETLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTruckersManagementContainer
            // 
            this.panelTruckersManagementContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.panelTruckersManagementContainer.Controls.Add(this.buttonTruckerCarryManagement);
            this.panelTruckersManagementContainer.Controls.Add(this.buttonAssignedTruckToTrucker);
            this.panelTruckersManagementContainer.Controls.Add(this.buttonDestinations);
            this.panelTruckersManagementContainer.Controls.Add(this.buttonProductsManager);
            this.panelTruckersManagementContainer.Controls.Add(this.buttonShippments);
            this.panelTruckersManagementContainer.Location = new System.Drawing.Point(0, 131);
            this.panelTruckersManagementContainer.Name = "panelTruckersManagementContainer";
            this.panelTruckersManagementContainer.Size = new System.Drawing.Size(250, 167);
            this.panelTruckersManagementContainer.TabIndex = 0;
            // 
            // buttonTruckerCarryManagement
            // 
            this.buttonTruckerCarryManagement.FlatAppearance.BorderSize = 0;
            this.buttonTruckerCarryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTruckerCarryManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTruckerCarryManagement.Location = new System.Drawing.Point(0, 71);
            this.buttonTruckerCarryManagement.Name = "buttonTruckerCarryManagement";
            this.buttonTruckerCarryManagement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTruckerCarryManagement.Size = new System.Drawing.Size(240, 26);
            this.buttonTruckerCarryManagement.TabIndex = 7;
            this.buttonTruckerCarryManagement.Text = "Lotes asignados a camion";
            this.buttonTruckerCarryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTruckerCarryManagement.UseVisualStyleBackColor = true;
            this.buttonTruckerCarryManagement.Click += new System.EventHandler(this.buttonTruckerCarryManagement_Click);
            // 
            // labelTruckerID
            // 
            this.labelTruckerID.AutoSize = true;
            this.labelTruckerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelTruckerID.Location = new System.Drawing.Point(256, -1);
            this.labelTruckerID.Name = "labelTruckerID";
            this.labelTruckerID.Size = new System.Drawing.Size(97, 24);
            this.labelTruckerID.TabIndex = 6;
            this.labelTruckerID.Text = "TruckerID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1022, 580);
            this.Controls.Add(this.labelTruckerID);
            this.Controls.Add(this.panelFormsLoader);
            this.Controls.Add(this.leftPanelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Aplicacion Choferes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelFormsLoader.ResumeLayout(false);
            this.leftPanelContainer.ResumeLayout(false);
            this.settingsManagerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTruckersManagementContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFormsLoader;
        private System.Windows.Forms.Button buttonTruckersManagement;
        private System.Windows.Forms.Button buttonAssignedTruckToTrucker;
        private System.Windows.Forms.Button buttonDestinations;
        private System.Windows.Forms.Button buttonProductsManager;
        private System.Windows.Forms.Button buttonShippments;
        private System.Windows.Forms.Panel leftPanelContainer;
        private System.Windows.Forms.Panel settingsManagerPanel;
        private System.Windows.Forms.Panel panelTruckersManagementContainer;
        private System.Windows.Forms.Button buttonTruckerCarryManagement;
        private System.Windows.Forms.Button buttonEnglishLanguage;
        private System.Windows.Forms.Button buttonLanguageSpanish;
        private System.Windows.Forms.WebBrowser webBrowserMap;
        private System.Windows.Forms.Label labelTruckerID;
    }
}