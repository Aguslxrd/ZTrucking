namespace BackOffice.crudForms
{
    partial class AssignBatchToTruckForm
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
            this.dateTimePickerShippManagementTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerShippManagement = new System.Windows.Forms.DateTimePicker();
            this.labelShipDate = new System.Windows.Forms.Label();
            this.labelIDLot = new System.Windows.Forms.Label();
            this.txtBoxIDBatchShippManagement = new System.Windows.Forms.TextBox();
            this.txtBoxIDTruckShippManagement = new System.Windows.Forms.TextBox();
            this.labelIDTruck = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dateTimePickerShippManagementTime
            // 
            this.dateTimePickerShippManagementTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerShippManagementTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerShippManagementTime.Location = new System.Drawing.Point(12, 246);
            this.dateTimePickerShippManagementTime.Name = "dateTimePickerShippManagementTime";
            this.dateTimePickerShippManagementTime.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerShippManagementTime.TabIndex = 87;
            // 
            // dateTimePickerShippManagement
            // 
            this.dateTimePickerShippManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerShippManagement.Location = new System.Drawing.Point(10, 217);
            this.dateTimePickerShippManagement.Name = "dateTimePickerShippManagement";
            this.dateTimePickerShippManagement.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerShippManagement.TabIndex = 86;
            // 
            // labelShipDate
            // 
            this.labelShipDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelShipDate.AutoSize = true;
            this.labelShipDate.Location = new System.Drawing.Point(9, 189);
            this.labelShipDate.Name = "labelShipDate";
            this.labelShipDate.Size = new System.Drawing.Size(82, 13);
            this.labelShipDate.TabIndex = 85;
            this.labelShipDate.Text = "Fecha de salida";
            // 
            // labelIDLot
            // 
            this.labelIDLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIDLot.AutoSize = true;
            this.labelIDLot.Location = new System.Drawing.Point(9, 113);
            this.labelIDLot.Name = "labelIDLot";
            this.labelIDLot.Size = new System.Drawing.Size(42, 13);
            this.labelIDLot.TabIndex = 84;
            this.labelIDLot.Text = "ID Lote";
            // 
            // txtBoxIDBatchShippManagement
            // 
            this.txtBoxIDBatchShippManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxIDBatchShippManagement.Location = new System.Drawing.Point(10, 129);
            this.txtBoxIDBatchShippManagement.Name = "txtBoxIDBatchShippManagement";
            this.txtBoxIDBatchShippManagement.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDBatchShippManagement.TabIndex = 83;
            // 
            // txtBoxIDTruckShippManagement
            // 
            this.txtBoxIDTruckShippManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxIDTruckShippManagement.Location = new System.Drawing.Point(10, 84);
            this.txtBoxIDTruckShippManagement.Name = "txtBoxIDTruckShippManagement";
            this.txtBoxIDTruckShippManagement.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDTruckShippManagement.TabIndex = 82;
            // 
            // labelIDTruck
            // 
            this.labelIDTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIDTruck.AutoSize = true;
            this.labelIDTruck.Location = new System.Drawing.Point(9, 68);
            this.labelIDTruck.Name = "labelIDTruck";
            this.labelIDTruck.Size = new System.Drawing.Size(56, 13);
            this.labelIDTruck.TabIndex = 81;
            this.labelIDTruck.Text = "ID Camion";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 131;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 326);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 130;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(248, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 129;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(1, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(241, 30);
            this.panelSlide.TabIndex = 128;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // AssignBatchToTruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(287, 361);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.dateTimePickerShippManagementTime);
            this.Controls.Add(this.dateTimePickerShippManagement);
            this.Controls.Add(this.labelShipDate);
            this.Controls.Add(this.labelIDLot);
            this.Controls.Add(this.txtBoxIDBatchShippManagement);
            this.Controls.Add(this.txtBoxIDTruckShippManagement);
            this.Controls.Add(this.labelIDTruck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignBatchToTruckForm";
            this.Text = "AssignBatchToTruckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerShippManagementTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippManagement;
        private System.Windows.Forms.Label labelShipDate;
        private System.Windows.Forms.Label labelIDLot;
        private System.Windows.Forms.TextBox txtBoxIDBatchShippManagement;
        private System.Windows.Forms.TextBox txtBoxIDTruckShippManagement;
        private System.Windows.Forms.Label labelIDTruck;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
    }
}