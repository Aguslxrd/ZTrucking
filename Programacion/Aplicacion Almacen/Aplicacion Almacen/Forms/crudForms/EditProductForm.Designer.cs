namespace Aplicacion_Almacen.Forms.crudForms
{
    partial class EditProductForm
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
            this.labelCustomer = new System.Windows.Forms.Label();
            this.txtBoxClient = new System.Windows.Forms.TextBox();
            this.labelCorner = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.txtBoxCorner = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.comboBoxActivated = new System.Windows.Forms.ComboBox();
            this.labelActivated = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.txtBoxVolume = new System.Windows.Forms.TextBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(222, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 112;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(3, -1);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(213, 29);
            this.panelSlide.TabIndex = 111;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 417);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 128;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 417);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 127;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(12, 137);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(39, 13);
            this.labelCustomer.TabIndex = 126;
            this.labelCustomer.Text = "Cliente";
            // 
            // txtBoxClient
            // 
            this.txtBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClient.Location = new System.Drawing.Point(12, 153);
            this.txtBoxClient.Name = "txtBoxClient";
            this.txtBoxClient.Size = new System.Drawing.Size(92, 23);
            this.txtBoxClient.TabIndex = 125;
            // 
            // labelCorner
            // 
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(9, 305);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(45, 13);
            this.labelCorner.TabIndex = 124;
            this.labelCorner.Text = "Esquina";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 254);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 123;
            this.labelNumber.Text = "Numero";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(13, 193);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(30, 13);
            this.labelStreet.TabIndex = 122;
            this.labelStreet.Text = "Calle";
            // 
            // txtBoxCorner
            // 
            this.txtBoxCorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxCorner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCorner.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorner.Location = new System.Drawing.Point(12, 321);
            this.txtBoxCorner.Name = "txtBoxCorner";
            this.txtBoxCorner.Size = new System.Drawing.Size(92, 23);
            this.txtBoxCorner.TabIndex = 121;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumber.Location = new System.Drawing.Point(12, 270);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(92, 23);
            this.txtBoxNumber.TabIndex = 120;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxStreet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStreet.Location = new System.Drawing.Point(12, 219);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(92, 23);
            this.txtBoxStreet.TabIndex = 119;
            // 
            // comboBoxActivated
            // 
            this.comboBoxActivated.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActivated.FormattingEnabled = true;
            this.comboBoxActivated.Location = new System.Drawing.Point(12, 371);
            this.comboBoxActivated.Name = "comboBoxActivated";
            this.comboBoxActivated.Size = new System.Drawing.Size(92, 24);
            this.comboBoxActivated.TabIndex = 118;
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.Location = new System.Drawing.Point(13, 355);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(52, 13);
            this.labelActivated.TabIndex = 117;
            this.labelActivated.Text = "Activado:";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(12, 87);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(48, 13);
            this.labelVolume.TabIndex = 116;
            this.labelVolume.Text = "Volumen";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(12, 36);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(31, 13);
            this.labelWeight.TabIndex = 115;
            this.labelWeight.Text = "Peso";
            // 
            // txtBoxVolume
            // 
            this.txtBoxVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxVolume.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVolume.Location = new System.Drawing.Point(12, 103);
            this.txtBoxVolume.Name = "txtBoxVolume";
            this.txtBoxVolume.Size = new System.Drawing.Size(92, 23);
            this.txtBoxVolume.TabIndex = 114;
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxWeight.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWeight.Location = new System.Drawing.Point(12, 55);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(92, 23);
            this.txtBoxWeight.TabIndex = 113;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(150, 36);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 130;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(153, 55);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(75, 23);
            this.textBoxID.TabIndex = 129;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(257, 445);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.txtBoxClient);
            this.Controls.Add(this.labelCorner);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.txtBoxCorner);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.txtBoxStreet);
            this.Controls.Add(this.comboBoxActivated);
            this.Controls.Add(this.labelActivated);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.txtBoxVolume);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProductForm";
            this.Text = "EditProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox txtBoxClient;
        private System.Windows.Forms.Label labelCorner;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox txtBoxCorner;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.ComboBox comboBoxActivated;
        private System.Windows.Forms.Label labelActivated;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox txtBoxVolume;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
    }
}