namespace Aplicacion_Almacen.Forms.crudForms
{
    partial class AssignBatchToTruckComponentForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerAssignBatchToTruckManagementTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBatchShippingDate = new System.Windows.Forms.DateTimePicker();
            this.labelEstimatedDate = new System.Windows.Forms.Label();
            this.labelIDBatch = new System.Windows.Forms.Label();
            this.txtBoxIDBatch = new System.Windows.Forms.TextBox();
            this.labelTruckID = new System.Windows.Forms.Label();
            this.txtBoxIDTruck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(221, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 114;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(2, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(213, 29);
            this.panelSlide.TabIndex = 113;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 257);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 130;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 257);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 129;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerAssignBatchToTruckManagementTime
            // 
            this.dateTimePickerAssignBatchToTruckManagementTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAssignBatchToTruckManagementTime.Location = new System.Drawing.Point(15, 225);
            this.dateTimePickerAssignBatchToTruckManagementTime.Name = "dateTimePickerAssignBatchToTruckManagementTime";
            this.dateTimePickerAssignBatchToTruckManagementTime.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerAssignBatchToTruckManagementTime.TabIndex = 137;
            // 
            // dateTimePickerBatchShippingDate
            // 
            this.dateTimePickerBatchShippingDate.Location = new System.Drawing.Point(15, 199);
            this.dateTimePickerBatchShippingDate.Name = "dateTimePickerBatchShippingDate";
            this.dateTimePickerBatchShippingDate.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerBatchShippingDate.TabIndex = 136;
            // 
            // labelEstimatedDate
            // 
            this.labelEstimatedDate.AutoSize = true;
            this.labelEstimatedDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEstimatedDate.Location = new System.Drawing.Point(12, 168);
            this.labelEstimatedDate.Name = "labelEstimatedDate";
            this.labelEstimatedDate.Size = new System.Drawing.Size(181, 17);
            this.labelEstimatedDate.TabIndex = 135;
            this.labelEstimatedDate.Text = "Fecha estimada de entrega";
            // 
            // labelIDBatch
            // 
            this.labelIDBatch.AutoSize = true;
            this.labelIDBatch.Location = new System.Drawing.Point(12, 118);
            this.labelIDBatch.Name = "labelIDBatch";
            this.labelIDBatch.Size = new System.Drawing.Size(42, 13);
            this.labelIDBatch.TabIndex = 134;
            this.labelIDBatch.Text = "ID Lote";
            // 
            // txtBoxIDBatch
            // 
            this.txtBoxIDBatch.Location = new System.Drawing.Point(15, 134);
            this.txtBoxIDBatch.Name = "txtBoxIDBatch";
            this.txtBoxIDBatch.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDBatch.TabIndex = 133;
            // 
            // labelTruckID
            // 
            this.labelTruckID.AutoSize = true;
            this.labelTruckID.Location = new System.Drawing.Point(12, 62);
            this.labelTruckID.Name = "labelTruckID";
            this.labelTruckID.Size = new System.Drawing.Size(56, 13);
            this.labelTruckID.TabIndex = 132;
            this.labelTruckID.Text = "ID Camion";
            // 
            // txtBoxIDTruck
            // 
            this.txtBoxIDTruck.Location = new System.Drawing.Point(14, 78);
            this.txtBoxIDTruck.Name = "txtBoxIDTruck";
            this.txtBoxIDTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDTruck.TabIndex = 131;
            // 
            // AssignBatchToTruckComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(254, 292);
            this.Controls.Add(this.dateTimePickerAssignBatchToTruckManagementTime);
            this.Controls.Add(this.dateTimePickerBatchShippingDate);
            this.Controls.Add(this.labelEstimatedDate);
            this.Controls.Add(this.labelIDBatch);
            this.Controls.Add(this.txtBoxIDBatch);
            this.Controls.Add(this.labelTruckID);
            this.Controls.Add(this.txtBoxIDTruck);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignBatchToTruckComponentForm";
            this.Text = "AssignBatchToTruckComponentForm";
            this.Load += new System.EventHandler(this.AssignBatchToTruckComponentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssignBatchToTruckManagementTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerBatchShippingDate;
        private System.Windows.Forms.Label labelEstimatedDate;
        private System.Windows.Forms.Label labelIDBatch;
        private System.Windows.Forms.TextBox txtBoxIDBatch;
        private System.Windows.Forms.Label labelTruckID;
        private System.Windows.Forms.TextBox txtBoxIDTruck;
    }
}