namespace Aplicacion_Seguimiento.Forms
{
    partial class LocateBatchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonSearchByBatchID = new System.Windows.Forms.Button();
            this.dataGridViewSearchByBatchID = new System.Windows.Forms.DataGridView();
            this.labelSearchByBatchID = new System.Windows.Forms.Label();
            this.textBoxBatchID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchByBatchID)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 57;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonSearchByBatchID
            // 
            this.buttonSearchByBatchID.Location = new System.Drawing.Point(12, 383);
            this.buttonSearchByBatchID.Name = "buttonSearchByBatchID";
            this.buttonSearchByBatchID.Size = new System.Drawing.Size(101, 23);
            this.buttonSearchByBatchID.TabIndex = 58;
            this.buttonSearchByBatchID.Text = "Buscar";
            this.buttonSearchByBatchID.UseVisualStyleBackColor = true;
            this.buttonSearchByBatchID.Click += new System.EventHandler(this.buttonSearchByBatchID_Click);
            // 
            // dataGridViewSearchByBatchID
            // 
            this.dataGridViewSearchByBatchID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewSearchByBatchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchByBatchID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchByBatchID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearchByBatchID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchByBatchID.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSearchByBatchID.EnableHeadersVisualStyles = false;
            this.dataGridViewSearchByBatchID.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewSearchByBatchID.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewSearchByBatchID.Name = "dataGridViewSearchByBatchID";
            this.dataGridViewSearchByBatchID.Size = new System.Drawing.Size(408, 228);
            this.dataGridViewSearchByBatchID.TabIndex = 59;
            // 
            // labelSearchByBatchID
            // 
            this.labelSearchByBatchID.AutoSize = true;
            this.labelSearchByBatchID.Location = new System.Drawing.Point(9, 326);
            this.labelSearchByBatchID.Name = "labelSearchByBatchID";
            this.labelSearchByBatchID.Size = new System.Drawing.Size(42, 13);
            this.labelSearchByBatchID.TabIndex = 60;
            this.labelSearchByBatchID.Text = "ID Lote";
            // 
            // textBoxBatchID
            // 
            this.textBoxBatchID.Location = new System.Drawing.Point(12, 352);
            this.textBoxBatchID.Name = "textBoxBatchID";
            this.textBoxBatchID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBatchID.TabIndex = 61;
            // 
            // LocateBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(725, 442);
            this.Controls.Add(this.textBoxBatchID);
            this.Controls.Add(this.labelSearchByBatchID);
            this.Controls.Add(this.dataGridViewSearchByBatchID);
            this.Controls.Add(this.buttonSearchByBatchID);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocateBatchForm";
            this.Text = "LocateBatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchByBatchID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonSearchByBatchID;
        private System.Windows.Forms.DataGridView dataGridViewSearchByBatchID;
        private System.Windows.Forms.Label labelSearchByBatchID;
        private System.Windows.Forms.TextBox textBoxBatchID;
    }
}