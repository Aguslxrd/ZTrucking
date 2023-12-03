namespace BackOffice
{
    partial class TruckManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAddTruck = new System.Windows.Forms.Button();
            this.buttonRefreshTruck = new System.Windows.Forms.Button();
            this.dataGridViewAddTruck = new System.Windows.Forms.DataGridView();
            this.labelAddTruck = new System.Windows.Forms.Label();
            this.labelAssignTruck = new System.Windows.Forms.Label();
            this.dataGridViewAssignTruck = new System.Windows.Forms.DataGridView();
            this.buttonRefreshAssignTrucker = new System.Windows.Forms.Button();
            this.buttonDeleteAssignedTruck = new System.Windows.Forms.Button();
            this.buttonAddAssignedTruck = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDeleteTruck = new System.Windows.Forms.Button();
            this.panelSeparator = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTruck
            // 
            this.buttonAddTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTruck.Location = new System.Drawing.Point(425, 516);
            this.buttonAddTruck.Name = "buttonAddTruck";
            this.buttonAddTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonAddTruck.TabIndex = 1;
            this.buttonAddTruck.Text = "Agregar";
            this.buttonAddTruck.UseVisualStyleBackColor = true;
            this.buttonAddTruck.Click += new System.EventHandler(this.buttonAddTruck_Click);
            // 
            // buttonRefreshTruck
            // 
            this.buttonRefreshTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshTruck.Location = new System.Drawing.Point(684, 516);
            this.buttonRefreshTruck.Name = "buttonRefreshTruck";
            this.buttonRefreshTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshTruck.TabIndex = 3;
            this.buttonRefreshTruck.Text = "Recargar";
            this.buttonRefreshTruck.UseVisualStyleBackColor = true;
            this.buttonRefreshTruck.Click += new System.EventHandler(this.buttonRefreshTruck_Click);
            // 
            // dataGridViewAddTruck
            // 
            this.dataGridViewAddTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAddTruck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAddTruck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAddTruck.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddTruck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewAddTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddTruck.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewAddTruck.EnableHeadersVisualStyles = false;
            this.dataGridViewAddTruck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAddTruck.Location = new System.Drawing.Point(425, 297);
            this.dataGridViewAddTruck.Name = "dataGridViewAddTruck";
            this.dataGridViewAddTruck.Size = new System.Drawing.Size(327, 150);
            this.dataGridViewAddTruck.TabIndex = 4;
            // 
            // labelAddTruck
            // 
            this.labelAddTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddTruck.AutoSize = true;
            this.labelAddTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.labelAddTruck.Location = new System.Drawing.Point(534, 251);
            this.labelAddTruck.Name = "labelAddTruck";
            this.labelAddTruck.Size = new System.Drawing.Size(127, 20);
            this.labelAddTruck.TabIndex = 7;
            this.labelAddTruck.Text = "Agregar camion";
            // 
            // labelAssignTruck
            // 
            this.labelAssignTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAssignTruck.AutoSize = true;
            this.labelAssignTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.labelAssignTruck.Location = new System.Drawing.Point(94, 251);
            this.labelAssignTruck.Name = "labelAssignTruck";
            this.labelAssignTruck.Size = new System.Drawing.Size(125, 20);
            this.labelAssignTruck.TabIndex = 14;
            this.labelAssignTruck.Text = "Asignar camion";
            // 
            // dataGridViewAssignTruck
            // 
            this.dataGridViewAssignTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewAssignTruck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAssignTruck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAssignTruck.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAssignTruck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewAssignTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAssignTruck.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewAssignTruck.EnableHeadersVisualStyles = false;
            this.dataGridViewAssignTruck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAssignTruck.Location = new System.Drawing.Point(26, 297);
            this.dataGridViewAssignTruck.Name = "dataGridViewAssignTruck";
            this.dataGridViewAssignTruck.Size = new System.Drawing.Size(297, 150);
            this.dataGridViewAssignTruck.TabIndex = 11;
            // 
            // buttonRefreshAssignTrucker
            // 
            this.buttonRefreshAssignTrucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefreshAssignTrucker.Location = new System.Drawing.Point(211, 516);
            this.buttonRefreshAssignTrucker.Name = "buttonRefreshAssignTrucker";
            this.buttonRefreshAssignTrucker.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshAssignTrucker.TabIndex = 10;
            this.buttonRefreshAssignTrucker.Text = "Recargar";
            this.buttonRefreshAssignTrucker.UseVisualStyleBackColor = true;
            this.buttonRefreshAssignTrucker.Click += new System.EventHandler(this.buttonRefreshAssignTrucker_Click);
            // 
            // buttonDeleteAssignedTruck
            // 
            this.buttonDeleteAssignedTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteAssignedTruck.Location = new System.Drawing.Point(120, 516);
            this.buttonDeleteAssignedTruck.Name = "buttonDeleteAssignedTruck";
            this.buttonDeleteAssignedTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteAssignedTruck.TabIndex = 9;
            this.buttonDeleteAssignedTruck.Text = "Eliminar";
            this.buttonDeleteAssignedTruck.UseVisualStyleBackColor = true;
            this.buttonDeleteAssignedTruck.Click += new System.EventHandler(this.buttonDeleteAssignedTruck_Click);
            // 
            // buttonAddAssignedTruck
            // 
            this.buttonAddAssignedTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddAssignedTruck.Location = new System.Drawing.Point(26, 516);
            this.buttonAddAssignedTruck.Name = "buttonAddAssignedTruck";
            this.buttonAddAssignedTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonAddAssignedTruck.TabIndex = 8;
            this.buttonAddAssignedTruck.Text = "Agregar";
            this.buttonAddAssignedTruck.UseVisualStyleBackColor = true;
            this.buttonAddAssignedTruck.Click += new System.EventHandler(this.buttonAddAssignedTruck_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 26);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(499, 516);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(68, 26);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDeleteTruck
            // 
            this.buttonDeleteTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteTruck.Location = new System.Drawing.Point(593, 516);
            this.buttonDeleteTruck.Name = "buttonDeleteTruck";
            this.buttonDeleteTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteTruck.TabIndex = 2;
            this.buttonDeleteTruck.Text = "Eliminar";
            this.buttonDeleteTruck.UseVisualStyleBackColor = true;
            this.buttonDeleteTruck.Click += new System.EventHandler(this.buttonDeleteTruck_Click);
            // 
            // panelSeparator
            // 
            this.panelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.panelSeparator.Location = new System.Drawing.Point(385, 1);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(3, 557);
            this.panelSeparator.TabIndex = 83;
            // 
            // TruckManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAssignTruck);
            this.Controls.Add(this.dataGridViewAssignTruck);
            this.Controls.Add(this.buttonRefreshAssignTrucker);
            this.Controls.Add(this.buttonDeleteAssignedTruck);
            this.Controls.Add(this.buttonAddAssignedTruck);
            this.Controls.Add(this.labelAddTruck);
            this.Controls.Add(this.dataGridViewAddTruck);
            this.Controls.Add(this.buttonRefreshTruck);
            this.Controls.Add(this.buttonDeleteTruck);
            this.Controls.Add(this.buttonAddTruck);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TruckManagerForm";
            this.Text = "UserManagerForm";
            this.Load += new System.EventHandler(this.TruckManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignTruck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddTruck;
        private System.Windows.Forms.Button buttonRefreshTruck;
        private System.Windows.Forms.DataGridView dataGridViewAddTruck;
        private System.Windows.Forms.Label labelAddTruck;
        private System.Windows.Forms.Label labelAssignTruck;
        private System.Windows.Forms.DataGridView dataGridViewAssignTruck;
        private System.Windows.Forms.Button buttonRefreshAssignTrucker;
        private System.Windows.Forms.Button buttonDeleteAssignedTruck;
        private System.Windows.Forms.Button buttonAddAssignedTruck;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDeleteTruck;
        private System.Windows.Forms.Panel panelSeparator;
    }
}