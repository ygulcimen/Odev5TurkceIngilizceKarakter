namespace Odev5TurkceIngilizceKarakter
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransform = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rtbInput.Location = new System.Drawing.Point(12, 67);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(784, 96);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a text to transform:";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(281, 171);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(209, 35);
            this.btnTransform.TabIndex = 2;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rtbOutput.Location = new System.Drawing.Point(12, 316);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(784, 96);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Stencil", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblResult.Location = new System.Drawing.Point(304, 276);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(162, 24);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "***Result***";
            this.lblResult.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(52, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(639, 167);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(111, 39);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 444);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Name = "Form1";
            this.Text = "Character Transform Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
    }
}

