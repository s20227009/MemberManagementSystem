
namespace MemberManagementSystem
{
    partial class InsertClearForm
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
            this.NoticeLabel = new System.Windows.Forms.Label();
            this.GoMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoticeLabel
            // 
            this.NoticeLabel.AutoSize = true;
            this.NoticeLabel.Font = new System.Drawing.Font("MS UI Gothic", 48F);
            this.NoticeLabel.Location = new System.Drawing.Point(69, 173);
            this.NoticeLabel.Name = "NoticeLabel";
            this.NoticeLabel.Size = new System.Drawing.Size(660, 80);
            this.NoticeLabel.TabIndex = 0;
            this.NoticeLabel.Text = "登録が完了しました";
            // 
            // GoMainButton
            // 
            this.GoMainButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.GoMainButton.Location = new System.Drawing.Point(674, 392);
            this.GoMainButton.Name = "GoMainButton";
            this.GoMainButton.Size = new System.Drawing.Size(97, 46);
            this.GoMainButton.TabIndex = 1;
            this.GoMainButton.Text = "Mainへ";
            this.GoMainButton.UseVisualStyleBackColor = true;
            this.GoMainButton.Click += new System.EventHandler(this.GoMainButtonClick);
            // 
            // InsertClearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoMainButton);
            this.Controls.Add(this.NoticeLabel);
            this.Name = "InsertClearForm";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoticeLabel;
        private System.Windows.Forms.Button GoMainButton;
    }
}