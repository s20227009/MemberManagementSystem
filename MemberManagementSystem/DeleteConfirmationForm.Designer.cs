﻿
namespace MemberManagementSystem
{
    partial class DeleteConfirmationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteOkButton = new System.Windows.Forms.Button();
            this.DeleteNoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(119, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "削除しますか？";
            // 
            // DeleteOkButton
            // 
            this.DeleteOkButton.Location = new System.Drawing.Point(58, 99);
            this.DeleteOkButton.Name = "DeleteOkButton";
            this.DeleteOkButton.Size = new System.Drawing.Size(100, 75);
            this.DeleteOkButton.TabIndex = 1;
            this.DeleteOkButton.Text = "はい";
            this.DeleteOkButton.UseVisualStyleBackColor = true;
            this.DeleteOkButton.Click += new System.EventHandler(this.DeleteOkButton_Click);
            // 
            // DeleteNoButton
            // 
            this.DeleteNoButton.Location = new System.Drawing.Point(233, 99);
            this.DeleteNoButton.Name = "DeleteNoButton";
            this.DeleteNoButton.Size = new System.Drawing.Size(100, 75);
            this.DeleteNoButton.TabIndex = 2;
            this.DeleteNoButton.Text = "いいえ";
            this.DeleteNoButton.UseVisualStyleBackColor = true;
            this.DeleteNoButton.Click += new System.EventHandler(this.DeleteNoButton_Click);
            // 
            // DeleteConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 202);
            this.Controls.Add(this.DeleteNoButton);
            this.Controls.Add(this.DeleteOkButton);
            this.Controls.Add(this.label1);
            this.Name = "DeleteConfirmationForm";
            this.Text = "Form15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteOkButton;
        private System.Windows.Forms.Button DeleteNoButton;
    }
}