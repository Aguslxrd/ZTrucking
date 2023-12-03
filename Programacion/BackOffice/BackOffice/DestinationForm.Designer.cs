namespace BackOffice
{
    partial class DestinationForm
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
            this.dataGridViewDestinations = new System.Windows.Forms.DataGridView();
            this.buttonEditDestination = new System.Windows.Forms.Button();
            this.buttonRefreshDestination = new System.Windows.Forms.Button();
            this.buttonDeleteDestination = new System.Windows.Forms.Button();
            this.buttonAddDestination = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonShowMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDestinations
            // 
            this.dataGridViewDestinations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewDestinations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDestinations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDestinations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDestinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDestinations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDestinations.EnableHeadersVisualStyles = false;
            this.dataGridViewDestinations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewDestinations.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewDestinations.Name = "dataGridViewDestinations";
            this.dataGridViewDestinations.Size = new System.Drawing.Size(722, 228);
            this.dataGridViewDestinations.TabIndex = 55;
            this.dataGridViewDestinations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestinations_CellClick);
            this.dataGridViewDestinations.SelectionChanged += new System.EventHandler(this.dataGridViewDestinations_SelectionChanged);
            // 
            // buttonEditDestination
            // 
            this.buttonEditDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditDestination.Location = new System.Drawing.Point(234, 485);
            this.buttonEditDestination.Name = "buttonEditDestination";
            this.buttonEditDestination.Size = new System.Drawing.Size(68, 26);
            this.buttonEditDestination.TabIndex = 54;
            this.buttonEditDestination.Text = "Editar";
            this.buttonEditDestination.UseVisualStyleBackColor = true;
            this.buttonEditDestination.Click += new System.EventHandler(this.buttonEditDestination_Click);
            // 
            // buttonRefreshDestination
            // 
            this.buttonRefreshDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefreshDestination.Location = new System.Drawing.Point(160, 485);
            this.buttonRefreshDestination.Name = "buttonRefreshDestination";
            this.buttonRefreshDestination.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshDestination.TabIndex = 52;
            this.buttonRefreshDestination.Text = "Recargar";
            this.buttonRefreshDestination.UseVisualStyleBackColor = true;
            this.buttonRefreshDestination.Click += new System.EventHandler(this.buttonRefreshDestination_Click);
            // 
            // buttonDeleteDestination
            // 
            this.buttonDeleteDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteDestination.Location = new System.Drawing.Point(86, 485);
            this.buttonDeleteDestination.Name = "buttonDeleteDestination";
            this.buttonDeleteDestination.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteDestination.TabIndex = 51;
            this.buttonDeleteDestination.Text = "Eliminar";
            this.buttonDeleteDestination.UseVisualStyleBackColor = true;
            this.buttonDeleteDestination.Click += new System.EventHandler(this.buttonDeleteDestination_Click);
            // 
            // buttonAddDestination
            // 
            this.buttonAddDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddDestination.Location = new System.Drawing.Point(12, 485);
            this.buttonAddDestination.Name = "buttonAddDestination";
            this.buttonAddDestination.Size = new System.Drawing.Size(68, 26);
            this.buttonAddDestination.TabIndex = 50;
            this.buttonAddDestination.Text = "Agregar";
            this.buttonAddDestination.UseVisualStyleBackColor = true;
            this.buttonAddDestination.Click += new System.EventHandler(this.buttonAddDestination_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(86, 23);
            this.buttonBack.TabIndex = 67;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowMap.Location = new System.Drawing.Point(305, 485);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(68, 26);
            this.buttonShowMap.TabIndex = 89;
            this.buttonShowMap.Text = "Ver Mapa";
            this.buttonShowMap.UseVisualStyleBackColor = true;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // DestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(757, 520);
            this.ControlBox = false;
            this.Controls.Add(this.buttonShowMap);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewDestinations);
            this.Controls.Add(this.buttonEditDestination);
            this.Controls.Add(this.buttonRefreshDestination);
            this.Controls.Add(this.buttonDeleteDestination);
            this.Controls.Add(this.buttonAddDestination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DestinationForm";
            this.Text = "DestinationForm";
            this.Load += new System.EventHandler(this.DestinationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDestinations;
        private System.Windows.Forms.Button buttonEditDestination;
        private System.Windows.Forms.Button buttonRefreshDestination;
        private System.Windows.Forms.Button buttonDeleteDestination;
        private System.Windows.Forms.Button buttonAddDestination;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonShowMap;
    }
}