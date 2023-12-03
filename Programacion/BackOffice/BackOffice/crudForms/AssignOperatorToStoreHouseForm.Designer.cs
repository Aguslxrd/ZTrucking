namespace BackOffice.crudForms
{
    partial class AssignOperatorToStoreHouseForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.labelIDOperator = new System.Windows.Forms.Label();
            this.txtBoxIDOperator = new System.Windows.Forms.TextBox();
            this.txtBoxIDAddOperatorToStoreHouse = new System.Windows.Forms.TextBox();
            this.labelIDStoreHouse = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(250, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 129;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(2, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(242, 41);
            this.panelSlide.TabIndex = 128;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // labelIDOperator
            // 
            this.labelIDOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDOperator.AutoSize = true;
            this.labelIDOperator.Location = new System.Drawing.Point(22, 169);
            this.labelIDOperator.Name = "labelIDOperator";
            this.labelIDOperator.Size = new System.Drawing.Size(61, 13);
            this.labelIDOperator.TabIndex = 133;
            this.labelIDOperator.Text = "ID Operario";
            // 
            // txtBoxIDOperator
            // 
            this.txtBoxIDOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDOperator.Location = new System.Drawing.Point(23, 185);
            this.txtBoxIDOperator.Name = "txtBoxIDOperator";
            this.txtBoxIDOperator.Size = new System.Drawing.Size(43, 20);
            this.txtBoxIDOperator.TabIndex = 132;
            // 
            // txtBoxIDAddOperatorToStoreHouse
            // 
            this.txtBoxIDAddOperatorToStoreHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDAddOperatorToStoreHouse.Location = new System.Drawing.Point(22, 122);
            this.txtBoxIDAddOperatorToStoreHouse.Name = "txtBoxIDAddOperatorToStoreHouse";
            this.txtBoxIDAddOperatorToStoreHouse.Size = new System.Drawing.Size(43, 20);
            this.txtBoxIDAddOperatorToStoreHouse.TabIndex = 131;
            // 
            // labelIDStoreHouse
            // 
            this.labelIDStoreHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDStoreHouse.AutoSize = true;
            this.labelIDStoreHouse.Location = new System.Drawing.Point(21, 106);
            this.labelIDStoreHouse.Name = "labelIDStoreHouse";
            this.labelIDStoreHouse.Size = new System.Drawing.Size(62, 13);
            this.labelIDStoreHouse.TabIndex = 130;
            this.labelIDStoreHouse.Text = "ID Almacen";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(103, 287);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 135;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(22, 287);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 134;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AssignOperatorToStoreHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelIDOperator);
            this.Controls.Add(this.txtBoxIDOperator);
            this.Controls.Add(this.txtBoxIDAddOperatorToStoreHouse);
            this.Controls.Add(this.labelIDStoreHouse);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignOperatorToStoreHouseForm";
            this.Text = "AssignOperatorToStoreHouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label labelIDOperator;
        private System.Windows.Forms.TextBox txtBoxIDOperator;
        private System.Windows.Forms.TextBox txtBoxIDAddOperatorToStoreHouse;
        private System.Windows.Forms.Label labelIDStoreHouse;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}