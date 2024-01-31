
namespace MemberManagementSystem
{
    partial class SerchIdForm
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.AmbiguousLink = new System.Windows.Forms.LinkLabel();
            this.DecisionButton = new System.Windows.Forms.Button();
            this.GoMain_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27F);
            this.label1.Location = new System.Drawing.Point(147, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "検索IDを入力してください";
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.InputBox.Location = new System.Drawing.Point(136, 217);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(520, 37);
            this.InputBox.TabIndex = 1;
            // 
            // AmbiguousLink
            // 
            this.AmbiguousLink.AutoSize = true;
            this.AmbiguousLink.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.AmbiguousLink.Location = new System.Drawing.Point(266, 359);
            this.AmbiguousLink.Name = "AmbiguousLink";
            this.AmbiguousLink.Size = new System.Drawing.Size(245, 27);
            this.AmbiguousLink.TabIndex = 2;
            this.AmbiguousLink.TabStop = true;
            this.AmbiguousLink.Text = "IDが曖昧な方はこちら";
            this.AmbiguousLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AmbiguousLinkClicked);
            // 
            // DecisionButton
            // 
            this.DecisionButton.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.DecisionButton.Location = new System.Drawing.Point(330, 284);
            this.DecisionButton.Name = "DecisionButton";
            this.DecisionButton.Size = new System.Drawing.Size(123, 42);
            this.DecisionButton.TabIndex = 3;
            this.DecisionButton.Text = "決定";
            this.DecisionButton.UseVisualStyleBackColor = true;
            this.DecisionButton.Click += new System.EventHandler(this.DecisionButtonClick);
            // 
            // GoMain_Button
            // 
            this.GoMain_Button.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.GoMain_Button.Location = new System.Drawing.Point(691, 392);
            this.GoMain_Button.Name = "GoMain_Button";
            this.GoMain_Button.Size = new System.Drawing.Size(97, 46);
            this.GoMain_Button.TabIndex = 4;
            this.GoMain_Button.Text = "Mainへ";
            this.GoMain_Button.UseVisualStyleBackColor = true;
            this.GoMain_Button.Click += new System.EventHandler(this.GoMainButtonClick);
            // 
            // SerchIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoMain_Button);
            this.Controls.Add(this.DecisionButton);
            this.Controls.Add(this.AmbiguousLink);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label1);
            this.Name = "SerchIdForm";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.LinkLabel AmbiguousLink;
        private System.Windows.Forms.Button DecisionButton;
        private System.Windows.Forms.Button GoMain_Button;
    }
}