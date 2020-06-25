namespace CASE_CONVERTER
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.btnInverseCase = new System.Windows.Forms.Button();
            this.btnAlternatingCase = new System.Windows.Forms.Button();
            this.btnSentenceCase = new System.Windows.Forms.Button();
            this.btnUpperCase = new System.Windows.Forms.Button();
            this.btnLowerCase = new System.Windows.Forms.Button();
            this.lblSourceText = new System.Windows.Forms.Label();
            this.rtxtSourceText = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnCopyToClipboard);
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 119);
            this.panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnReset.Location = new System.Drawing.Point(177, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(234, 39);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCopyToClipboard.Location = new System.Drawing.Point(449, 39);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(234, 39);
            this.btnCopyToClipboard.TabIndex = 0;
            this.btnCopyToClipboard.Text = "Copy to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordCount.ForeColor = System.Drawing.Color.White;
            this.lblWordCount.Location = new System.Drawing.Point(79, 283);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(150, 25);
            this.lblWordCount.TabIndex = 0;
            this.lblWordCount.Text = "Word Count: 0";
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterCount.ForeColor = System.Drawing.Color.White;
            this.lblCharacterCount.Location = new System.Drawing.Point(79, 251);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(193, 25);
            this.lblCharacterCount.TabIndex = 0;
            this.lblCharacterCount.Text = "Character Count: 0";
            // 
            // btnInverseCase
            // 
            this.btnInverseCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInverseCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnInverseCase.Location = new System.Drawing.Point(450, 397);
            this.btnInverseCase.Name = "btnInverseCase";
            this.btnInverseCase.Size = new System.Drawing.Size(234, 39);
            this.btnInverseCase.TabIndex = 0;
            this.btnInverseCase.Text = "InVeRsE CaSe";
            this.btnInverseCase.UseVisualStyleBackColor = true;
            this.btnInverseCase.Click += new System.EventHandler(this.btnInverseCase_Click);
            // 
            // btnAlternatingCase
            // 
            this.btnAlternatingCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlternatingCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnAlternatingCase.Location = new System.Drawing.Point(177, 397);
            this.btnAlternatingCase.Name = "btnAlternatingCase";
            this.btnAlternatingCase.Size = new System.Drawing.Size(234, 39);
            this.btnAlternatingCase.TabIndex = 0;
            this.btnAlternatingCase.Text = "aLtErNaTiNg cAsE";
            this.btnAlternatingCase.UseVisualStyleBackColor = true;
            this.btnAlternatingCase.Click += new System.EventHandler(this.btnAlternatingCase_Click);
            // 
            // btnSentenceCase
            // 
            this.btnSentenceCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSentenceCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSentenceCase.Location = new System.Drawing.Point(84, 329);
            this.btnSentenceCase.Name = "btnSentenceCase";
            this.btnSentenceCase.Size = new System.Drawing.Size(234, 39);
            this.btnSentenceCase.TabIndex = 0;
            this.btnSentenceCase.Text = "Sentence Case";
            this.btnSentenceCase.UseVisualStyleBackColor = true;
            this.btnSentenceCase.Click += new System.EventHandler(this.btnSentenceCase_Click);
            // 
            // btnUpperCase
            // 
            this.btnUpperCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnUpperCase.Location = new System.Drawing.Point(338, 329);
            this.btnUpperCase.Name = "btnUpperCase";
            this.btnUpperCase.Size = new System.Drawing.Size(234, 39);
            this.btnUpperCase.TabIndex = 9;
            this.btnUpperCase.Text = "UPPER CASE";
            this.btnUpperCase.UseVisualStyleBackColor = true;
            this.btnUpperCase.Click += new System.EventHandler(this.btnUpperCase_Click);
            // 
            // btnLowerCase
            // 
            this.btnLowerCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnLowerCase.Location = new System.Drawing.Point(596, 329);
            this.btnLowerCase.Name = "btnLowerCase";
            this.btnLowerCase.Size = new System.Drawing.Size(234, 39);
            this.btnLowerCase.TabIndex = 0;
            this.btnLowerCase.Text = "lower case";
            this.btnLowerCase.UseVisualStyleBackColor = true;
            this.btnLowerCase.Click += new System.EventHandler(this.btnLowerCase_Click);
            // 
            // lblSourceText
            // 
            this.lblSourceText.AutoSize = true;
            this.lblSourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceText.ForeColor = System.Drawing.Color.White;
            this.lblSourceText.Location = new System.Drawing.Point(333, 20);
            this.lblSourceText.Name = "lblSourceText";
            this.lblSourceText.Size = new System.Drawing.Size(215, 29);
            this.lblSourceText.TabIndex = 0;
            this.lblSourceText.Text = "Put your text below";
            // 
            // rtxtSourceText
            // 
            this.rtxtSourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSourceText.Location = new System.Drawing.Point(84, 67);
            this.rtxtSourceText.Name = "rtxtSourceText";
            this.rtxtSourceText.Size = new System.Drawing.Size(729, 170);
            this.rtxtSourceText.TabIndex = 0;
            this.rtxtSourceText.Text = "";
            this.rtxtSourceText.TextChanged += new System.EventHandler(this.rtxtSourceText_TextChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(895, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.btnInverseCase);
            this.Controls.Add(this.btnAlternatingCase);
            this.Controls.Add(this.btnSentenceCase);
            this.Controls.Add(this.btnUpperCase);
            this.Controls.Add(this.btnLowerCase);
            this.Controls.Add(this.lblSourceText);
            this.Controls.Add(this.rtxtSourceText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CASE CONVERTER";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblCharacterCount;
        private System.Windows.Forms.Button btnInverseCase;
        private System.Windows.Forms.Button btnAlternatingCase;
        private System.Windows.Forms.Button btnSentenceCase;
        private System.Windows.Forms.Button btnUpperCase;
        private System.Windows.Forms.Button btnLowerCase;
        private System.Windows.Forms.Label lblSourceText;
        private System.Windows.Forms.RichTextBox rtxtSourceText;


    }
}

