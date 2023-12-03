namespace Aplicacion_Seguimiento.Forms
{
    partial class LocateBatchWithProductIDForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxBatchID = new System.Windows.Forms.TextBox();
            this.labelSearchByBatchID = new System.Windows.Forms.Label();
            this.dataGridViewSearchBatchByProductID = new System.Windows.Forms.DataGridView();
            this.buttonSearchByProductID = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchBatchByProductID)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBatchID
            // 
            this.textBoxBatchID.Location = new System.Drawing.Point(12, 336);
            this.textBoxBatchID.Name = "textBoxBatchID";
            this.textBoxBatchID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBatchID.TabIndex = 66;
            // 
            // labelSearchByBatchID
            // 
            this.labelSearchByBatchID.AutoSize = true;
            this.labelSearchByBatchID.Location = new System.Drawing.Point(12, 306);
            this.labelSearchByBatchID.Name = "labelSearchByBatchID";
            this.labelSearchByBatchID.Size = new System.Drawing.Size(64, 13);
            this.labelSearchByBatchID.TabIndex = 65;
            this.labelSearchByBatchID.Text = "ID Producto";
            // 
            // dataGridViewSearchBatchByProductID
            // 
            this.dataGridViewSearchBatchByProductID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewSearchBatchByProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchBatchByProductID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchBatchByProductID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSearchBatchByProductID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchBatchByProductID.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSearchBatchByProductID.EnableHeadersVisualStyles = false;
            this.dataGridViewSearchBatchByProductID.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewSearchBatchByProductID.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewSearchBatchByProductID.Name = "dataGridViewSearchBatchByProductID";
            this.dataGridViewSearchBatchByProductID.Size = new System.Drawing.Size(408, 228);
            this.dataGridViewSearchBatchByProductID.TabIndex = 64;
            // 
            // buttonSearchByProductID
            // 
            this.buttonSearchByProductID.Location = new System.Drawing.Point(12, 368);
            this.buttonSearchByProductID.Name = "buttonSearchByProductID";
            this.buttonSearchByProductID.Size = new System.Drawing.Size(101, 23);
            this.buttonSearchByProductID.TabIndex = 63;
            this.buttonSearchByProductID.Text = "Buscar";
            this.buttonSearchByProductID.UseVisualStyleBackColor = true;
            this.buttonSearchByProductID.Click += new System.EventHandler(this.buttonSearchByProductID_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 10);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 62;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // LocateBatchWithProductID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(709, 403);
            this.Controls.Add(this.textBoxBatchID);
            this.Controls.Add(this.labelSearchByBatchID);
            this.Controls.Add(this.dataGridViewSearchBatchByProductID);
            this.Controls.Add(this.buttonSearchByProductID);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocateBatchWithProductID";
            this.Text = "LocateBatchWithProductID";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchBatchByProductID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBatchID;
        private System.Windows.Forms.Label labelSearchByBatchID;
        private System.Windows.Forms.DataGridView dataGridViewSearchBatchByProductID;
        private System.Windows.Forms.Button buttonSearchByProductID;
        private System.Windows.Forms.Button buttonBackToMainMenu;
    }
}