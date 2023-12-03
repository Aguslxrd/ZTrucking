namespace Aplicacion_Almacen.Forms
{
    partial class BatchManagerSearcherForm
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
            this.panelSlide = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearchBatchByID = new System.Windows.Forms.Button();
            this.dataGridViewSearcher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearcher)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(2, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(443, 41);
            this.panelSlide.TabIndex = 49;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(315, 150);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(75, 23);
            this.textBoxID.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(451, 23);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 46;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearchBatchByID
            // 
            this.buttonSearchBatchByID.Location = new System.Drawing.Point(396, 150);
            this.buttonSearchBatchByID.Name = "buttonSearchBatchByID";
            this.buttonSearchBatchByID.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchBatchByID.TabIndex = 45;
            this.buttonSearchBatchByID.Text = "Buscar";
            this.buttonSearchBatchByID.UseVisualStyleBackColor = true;
            this.buttonSearchBatchByID.Click += new System.EventHandler(this.buttonSearchBatchByID_Click);
            // 
            // dataGridViewSearcher
            // 
            this.dataGridViewSearcher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewSearcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearcher.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewSearcher.Name = "dataGridViewSearcher";
            this.dataGridViewSearcher.Size = new System.Drawing.Size(459, 80);
            this.dataGridViewSearcher.TabIndex = 44;
            // 
            // BatchManagerSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(495, 187);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSearchBatchByID);
            this.Controls.Add(this.dataGridViewSearcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatchManagerSearcher";
            this.Text = "BatchManagerSearcher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearchBatchByID;
        private System.Windows.Forms.DataGridView dataGridViewSearcher;
    }
}