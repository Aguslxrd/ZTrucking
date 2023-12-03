namespace BackOffice.crudForms
{
    partial class AssignProductToBatchForm
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
            this.labelBatchID = new System.Windows.Forms.Label();
            this.txtBoxIDLote = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.txtBoxIDProduct = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelBatchID
            // 
            this.labelBatchID.AutoSize = true;
            this.labelBatchID.Location = new System.Drawing.Point(15, 117);
            this.labelBatchID.Name = "labelBatchID";
            this.labelBatchID.Size = new System.Drawing.Size(101, 13);
            this.labelBatchID.TabIndex = 10;
            this.labelBatchID.Text = "ID del lote a asignar";
            // 
            // txtBoxIDLote
            // 
            this.txtBoxIDLote.Location = new System.Drawing.Point(12, 142);
            this.txtBoxIDLote.Name = "txtBoxIDLote";
            this.txtBoxIDLote.Size = new System.Drawing.Size(231, 20);
            this.txtBoxIDLote.TabIndex = 9;
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(15, 50);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(126, 13);
            this.labelProductID.TabIndex = 8;
            this.labelProductID.Text = "ID del producto a asignar";
            // 
            // txtBoxIDProduct
            // 
            this.txtBoxIDProduct.Location = new System.Drawing.Point(12, 75);
            this.txtBoxIDProduct.Name = "txtBoxIDProduct";
            this.txtBoxIDProduct.Size = new System.Drawing.Size(231, 20);
            this.txtBoxIDProduct.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(103, 186);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 112;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 186);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 111;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(269, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 25);
            this.buttonClose.TabIndex = 114;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(1, 3);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(260, 25);
            this.panelSlide.TabIndex = 113;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // AssignProductToBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(303, 229);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelBatchID);
            this.Controls.Add(this.txtBoxIDLote);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.txtBoxIDProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignProductToBatchForm";
            this.Text = "AssignProductToBatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBatchID;
        private System.Windows.Forms.TextBox txtBoxIDLote;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.TextBox txtBoxIDProduct;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
    }
}