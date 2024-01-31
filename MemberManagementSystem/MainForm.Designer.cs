
namespace MemberManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTitle = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SeachButton = new System.Windows.Forms.Button();
            this.kakuninn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("MS UI Gothic", 32F);
            this.MainTitle.Location = new System.Drawing.Point(187, 38);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(517, 54);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "管理者用管理システム";
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.CreateButton.Location = new System.Drawing.Point(101, 129);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(256, 291);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "新規会員登録";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // SeachButton
            // 
            this.SeachButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeachButton.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.SeachButton.Location = new System.Drawing.Point(520, 129);
            this.SeachButton.Name = "SeachButton";
            this.SeachButton.Size = new System.Drawing.Size(256, 291);
            this.SeachButton.TabIndex = 2;
            this.SeachButton.Text = "会員情報検索";
            this.SeachButton.UseVisualStyleBackColor = false;
            this.SeachButton.Click += new System.EventHandler(this.SeachButtonClick);
            // 
            // kakuninn
            // 
            this.kakuninn.Location = new System.Drawing.Point(774, 38);
            this.kakuninn.Name = "kakuninn";
            this.kakuninn.Size = new System.Drawing.Size(97, 42);
            this.kakuninn.TabIndex = 3;
            this.kakuninn.Text = "テーブル作成";
            this.kakuninn.UseVisualStyleBackColor = true;
            this.kakuninn.Click += new System.EventHandler(this.kakuninnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.kakuninn);
            this.Controls.Add(this.SeachButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.MainTitle);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button SeachButton;
        private System.Windows.Forms.Button kakuninn;
    }
}

