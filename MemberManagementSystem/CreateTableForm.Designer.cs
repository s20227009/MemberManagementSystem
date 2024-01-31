
namespace MemberManagementSystem
{
    partial class CreateTableForm
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
            this.CreateMemberSystem = new System.Windows.Forms.Button();
            this.CreateDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainGoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateMemberSystem
            // 
            this.CreateMemberSystem.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.CreateMemberSystem.Location = new System.Drawing.Point(108, 94);
            this.CreateMemberSystem.Name = "CreateMemberSystem";
            this.CreateMemberSystem.Size = new System.Drawing.Size(244, 283);
            this.CreateMemberSystem.TabIndex = 0;
            this.CreateMemberSystem.Text = "会員情報テーブル";
            this.CreateMemberSystem.UseVisualStyleBackColor = true;
            this.CreateMemberSystem.Click += new System.EventHandler(this.CreateMemberSystem_Click);
            // 
            // CreateDisplay
            // 
            this.CreateDisplay.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.CreateDisplay.Location = new System.Drawing.Point(425, 94);
            this.CreateDisplay.Name = "CreateDisplay";
            this.CreateDisplay.Size = new System.Drawing.Size(244, 283);
            this.CreateDisplay.TabIndex = 1;
            this.CreateDisplay.Text = "検索結果表示テーブル";
            this.CreateDisplay.UseVisualStyleBackColor = true;
            this.CreateDisplay.Click += new System.EventHandler(this.CreateDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27F);
            this.label1.Location = new System.Drawing.Point(258, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "テーブル作成";
            // 
            // MainGoButton
            // 
            this.MainGoButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.MainGoButton.Location = new System.Drawing.Point(691, 392);
            this.MainGoButton.Name = "MainGoButton";
            this.MainGoButton.Size = new System.Drawing.Size(97, 46);
            this.MainGoButton.TabIndex = 4;
            this.MainGoButton.Text = "mainへ";
            this.MainGoButton.UseVisualStyleBackColor = true;
            this.MainGoButton.Click += new System.EventHandler(this.MainGoButton_Click);
            // 
            // CreateTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainGoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateDisplay);
            this.Controls.Add(this.CreateMemberSystem);
            this.Name = "CreateTableForm";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateMemberSystem;
        private System.Windows.Forms.Button CreateDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainGoButton;
    }
}