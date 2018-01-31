namespace MergeFiles
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
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.buttonFile1 = new System.Windows.Forms.Button();
            this.buttonFile2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.Location = new System.Drawing.Point(48, 43);
            this.textBoxFile1.Multiline = true;
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.ReadOnly = true;
            this.textBoxFile1.Size = new System.Drawing.Size(393, 56);
            this.textBoxFile1.TabIndex = 0;
            this.textBoxFile1.Text = "Select File";
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.Location = new System.Drawing.Point(48, 105);
            this.textBoxFile2.Multiline = true;
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.ReadOnly = true;
            this.textBoxFile2.Size = new System.Drawing.Size(393, 56);
            this.textBoxFile2.TabIndex = 1;
            this.textBoxFile2.Text = "Select File";
            // 
            // buttonFile1
            // 
            this.buttonFile1.Location = new System.Drawing.Point(447, 59);
            this.buttonFile1.Name = "buttonFile1";
            this.buttonFile1.Size = new System.Drawing.Size(90, 19);
            this.buttonFile1.TabIndex = 2;
            this.buttonFile1.Text = "Select File 1";
            this.buttonFile1.UseVisualStyleBackColor = true;
            this.buttonFile1.Click += new System.EventHandler(this.buttonFile1_Click);
            // 
            // buttonFile2
            // 
            this.buttonFile2.Enabled = false;
            this.buttonFile2.Location = new System.Drawing.Point(447, 124);
            this.buttonFile2.Name = "buttonFile2";
            this.buttonFile2.Size = new System.Drawing.Size(90, 19);
            this.buttonFile2.TabIndex = 3;
            this.buttonFile2.Text = "Select File 2";
            this.buttonFile2.UseVisualStyleBackColor = true;
            this.buttonFile2.Click += new System.EventHandler(this.buttonFile2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(57, 239);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 4;
            this.buttonProcess.Text = "Process data";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 364);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonFile2);
            this.Controls.Add(this.buttonFile1);
            this.Controls.Add(this.textBoxFile2);
            this.Controls.Add(this.textBoxFile1);
            this.Name = "Form1";
            this.Text = "Compare Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.Button buttonFile1;
        private System.Windows.Forms.Button buttonFile2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonProcess;
    }
}

