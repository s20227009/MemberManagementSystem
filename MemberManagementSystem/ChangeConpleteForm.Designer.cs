﻿
namespace MemberManagementSystem
{
    partial class ChangeConpleteForm
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
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(166, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "変更が完了しました";
            // 
            // MainGoButton
            // 
            this.MainGoButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.MainGoButton.Location = new System.Drawing.Point(669, 382);
            this.MainGoButton.Name = "MainGoButton";
            this.MainGoButton.Size = new System.Drawing.Size(97, 46);
            this.MainGoButton.TabIndex = 2;
            this.MainGoButton.Text = "mainへ";
            this.MainGoButton.UseVisualStyleBackColor = true;
            this.MainGoButton.Click += new System.EventHandler(this.MainGoButtonClick);
            // 
            // ChangeConpleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainGoButton);
            this.Controls.Add(this.label1);
            this.Name = "ChangeConpleteForm";
            this.Text = "Form12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainGoButton;
    }
}