﻿
namespace MemberManagementSystem
{
    partial class ErrorIdForm
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
            this.MainGoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDが重複しています！";
            // 
            // MainGoButton
            // 
            this.MainGoButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.MainGoButton.Location = new System.Drawing.Point(666, 392);
            this.MainGoButton.Name = "MainGoButton";
            this.MainGoButton.Size = new System.Drawing.Size(97, 46);
            this.MainGoButton.TabIndex = 3;
            this.MainGoButton.Text = "mainへ";
            this.MainGoButton.UseVisualStyleBackColor = true;
            this.MainGoButton.Click += new System.EventHandler(this.MainGoButtonClick);
            // 
            // ErrorIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainGoButton);
            this.Controls.Add(this.label1);
            this.Name = "ErrorIdForm";
            this.Text = "Form13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainGoButton;
    }
}