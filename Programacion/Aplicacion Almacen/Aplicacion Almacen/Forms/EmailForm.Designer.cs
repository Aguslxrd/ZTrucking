namespace Aplicacion_Almacen.Forms
{
    partial class EmailForm
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
            this.labelDestination = new System.Windows.Forms.Label();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonSendEmail = new System.Windows.Forms.Button();
            this.buttonMsgTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(12, 140);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(97, 13);
            this.labelDestination.TabIndex = 80;
            this.labelDestination.Text = "Destinatario (Email)";
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.richTextBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxContent.Location = new System.Drawing.Point(12, 201);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(561, 229);
            this.richTextBoxContent.TabIndex = 78;
            this.richTextBoxContent.Text = "";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(15, 156);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(110, 20);
            this.textBoxDestination.TabIndex = 76;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 180);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 81;
            this.labelMessage.Text = "Mensaje:";
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 82;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonSendEmail
            // 
            this.buttonSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendEmail.ForeColor = System.Drawing.Color.Olive;
            this.buttonSendEmail.Location = new System.Drawing.Point(142, 154);
            this.buttonSendEmail.Name = "buttonSendEmail";
            this.buttonSendEmail.Size = new System.Drawing.Size(113, 23);
            this.buttonSendEmail.TabIndex = 83;
            this.buttonSendEmail.Text = "Enviar";
            this.buttonSendEmail.UseVisualStyleBackColor = true;
            this.buttonSendEmail.Click += new System.EventHandler(this.buttonSendEmail_Click);
            // 
            // buttonMsgTemplate
            // 
            this.buttonMsgTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMsgTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.buttonMsgTemplate.ForeColor = System.Drawing.Color.Olive;
            this.buttonMsgTemplate.Location = new System.Drawing.Point(579, 385);
            this.buttonMsgTemplate.Name = "buttonMsgTemplate";
            this.buttonMsgTemplate.Size = new System.Drawing.Size(50, 45);
            this.buttonMsgTemplate.TabIndex = 84;
            this.buttonMsgTemplate.Text = "✎";
            this.buttonMsgTemplate.UseVisualStyleBackColor = true;
            this.buttonMsgTemplate.Click += new System.EventHandler(this.buttonMsgTemplate_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(725, 442);
            this.Controls.Add(this.buttonMsgTemplate);
            this.Controls.Add(this.buttonSendEmail);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.textBoxDestination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonSendEmail;
        private System.Windows.Forms.Button buttonMsgTemplate;
    }
}