namespace Aplicacion_Seguimiento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelFormsLoader = new System.Windows.Forms.Panel();
            this.leftPanelContainer = new System.Windows.Forms.Panel();
            this.buttonMyOrders = new System.Windows.Forms.Button();
            this.settingsManagerPanel = new System.Windows.Forms.Panel();
            this.buttonEnglishLanguage = new System.Windows.Forms.Button();
            this.buttonLanguageSpanish = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMyOrders = new System.Windows.Forms.Panel();
            this.buttonLocateProduct = new System.Windows.Forms.Button();
            this.buttonTrackBatch = new System.Windows.Forms.Button();
            this.leftPanelContainer.SuspendLayout();
            this.settingsManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMyOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormsLoader
            // 
            this.panelFormsLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormsLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.panelFormsLoader.Location = new System.Drawing.Point(252, 25);
            this.panelFormsLoader.Name = "panelFormsLoader";
            this.panelFormsLoader.Size = new System.Drawing.Size(773, 559);
            this.panelFormsLoader.TabIndex = 5;
            // 
            // leftPanelContainer
            // 
            this.leftPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.leftPanelContainer.Controls.Add(this.buttonMyOrders);
            this.leftPanelContainer.Controls.Add(this.settingsManagerPanel);
            this.leftPanelContainer.Controls.Add(this.pictureBox1);
            this.leftPanelContainer.Controls.Add(this.panelMyOrders);
            this.leftPanelContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.leftPanelContainer.Name = "leftPanelContainer";
            this.leftPanelContainer.Size = new System.Drawing.Size(250, 568);
            this.leftPanelContainer.TabIndex = 4;
            // 
            // buttonMyOrders
            // 
            this.buttonMyOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMyOrders.FlatAppearance.BorderSize = 0;
            this.buttonMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMyOrders.Location = new System.Drawing.Point(0, 100);
            this.buttonMyOrders.Name = "buttonMyOrders";
            this.buttonMyOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMyOrders.Size = new System.Drawing.Size(250, 45);
            this.buttonMyOrders.TabIndex = 2;
            this.buttonMyOrders.Text = "Mis pedidos";
            this.buttonMyOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyOrders.UseVisualStyleBackColor = true;
            this.buttonMyOrders.Click += new System.EventHandler(this.buttonMyOrders_Click);
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
            this.pictureBox1.Image = global::Aplicacion_Seguimiento.Properties.Resources.Zblanca__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelMyOrders
            // 
            this.panelMyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.panelMyOrders.Controls.Add(this.buttonLocateProduct);
            this.panelMyOrders.Controls.Add(this.buttonTrackBatch);
            this.panelMyOrders.Location = new System.Drawing.Point(0, 145);
            this.panelMyOrders.Name = "panelMyOrders";
            this.panelMyOrders.Size = new System.Drawing.Size(250, 68);
            this.panelMyOrders.TabIndex = 0;
            // 
            // buttonLocateProduct
            // 
            this.buttonLocateProduct.FlatAppearance.BorderSize = 0;
            this.buttonLocateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocateProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLocateProduct.Location = new System.Drawing.Point(0, 35);
            this.buttonLocateProduct.Name = "buttonLocateProduct";
            this.buttonLocateProduct.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLocateProduct.Size = new System.Drawing.Size(240, 30);
            this.buttonLocateProduct.TabIndex = 4;
            this.buttonLocateProduct.Text = "Localizar Producto";
            this.buttonLocateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLocateProduct.UseVisualStyleBackColor = true;
            this.buttonLocateProduct.Click += new System.EventHandler(this.buttonLocateProduct_Click);
            // 
            // buttonTrackBatch
            // 
            this.buttonTrackBatch.FlatAppearance.BorderSize = 0;
            this.buttonTrackBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrackBatch.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTrackBatch.Location = new System.Drawing.Point(0, 3);
            this.buttonTrackBatch.Name = "buttonTrackBatch";
            this.buttonTrackBatch.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTrackBatch.Size = new System.Drawing.Size(240, 30);
            this.buttonTrackBatch.TabIndex = 3;
            this.buttonTrackBatch.Text = "Localizar lote";
            this.buttonTrackBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTrackBatch.UseVisualStyleBackColor = true;
            this.buttonTrackBatch.Click += new System.EventHandler(this.buttonTrackBatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1021, 568);
            this.Controls.Add(this.panelFormsLoader);
            this.Controls.Add(this.leftPanelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aplicacion Seguimiento";
            this.leftPanelContainer.ResumeLayout(false);
            this.settingsManagerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMyOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormsLoader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel leftPanelContainer;
        private System.Windows.Forms.Button buttonMyOrders;
        private System.Windows.Forms.Panel settingsManagerPanel;
        private System.Windows.Forms.Button buttonEnglishLanguage;
        private System.Windows.Forms.Button buttonLanguageSpanish;
        private System.Windows.Forms.Panel panelMyOrders;
        private System.Windows.Forms.Button buttonTrackBatch;
        private System.Windows.Forms.Button buttonLocateProduct;
    }
}

