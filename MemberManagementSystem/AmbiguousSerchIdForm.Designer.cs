
namespace MemberManagementSystem
{
    partial class AmbiguousSerchIdForm
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
            this.SearchGoButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchGoButton
            // 
            this.SearchGoButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.SearchGoButton.Location = new System.Drawing.Point(565, 398);
            this.SearchGoButton.Name = "SearchGoButton";
            this.SearchGoButton.Size = new System.Drawing.Size(97, 46);
            this.SearchGoButton.TabIndex = 0;
            this.SearchGoButton.Text = "検索";
            this.SearchGoButton.UseVisualStyleBackColor = true;
            this.SearchGoButton.Click += new System.EventHandler(this.SearchGoClick);
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.InputBox.Location = new System.Drawing.Point(92, 365);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(694, 27);
            this.InputBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "検索したい会員IDを入力してください";
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.NextButton.Location = new System.Drawing.Point(689, 398);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(97, 46);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "戻る";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 250);
            this.dataGridView1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(6, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "検索ID";
            // 
            // AmbiguousSerchIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.SearchGoButton);
            this.Name = "AmbiguousSerchIdForm";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchGoButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}