namespace BackOffice.crudForms
{
    partial class AssignTruckToTruckerForm
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
            this.txtBoxIDAssignedTrucker = new System.Windows.Forms.TextBox();
            this.labelIDTrucker = new System.Windows.Forms.Label();
            this.labelIDTruck = new System.Windows.Forms.Label();
            this.txtBoxIDAssignedTruck = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtBoxIDAssignedTrucker
            // 
            this.txtBoxIDAssignedTrucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxIDAssignedTrucker.Location = new System.Drawing.Point(27, 221);
            this.txtBoxIDAssignedTrucker.Name = "txtBoxIDAssignedTrucker";
            this.txtBoxIDAssignedTrucker.Size = new System.Drawing.Size(44, 20);
            this.txtBoxIDAssignedTrucker.TabIndex = 22;
            // 
            // labelIDTrucker
            // 
            this.labelIDTrucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIDTrucker.AutoSize = true;
            this.labelIDTrucker.Location = new System.Drawing.Point(24, 192);
            this.labelIDTrucker.Name = "labelIDTrucker";
            this.labelIDTrucker.Size = new System.Drawing.Size(52, 13);
            this.labelIDTrucker.TabIndex = 21;
            this.labelIDTrucker.Text = "ID Chofer";
            // 
            // labelIDTruck
            // 
            this.labelIDTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIDTruck.AutoSize = true;
            this.labelIDTruck.Location = new System.Drawing.Point(24, 117);
            this.labelIDTruck.Name = "labelIDTruck";
            this.labelIDTruck.Size = new System.Drawing.Size(56, 13);
            this.labelIDTruck.TabIndex = 20;
            this.labelIDTruck.Text = "ID Camion";
            // 
            // txtBoxIDAssignedTruck
            // 
            this.txtBoxIDAssignedTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxIDAssignedTruck.Location = new System.Drawing.Point(27, 146);
            this.txtBoxIDAssignedTruck.Name = "txtBoxIDAssignedTruck";
            this.txtBoxIDAssignedTruck.Size = new System.Drawing.Size(44, 20);
            this.txtBoxIDAssignedTruck.TabIndex = 19;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(101, 290);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 139;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(20, 290);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 138;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(240, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 137;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(3, 1);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(226, 37);
            this.panelSlide.TabIndex = 136;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // AssignTruckToTruckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(274, 325);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.txtBoxIDAssignedTrucker);
            this.Controls.Add(this.labelIDTrucker);
            this.Controls.Add(this.labelIDTruck);
            this.Controls.Add(this.txtBoxIDAssignedTruck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignTruckToTruckerForm";
            this.Text = "AssignTruckToTruckerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIDAssignedTrucker;
        private System.Windows.Forms.Label labelIDTrucker;
        private System.Windows.Forms.Label labelIDTruck;
        private System.Windows.Forms.TextBox txtBoxIDAssignedTruck;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
    }
}