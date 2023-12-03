namespace BackOffice.crudForms
{
    partial class EditStoreHouseForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.comboBoxActivated = new System.Windows.Forms.ComboBox();
            this.labelActived = new System.Windows.Forms.Label();
            this.labelCorner = new System.Windows.Forms.Label();
            this.txtBoxStoreHouseCorner = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.txtBoxStoreHouseDoorNumber = new System.Windows.Forms.TextBox();
            this.txtBoxStoreHouseStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 287);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 134;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 287);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 133;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(234, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 132;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(1, 1);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(227, 39);
            this.panelSlide.TabIndex = 131;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // comboBoxActivated
            // 
            this.comboBoxActivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxActivated.FormattingEnabled = true;
            this.comboBoxActivated.Location = new System.Drawing.Point(12, 246);
            this.comboBoxActivated.Name = "comboBoxActivated";
            this.comboBoxActivated.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActivated.TabIndex = 142;
            // 
            // labelActived
            // 
            this.labelActived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelActived.AutoSize = true;
            this.labelActived.Location = new System.Drawing.Point(12, 230);
            this.labelActived.Name = "labelActived";
            this.labelActived.Size = new System.Drawing.Size(37, 13);
            this.labelActived.TabIndex = 141;
            this.labelActived.Text = "Activo";
            // 
            // labelCorner
            // 
            this.labelCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(12, 189);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(45, 13);
            this.labelCorner.TabIndex = 140;
            this.labelCorner.Text = "Esquina";
            // 
            // txtBoxStoreHouseCorner
            // 
            this.txtBoxStoreHouseCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxStoreHouseCorner.Location = new System.Drawing.Point(12, 204);
            this.txtBoxStoreHouseCorner.Name = "txtBoxStoreHouseCorner";
            this.txtBoxStoreHouseCorner.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseCorner.TabIndex = 139;
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 147);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 138;
            this.labelNumber.Text = "Numero";
            // 
            // txtBoxStoreHouseDoorNumber
            // 
            this.txtBoxStoreHouseDoorNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxStoreHouseDoorNumber.Location = new System.Drawing.Point(13, 163);
            this.txtBoxStoreHouseDoorNumber.Name = "txtBoxStoreHouseDoorNumber";
            this.txtBoxStoreHouseDoorNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseDoorNumber.TabIndex = 137;
            // 
            // txtBoxStoreHouseStreet
            // 
            this.txtBoxStoreHouseStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxStoreHouseStreet.Location = new System.Drawing.Point(13, 118);
            this.txtBoxStoreHouseStreet.Name = "txtBoxStoreHouseStreet";
            this.txtBoxStoreHouseStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseStreet.TabIndex = 136;
            // 
            // labelStreet
            // 
            this.labelStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(12, 102);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(30, 13);
            this.labelStreet.TabIndex = 135;
            this.labelStreet.Text = "Calle";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxID.Location = new System.Drawing.Point(15, 79);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxID.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "ID";
            // 
            // EditStoreHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(271, 322);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxActivated);
            this.Controls.Add(this.labelActived);
            this.Controls.Add(this.labelCorner);
            this.Controls.Add(this.txtBoxStoreHouseCorner);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.txtBoxStoreHouseDoorNumber);
            this.Controls.Add(this.txtBoxStoreHouseStreet);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStoreHouseForm";
            this.Text = "EditStoreHouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.ComboBox comboBoxActivated;
        private System.Windows.Forms.Label labelActived;
        private System.Windows.Forms.Label labelCorner;
        private System.Windows.Forms.TextBox txtBoxStoreHouseCorner;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox txtBoxStoreHouseDoorNumber;
        private System.Windows.Forms.TextBox txtBoxStoreHouseStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label1;
    }
}