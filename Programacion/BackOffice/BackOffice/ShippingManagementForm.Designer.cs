namespace BackOffice
{
    partial class ShippingManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewShippingManagement = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefreshShipps = new System.Windows.Forms.Button();
            this.buttonDeleteShipp = new System.Windows.Forms.Button();
            this.buttonAddShipp = new System.Windows.Forms.Button();
            this.dataGridViewCarry = new System.Windows.Forms.DataGridView();
            this.buttonRefreshCarry = new System.Windows.Forms.Button();
            this.buttonDeleteCarry = new System.Windows.Forms.Button();
            this.buttonAddCarry = new System.Windows.Forms.Button();
            this.buttonEditCarry = new System.Windows.Forms.Button();
            this.panelSeparator = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShippingManagement
            // 
            this.dataGridViewShippingManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewShippingManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewShippingManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShippingManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShippingManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewShippingManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShippingManagement.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewShippingManagement.EnableHeadersVisualStyles = false;
            this.dataGridViewShippingManagement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewShippingManagement.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewShippingManagement.Name = "dataGridViewShippingManagement";
            this.dataGridViewShippingManagement.Size = new System.Drawing.Size(324, 228);
            this.dataGridViewShippingManagement.TabIndex = 54;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 26);
            this.buttonBack.TabIndex = 52;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefreshShipps
            // 
            this.buttonRefreshShipps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefreshShipps.Location = new System.Drawing.Point(160, 500);
            this.buttonRefreshShipps.Name = "buttonRefreshShipps";
            this.buttonRefreshShipps.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshShipps.TabIndex = 51;
            this.buttonRefreshShipps.Text = "Recargar";
            this.buttonRefreshShipps.UseVisualStyleBackColor = true;
            this.buttonRefreshShipps.Click += new System.EventHandler(this.buttonRefreshShipps_Click);
            // 
            // buttonDeleteShipp
            // 
            this.buttonDeleteShipp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteShipp.Location = new System.Drawing.Point(86, 500);
            this.buttonDeleteShipp.Name = "buttonDeleteShipp";
            this.buttonDeleteShipp.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteShipp.TabIndex = 50;
            this.buttonDeleteShipp.Text = "Eliminar";
            this.buttonDeleteShipp.UseVisualStyleBackColor = true;
            this.buttonDeleteShipp.Click += new System.EventHandler(this.buttonDeleteShipp_Click);
            // 
            // buttonAddShipp
            // 
            this.buttonAddShipp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddShipp.Location = new System.Drawing.Point(12, 500);
            this.buttonAddShipp.Name = "buttonAddShipp";
            this.buttonAddShipp.Size = new System.Drawing.Size(68, 26);
            this.buttonAddShipp.TabIndex = 49;
            this.buttonAddShipp.Text = "Agregar";
            this.buttonAddShipp.UseVisualStyleBackColor = true;
            this.buttonAddShipp.Click += new System.EventHandler(this.buttonAddShipp_Click);
            // 
            // dataGridViewCarry
            // 
            this.dataGridViewCarry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCarry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewCarry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCarry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCarry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCarry.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCarry.EnableHeadersVisualStyles = false;
            this.dataGridViewCarry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewCarry.Location = new System.Drawing.Point(387, 69);
            this.dataGridViewCarry.Name = "dataGridViewCarry";
            this.dataGridViewCarry.Size = new System.Drawing.Size(358, 228);
            this.dataGridViewCarry.TabIndex = 64;
            // 
            // buttonRefreshCarry
            // 
            this.buttonRefreshCarry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshCarry.Location = new System.Drawing.Point(535, 499);
            this.buttonRefreshCarry.Name = "buttonRefreshCarry";
            this.buttonRefreshCarry.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshCarry.TabIndex = 69;
            this.buttonRefreshCarry.Text = "Recargar";
            this.buttonRefreshCarry.UseVisualStyleBackColor = true;
            this.buttonRefreshCarry.Click += new System.EventHandler(this.buttonRefreshCarry_Click);
            // 
            // buttonDeleteCarry
            // 
            this.buttonDeleteCarry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteCarry.Location = new System.Drawing.Point(461, 499);
            this.buttonDeleteCarry.Name = "buttonDeleteCarry";
            this.buttonDeleteCarry.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteCarry.TabIndex = 68;
            this.buttonDeleteCarry.Text = "Eliminar";
            this.buttonDeleteCarry.UseVisualStyleBackColor = true;
            this.buttonDeleteCarry.Click += new System.EventHandler(this.buttonDeleteCarry_Click);
            // 
            // buttonAddCarry
            // 
            this.buttonAddCarry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCarry.Location = new System.Drawing.Point(387, 499);
            this.buttonAddCarry.Name = "buttonAddCarry";
            this.buttonAddCarry.Size = new System.Drawing.Size(68, 26);
            this.buttonAddCarry.TabIndex = 67;
            this.buttonAddCarry.Text = "Agregar";
            this.buttonAddCarry.UseVisualStyleBackColor = true;
            this.buttonAddCarry.Click += new System.EventHandler(this.buttonAddCarry_Click);
            // 
            // buttonEditCarry
            // 
            this.buttonEditCarry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditCarry.Location = new System.Drawing.Point(609, 499);
            this.buttonEditCarry.Name = "buttonEditCarry";
            this.buttonEditCarry.Size = new System.Drawing.Size(68, 26);
            this.buttonEditCarry.TabIndex = 70;
            this.buttonEditCarry.Text = "Editar";
            this.buttonEditCarry.UseVisualStyleBackColor = true;
            this.buttonEditCarry.Click += new System.EventHandler(this.buttonEditCarry_Click);
            // 
            // panelSeparator
            // 
            this.panelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.panelSeparator.Location = new System.Drawing.Point(359, 1);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(3, 557);
            this.panelSeparator.TabIndex = 81;
            // 
            // ShippingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.buttonEditCarry);
            this.Controls.Add(this.buttonRefreshCarry);
            this.Controls.Add(this.buttonDeleteCarry);
            this.Controls.Add(this.buttonAddCarry);
            this.Controls.Add(this.dataGridViewCarry);
            this.Controls.Add(this.dataGridViewShippingManagement);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefreshShipps);
            this.Controls.Add(this.buttonDeleteShipp);
            this.Controls.Add(this.buttonAddShipp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShippingManagementForm";
            this.Text = "ShippingManagementForm";
            this.Load += new System.EventHandler(this.ShippingManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewShippingManagement;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefreshShipps;
        private System.Windows.Forms.Button buttonDeleteShipp;
        private System.Windows.Forms.Button buttonAddShipp;
        private System.Windows.Forms.DataGridView dataGridViewCarry;
        private System.Windows.Forms.Button buttonRefreshCarry;
        private System.Windows.Forms.Button buttonDeleteCarry;
        private System.Windows.Forms.Button buttonAddCarry;
        private System.Windows.Forms.Button buttonEditCarry;
        private System.Windows.Forms.Panel panelSeparator;
    }
}