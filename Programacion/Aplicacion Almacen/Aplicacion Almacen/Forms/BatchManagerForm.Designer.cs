namespace Aplicacion_Almacen.Forms
{
    partial class BatchManagerForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewBatch = new System.Windows.Forms.DataGridView();
            this.buttonSearcher = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonDestinationList = new System.Windows.Forms.Button();
            this.buttonViewMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 437);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(112, 23);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(71, 409);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(53, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 409);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewBatch
            // 
            this.dataGridViewBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewBatch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBatch.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewBatch.Name = "dataGridViewBatch";
            this.dataGridViewBatch.Size = new System.Drawing.Size(579, 169);
            this.dataGridViewBatch.TabIndex = 11;
            this.dataGridViewBatch.SelectionChanged += new System.EventHandler(this.dataGridViewBatch_SelectionChanged);
            // 
            // buttonSearcher
            // 
            this.buttonSearcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearcher.Location = new System.Drawing.Point(637, 440);
            this.buttonSearcher.Name = "buttonSearcher";
            this.buttonSearcher.Size = new System.Drawing.Size(92, 23);
            this.buttonSearcher.TabIndex = 44;
            this.buttonSearcher.Text = "Buscador";
            this.buttonSearcher.UseVisualStyleBackColor = true;
            this.buttonSearcher.Click += new System.EventHandler(this.buttonSearcher_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(14, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 45;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonDestinationList
            // 
            this.buttonDestinationList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDestinationList.Location = new System.Drawing.Point(539, 440);
            this.buttonDestinationList.Name = "buttonDestinationList";
            this.buttonDestinationList.Size = new System.Drawing.Size(92, 23);
            this.buttonDestinationList.TabIndex = 47;
            this.buttonDestinationList.Text = "Ver destinos";
            this.buttonDestinationList.UseVisualStyleBackColor = true;
            this.buttonDestinationList.Click += new System.EventHandler(this.buttonDestinationList_Click);
            // 
            // buttonViewMap
            // 
            this.buttonViewMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewMap.Location = new System.Drawing.Point(441, 440);
            this.buttonViewMap.Name = "buttonViewMap";
            this.buttonViewMap.Size = new System.Drawing.Size(92, 23);
            this.buttonViewMap.TabIndex = 89;
            this.buttonViewMap.Text = "Ver Mapa";
            this.buttonViewMap.UseVisualStyleBackColor = true;
            this.buttonViewMap.Click += new System.EventHandler(this.buttonViewMap_Click);
            // 
            // BatchManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.buttonViewMap);
            this.Controls.Add(this.buttonDestinationList);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonSearcher);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatchManagerForm";
            this.Text = "BatchManagerForm";
            this.Load += new System.EventHandler(this.BatchManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewBatch;
        private System.Windows.Forms.Button buttonSearcher;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonDestinationList;
        private System.Windows.Forms.Button buttonViewMap;
    }
}