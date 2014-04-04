namespace Question_Generator_Mini
{
    partial class frmMain
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
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtOutputText = new System.Windows.Forms.TextBox();
            this.btnParseSentence = new System.Windows.Forms.Button();
            this.btnTokenize = new System.Windows.Forms.Button();
            this.btnPOSTag = new System.Windows.Forms.Button();
            this.btnGenerateInterogative = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(12, 12);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(478, 185);
            this.txtInputText.TabIndex = 0;
            // 
            // txtOutputText
            // 
            this.txtOutputText.Location = new System.Drawing.Point(12, 270);
            this.txtOutputText.Multiline = true;
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.Size = new System.Drawing.Size(743, 106);
            this.txtOutputText.TabIndex = 1;
            // 
            // btnParseSentence
            // 
            this.btnParseSentence.Location = new System.Drawing.Point(13, 204);
            this.btnParseSentence.Name = "btnParseSentence";
            this.btnParseSentence.Size = new System.Drawing.Size(151, 35);
            this.btnParseSentence.TabIndex = 2;
            this.btnParseSentence.Text = "Parse Sentence";
            this.btnParseSentence.UseVisualStyleBackColor = true;
            this.btnParseSentence.Click += new System.EventHandler(this.btnParseSentence_Click);
            // 
            // btnTokenize
            // 
            this.btnTokenize.Location = new System.Drawing.Point(189, 204);
            this.btnTokenize.Name = "btnTokenize";
            this.btnTokenize.Size = new System.Drawing.Size(151, 35);
            this.btnTokenize.TabIndex = 3;
            this.btnTokenize.Text = "Tokenize";
            this.btnTokenize.UseVisualStyleBackColor = true;
            // 
            // btnPOSTag
            // 
            this.btnPOSTag.Location = new System.Drawing.Point(367, 204);
            this.btnPOSTag.Name = "btnPOSTag";
            this.btnPOSTag.Size = new System.Drawing.Size(151, 35);
            this.btnPOSTag.TabIndex = 4;
            this.btnPOSTag.Text = "POS Tag";
            this.btnPOSTag.UseVisualStyleBackColor = true;
            // 
            // btnGenerateInterogative
            // 
            this.btnGenerateInterogative.Location = new System.Drawing.Point(543, 204);
            this.btnGenerateInterogative.Name = "btnGenerateInterogative";
            this.btnGenerateInterogative.Size = new System.Drawing.Size(151, 35);
            this.btnGenerateInterogative.TabIndex = 5;
            this.btnGenerateInterogative.Text = "Generate Interogative";
            this.btnGenerateInterogative.UseVisualStyleBackColor = true;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(496, 12);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(151, 35);
            this.btnInput.TabIndex = 6;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 388);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnGenerateInterogative);
            this.Controls.Add(this.btnPOSTag);
            this.Controls.Add(this.btnTokenize);
            this.Controls.Add(this.btnParseSentence);
            this.Controls.Add(this.txtOutputText);
            this.Controls.Add(this.txtInputText);
            this.Name = "frmMain";
            this.Text = "Question Generator Mini";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtOutputText;
        private System.Windows.Forms.Button btnParseSentence;
        private System.Windows.Forms.Button btnTokenize;
        private System.Windows.Forms.Button btnPOSTag;
        private System.Windows.Forms.Button btnGenerateInterogative;
        private System.Windows.Forms.Button btnInput;
    }
}