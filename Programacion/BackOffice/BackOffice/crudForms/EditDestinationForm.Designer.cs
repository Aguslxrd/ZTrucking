namespace BackOffice.crudForms
{
    partial class EditDestinationForm
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
            this.txtBoxDestinationDoorNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.txtBoxDestinationCorner = new System.Windows.Forms.TextBox();
            this.labelCorner = new System.Windows.Forms.Label();
            this.dateTimePickerDestinationManagementTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDestinationManagement = new System.Windows.Forms.DateTimePicker();
            this.labelShipDate = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelActivated = new System.Windows.Forms.Label();
            this.txtBoxDestinationStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.txtBoxIDDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(111, 365);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 127;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(30, 365);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 126;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(265, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 125;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(2, 3);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(257, 41);
            this.panelSlide.TabIndex = 124;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // txtBoxDestinationDoorNumber
            // 
            this.txtBoxDestinationDoorNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxDestinationDoorNumber.Location = new System.Drawing.Point(30, 184);
            this.txtBoxDestinationDoorNumber.Name = "txtBoxDestinationDoorNumber";
            this.txtBoxDestinationDoorNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationDoorNumber.TabIndex = 123;
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(28, 168);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 122;
            this.labelNumber.Text = "Numero";
            // 
            // txtBoxDestinationCorner
            // 
            this.txtBoxDestinationCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxDestinationCorner.Location = new System.Drawing.Point(30, 135);
            this.txtBoxDestinationCorner.Name = "txtBoxDestinationCorner";
            this.txtBoxDestinationCorner.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationCorner.TabIndex = 121;
            // 
            // labelCorner
            // 
            this.labelCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(28, 119);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(45, 13);
            this.labelCorner.TabIndex = 120;
            this.labelCorner.Text = "Esquina";
            // 
            // dateTimePickerDestinationManagementTime
            // 
            this.dateTimePickerDestinationManagementTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerDestinationManagementTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDestinationManagementTime.Location = new System.Drawing.Point(30, 324);
            this.dateTimePickerDestinationManagementTime.Name = "dateTimePickerDestinationManagementTime";
            this.dateTimePickerDestinationManagementTime.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerDestinationManagementTime.TabIndex = 119;
            // 
            // dateTimePickerDestinationManagement
            // 
            this.dateTimePickerDestinationManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerDestinationManagement.Location = new System.Drawing.Point(30, 298);
            this.dateTimePickerDestinationManagement.Name = "dateTimePickerDestinationManagement";
            this.dateTimePickerDestinationManagement.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDestinationManagement.TabIndex = 118;
            // 
            // labelShipDate
            // 
            this.labelShipDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelShipDate.AutoSize = true;
            this.labelShipDate.Location = new System.Drawing.Point(28, 282);
            this.labelShipDate.Name = "labelShipDate";
            this.labelShipDate.Size = new System.Drawing.Size(82, 13);
            this.labelShipDate.TabIndex = 117;
            this.labelShipDate.Text = "Fecha de salida";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(30, 223);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 116;
            // 
            // labelActivated
            // 
            this.labelActivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelActivated.AutoSize = true;
            this.labelActivated.Location = new System.Drawing.Point(30, 207);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(37, 13);
            this.labelActivated.TabIndex = 115;
            this.labelActivated.Text = "Activo";
            // 
            // txtBoxDestinationStreet
            // 
            this.txtBoxDestinationStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxDestinationStreet.Location = new System.Drawing.Point(30, 86);
            this.txtBoxDestinationStreet.Name = "txtBoxDestinationStreet";
            this.txtBoxDestinationStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationStreet.TabIndex = 114;
            // 
            // labelStreet
            // 
            this.labelStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(30, 70);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(30, 13);
            this.labelStreet.TabIndex = 113;
            this.labelStreet.Text = "Calle";
            // 
            // txtBoxIDDestination
            // 
            this.txtBoxIDDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxIDDestination.Location = new System.Drawing.Point(213, 86);
            this.txtBoxIDDestination.Name = "txtBoxIDDestination";
            this.txtBoxIDDestination.Size = new System.Drawing.Size(46, 20);
            this.txtBoxIDDestination.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "ID";
            // 
            // EditDestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(303, 400);
            this.Controls.Add(this.txtBoxIDDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.txtBoxDestinationDoorNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.txtBoxDestinationCorner);
            this.Controls.Add(this.labelCorner);
            this.Controls.Add(this.dateTimePickerDestinationManagementTime);
            this.Controls.Add(this.dateTimePickerDestinationManagement);
            this.Controls.Add(this.labelShipDate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelActivated);
            this.Controls.Add(this.txtBoxDestinationStreet);
            this.Controls.Add(this.labelStreet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDestinationForm";
            this.Text = "EditDestinationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.TextBox txtBoxDestinationDoorNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox txtBoxDestinationCorner;
        private System.Windows.Forms.Label labelCorner;
        private System.Windows.Forms.DateTimePicker dateTimePickerDestinationManagementTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDestinationManagement;
        private System.Windows.Forms.Label labelShipDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelActivated;
        private System.Windows.Forms.TextBox txtBoxDestinationStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox txtBoxIDDestination;
        private System.Windows.Forms.Label label2;
    }
}