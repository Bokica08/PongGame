﻿namespace PongGame
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txbP1 = new System.Windows.Forms.TextBox();
            this.lblPlyrNms = new System.Windows.Forms.Label();
            this.lblPlyr1 = new System.Windows.Forms.Label();
            this.lblPlyr2 = new System.Windows.Forms.Label();
            this.txbP2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbP1
            // 
            this.txbP1.Location = new System.Drawing.Point(16, 69);
            this.txbP1.Name = "txbP1";
            this.txbP1.Size = new System.Drawing.Size(136, 20);
            this.txbP1.TabIndex = 0;
            this.txbP1.Validating += new System.ComponentModel.CancelEventHandler(this.txbP1_Validating);
            // 
            // lblPlyrNms
            // 
            this.lblPlyrNms.AutoSize = true;
            this.lblPlyrNms.Location = new System.Drawing.Point(13, 13);
            this.lblPlyrNms.Name = "lblPlyrNms";
            this.lblPlyrNms.Size = new System.Drawing.Size(100, 13);
            this.lblPlyrNms.TabIndex = 2;
            this.lblPlyrNms.Text = "Enter player names:";
            // 
            // lblPlyr1
            // 
            this.lblPlyr1.AutoSize = true;
            this.lblPlyr1.Location = new System.Drawing.Point(12, 46);
            this.lblPlyr1.Name = "lblPlyr1";
            this.lblPlyr1.Size = new System.Drawing.Size(48, 13);
            this.lblPlyr1.TabIndex = 3;
            this.lblPlyr1.Text = "Player 1:";
            // 
            // lblPlyr2
            // 
            this.lblPlyr2.AutoSize = true;
            this.lblPlyr2.Location = new System.Drawing.Point(206, 46);
            this.lblPlyr2.Name = "lblPlyr2";
            this.lblPlyr2.Size = new System.Drawing.Size(48, 13);
            this.lblPlyr2.TabIndex = 5;
            this.lblPlyr2.Text = "Player 2:";
            // 
            // txbP2
            // 
            this.txbP2.Location = new System.Drawing.Point(209, 69);
            this.txbP2.Name = "txbP2";
            this.txbP2.Size = new System.Drawing.Size(136, 20);
            this.txbP2.TabIndex = 4;
            this.txbP2.Validating += new System.ComponentModel.CancelEventHandler(this.txbP2_Validating);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(58, 112);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 147);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPlyr2);
            this.Controls.Add(this.txbP2);
            this.Controls.Add(this.lblPlyr1);
            this.Controls.Add(this.lblPlyrNms);
            this.Controls.Add(this.txbP1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbP1;
        private System.Windows.Forms.Label lblPlyrNms;
        private System.Windows.Forms.Label lblPlyr1;
        private System.Windows.Forms.Label lblPlyr2;
        private System.Windows.Forms.TextBox txbP2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}