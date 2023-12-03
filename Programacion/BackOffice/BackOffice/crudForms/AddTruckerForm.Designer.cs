namespace BackOffice.crudForms
{
    partial class AddTruckerForm
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
            this.labelUsernameTrucker = new System.Windows.Forms.Label();
            this.txtBoxUsernameTrucker = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 166);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 134;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 166);
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
            this.buttonClose.Location = new System.Drawing.Point(239, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 132;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(2, 3);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(231, 31);
            this.panelSlide.TabIndex = 131;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // labelUsernameTrucker
            // 
            this.labelUsernameTrucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUsernameTrucker.AutoSize = true;
            this.labelUsernameTrucker.Location = new System.Drawing.Point(11, 77);
            this.labelUsernameTrucker.Name = "labelUsernameTrucker";
            this.labelUsernameTrucker.Size = new System.Drawing.Size(61, 13);
            this.labelUsernameTrucker.TabIndex = 136;
            this.labelUsernameTrucker.Text = "ID Trucker:";
            // 
            // txtBoxUsernameTrucker
            // 
            this.txtBoxUsernameTrucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxUsernameTrucker.Location = new System.Drawing.Point(12, 102);
            this.txtBoxUsernameTrucker.Name = "txtBoxUsernameTrucker";
            this.txtBoxUsernameTrucker.Size = new System.Drawing.Size(49, 20);
            this.txtBoxUsernameTrucker.TabIndex = 135;
            // 
            // AddTrucker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(271, 205);
            this.Controls.Add(this.labelUsernameTrucker);
            this.Controls.Add(this.txtBoxUsernameTrucker);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTrucker";
            this.Text = "AddTrucker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label labelUsernameTrucker;
        private System.Windows.Forms.TextBox txtBoxUsernameTrucker;
    }
}