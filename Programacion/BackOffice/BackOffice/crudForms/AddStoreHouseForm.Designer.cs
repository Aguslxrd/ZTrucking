namespace BackOffice.crudForms
{
    partial class AddStoreHouseForm
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
            this.labelActived = new System.Windows.Forms.Label();
            this.labelCorner = new System.Windows.Forms.Label();
            this.txtBoxStoreHouseCorner = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.txtBoxStoreHouseDoorNumber = new System.Windows.Forms.TextBox();
            this.txtBoxStoreHouseStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.comboBoxActivated = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelActived
            // 
            this.labelActived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelActived.AutoSize = true;
            this.labelActived.Location = new System.Drawing.Point(20, 199);
            this.labelActived.Name = "labelActived";
            this.labelActived.Size = new System.Drawing.Size(37, 13);
            this.labelActived.TabIndex = 55;
            this.labelActived.Text = "Activo";
            // 
            // labelCorner
            // 
            this.labelCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(20, 158);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(45, 13);
            this.labelCorner.TabIndex = 54;
            this.labelCorner.Text = "Esquina";
            // 
            // txtBoxStoreHouseCorner
            // 
            this.txtBoxStoreHouseCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxStoreHouseCorner.Location = new System.Drawing.Point(20, 173);
            this.txtBoxStoreHouseCorner.Name = "txtBoxStoreHouseCorner";
            this.txtBoxStoreHouseCorner.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseCorner.TabIndex = 53;
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(20, 116);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 52;
            this.labelNumber.Text = "Numero";
            // 
            // txtBoxStoreHouseDoorNumber
            // 
            this.txtBoxStoreHouseDoorNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxStoreHouseDoorNumber.Location = new System.Drawing.Point(21, 132);
            this.txtBoxStoreHouseDoorNumber.Name = "txtBoxStoreHouseDoorNumber";
            this.txtBoxStoreHouseDoorNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseDoorNumber.TabIndex = 51;
            // 
            // txtBoxStoreHouseStreet
            // 
            this.txtBoxStoreHouseStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxStoreHouseStreet.Location = new System.Drawing.Point(21, 87);
            this.txtBoxStoreHouseStreet.Name = "txtBoxStoreHouseStreet";
            this.txtBoxStoreHouseStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseStreet.TabIndex = 50;
            // 
            // labelStreet
            // 
            this.labelStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(20, 71);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(30, 13);
            this.labelStreet.TabIndex = 49;
            this.labelStreet.Text = "Calle";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(253, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 127;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(3, 3);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(244, 41);
            this.panelSlide.TabIndex = 126;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // comboBoxActivated
            // 
            this.comboBoxActivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxActivated.FormattingEnabled = true;
            this.comboBoxActivated.Location = new System.Drawing.Point(20, 215);
            this.comboBoxActivated.Name = "comboBoxActivated";
            this.comboBoxActivated.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActivated.TabIndex = 128;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(101, 315);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 130;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(20, 315);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 129;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddStoreHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(287, 361);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxActivated);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.labelActived);
            this.Controls.Add(this.labelCorner);
            this.Controls.Add(this.txtBoxStoreHouseCorner);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.txtBoxStoreHouseDoorNumber);
            this.Controls.Add(this.txtBoxStoreHouseStreet);
            this.Controls.Add(this.labelStreet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStoreHouseForm";
            this.Text = "AddStoreHouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActived;
        private System.Windows.Forms.Label labelCorner;
        private System.Windows.Forms.TextBox txtBoxStoreHouseCorner;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox txtBoxStoreHouseDoorNumber;
        private System.Windows.Forms.TextBox txtBoxStoreHouseStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.ComboBox comboBoxActivated;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}