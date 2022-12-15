namespace RemoveDup
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InputBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputRTB = new System.Windows.Forms.RichTextBox();
            this.OutputRTB = new System.Windows.Forms.RichTextBox();
            this.OutputBrowse = new System.Windows.Forms.Button();
            this.ProceedBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InputBrowse
            // 
            this.InputBrowse.Location = new System.Drawing.Point(538, 23);
            this.InputBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputBrowse.Name = "InputBrowse";
            this.InputBrowse.Size = new System.Drawing.Size(77, 27);
            this.InputBrowse.TabIndex = 0;
            this.InputBrowse.Text = "Browse";
            this.InputBrowse.UseVisualStyleBackColor = true;
            this.InputBrowse.Click += new System.EventHandler(this.InputBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // InputRTB
            // 
            this.InputRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputRTB.Location = new System.Drawing.Point(68, 27);
            this.InputRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputRTB.Multiline = false;
            this.InputRTB.Name = "InputRTB";
            this.InputRTB.Size = new System.Drawing.Size(462, 24);
            this.InputRTB.TabIndex = 3;
            this.InputRTB.Text = "";
            // 
            // OutputRTB
            // 
            this.OutputRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputRTB.Location = new System.Drawing.Point(68, 62);
            this.OutputRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutputRTB.Multiline = false;
            this.OutputRTB.Name = "OutputRTB";
            this.OutputRTB.Size = new System.Drawing.Size(462, 24);
            this.OutputRTB.TabIndex = 4;
            this.OutputRTB.Text = "";
            // 
            // OutputBrowse
            // 
            this.OutputBrowse.Location = new System.Drawing.Point(538, 59);
            this.OutputBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutputBrowse.Name = "OutputBrowse";
            this.OutputBrowse.Size = new System.Drawing.Size(77, 27);
            this.OutputBrowse.TabIndex = 5;
            this.OutputBrowse.Text = "Browse";
            this.OutputBrowse.UseVisualStyleBackColor = true;
            this.OutputBrowse.Click += new System.EventHandler(this.OutputBrowse_Click);
            // 
            // ProceedBtn
            // 
            this.ProceedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProceedBtn.Location = new System.Drawing.Point(523, 126);
            this.ProceedBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProceedBtn.Name = "ProceedBtn";
            this.ProceedBtn.Size = new System.Drawing.Size(105, 33);
            this.ProceedBtn.TabIndex = 6;
            this.ProceedBtn.Text = "Proceed";
            this.ProceedBtn.UseVisualStyleBackColor = true;
            this.ProceedBtn.Click += new System.EventHandler(this.ProceedBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutputBrowse);
            this.groupBox1.Controls.Add(this.OutputRTB);
            this.groupBox1.Controls.Add(this.InputRTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InputBrowse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(628, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 166);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProceedBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Remove Duplicate Lines";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button InputBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox InputRTB;
        private System.Windows.Forms.RichTextBox OutputRTB;
        private System.Windows.Forms.Button OutputBrowse;
        private System.Windows.Forms.Button ProceedBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

