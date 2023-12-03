namespace BackOffice.crudForms
{
    partial class AddBatchForm
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
            this.comboBoxActivated = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerBatchManagementTime = new System.Windows.Forms.DateTimePicker();
            this.labelIDShippment = new System.Windows.Forms.Label();
            this.txtBoxIDShipp = new System.Windows.Forms.TextBox();
            this.dateTimePickerShippingDate = new System.Windows.Forms.DateTimePicker();
            this.labelEstimatedDate = new System.Windows.Forms.Label();
            this.labelActivated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(290, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 112;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(7, 5);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(277, 25);
            this.panelSlide.TabIndex = 111;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(103, 410);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 110;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 410);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 109;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxActivated
            // 
            this.comboBoxActivated.FormattingEnabled = true;
            this.comboBoxActivated.Location = new System.Drawing.Point(160, 347);
            this.comboBoxActivated.Name = "comboBoxActivated";
            this.comboBoxActivated.Size = new System.Drawing.Size(59, 21);
            this.comboBoxActivated.TabIndex = 122;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(12, 148);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosition.TabIndex = 121;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPosition.Location = new System.Drawing.Point(9, 128);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(61, 17);
            this.labelPosition.TabIndex = 120;
            this.labelPosition.Text = "Posicion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 119;
            this.label5.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 70);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(216, 20);
            this.txtBoxEmail.TabIndex = 118;
            // 
            // dateTimePickerBatchManagementTime
            // 
            this.dateTimePickerBatchManagementTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBatchManagementTime.Location = new System.Drawing.Point(12, 271);
            this.dateTimePickerBatchManagementTime.Name = "dateTimePickerBatchManagementTime";
            this.dateTimePickerBatchManagementTime.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerBatchManagementTime.TabIndex = 117;
            // 
            // labelIDShippment
            // 
            this.labelIDShippment.AutoSize = true;
            this.labelIDShippment.BackColor = System.Drawing.Color.Transparent;
            this.labelIDShippment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelIDShippment.Location = new System.Drawing.Point(12, 327);
            this.labelIDShippment.Name = "labelIDShippment";
            this.labelIDShippment.Size = new System.Drawing.Size(60, 17);
            this.labelIDShippment.TabIndex = 116;
            this.labelIDShippment.Text = "ID Envio";
            // 
            // txtBoxIDShipp
            // 
            this.txtBoxIDShipp.Location = new System.Drawing.Point(15, 347);
            this.txtBoxIDShipp.Name = "txtBoxIDShipp";
            this.txtBoxIDShipp.Size = new System.Drawing.Size(50, 20);
            this.txtBoxIDShipp.TabIndex = 115;
            // 
            // dateTimePickerShippingDate
            // 
            this.dateTimePickerShippingDate.Location = new System.Drawing.Point(12, 228);
            this.dateTimePickerShippingDate.Name = "dateTimePickerShippingDate";
            this.dateTimePickerShippingDate.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerShippingDate.TabIndex = 114;
            // 
            // labelEstimatedDate
            // 
            this.labelEstimatedDate.AutoSize = true;
            this.labelEstimatedDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEstimatedDate.Location = new System.Drawing.Point(12, 197);
            this.labelEstimatedDate.Name = "labelEstimatedDate";
            this.labelEstimatedDate.Size = new System.Drawing.Size(181, 17);
            this.labelEstimatedDate.TabIndex = 113;
            this.labelEstimatedDate.Text = "Fecha estimada de entrega";
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.BackColor = System.Drawing.Color.Transparent;
            this.labelActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelActivated.Location = new System.Drawing.Point(157, 327);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(62, 17);
            this.labelActivated.TabIndex = 123;
            this.labelActivated.Text = "Activado";
            // 
            // AddBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(319, 439);
            this.Controls.Add(this.labelActivated);
            this.Controls.Add(this.comboBoxActivated);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.dateTimePickerBatchManagementTime);
            this.Controls.Add(this.labelIDShippment);
            this.Controls.Add(this.txtBoxIDShipp);
            this.Controls.Add(this.dateTimePickerShippingDate);
            this.Controls.Add(this.labelEstimatedDate);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBatchForm";
            this.Text = "AddBatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxActivated;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerBatchManagementTime;
        private System.Windows.Forms.Label labelIDShippment;
        private System.Windows.Forms.TextBox txtBoxIDShipp;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippingDate;
        private System.Windows.Forms.Label labelEstimatedDate;
        private System.Windows.Forms.Label labelActivated;
    }
}