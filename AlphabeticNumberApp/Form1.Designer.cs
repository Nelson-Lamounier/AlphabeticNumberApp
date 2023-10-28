namespace AlphabeticNumberApp
{
    partial class AlphNum
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
            this.maskedTextBoxInput = new System.Windows.Forms.MaskedTextBox();
            this.labelInpu = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.textBoxDisp = new System.Windows.Forms.TextBox();
            this.labelDisp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxInput
            // 
            this.maskedTextBoxInput.Location = new System.Drawing.Point(219, 21);
            this.maskedTextBoxInput.Mask = "000-LLL-LLLL";
            this.maskedTextBoxInput.Name = "maskedTextBoxInput";
            this.maskedTextBoxInput.Size = new System.Drawing.Size(178, 31);
            this.maskedTextBoxInput.TabIndex = 0;
            // 
            // labelInpu
            // 
            this.labelInpu.AutoSize = true;
            this.labelInpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInpu.Location = new System.Drawing.Point(12, 31);
            this.labelInpu.Name = "labelInpu";
            this.labelInpu.Size = new System.Drawing.Size(201, 16);
            this.labelInpu.TabIndex = 1;
            this.labelInpu.Text = "Enter Alphabetic Phone Number:";
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(276, 69);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(121, 28);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get Phone Number";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // textBoxDisp
            // 
            this.textBoxDisp.Location = new System.Drawing.Point(220, 136);
            this.textBoxDisp.Name = "textBoxDisp";
            this.textBoxDisp.Size = new System.Drawing.Size(177, 31);
            this.textBoxDisp.TabIndex = 3;
            // 
            // labelDisp
            // 
            this.labelDisp.AutoSize = true;
            this.labelDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisp.Location = new System.Drawing.Point(101, 144);
            this.labelDisp.Name = "labelDisp";
            this.labelDisp.Size = new System.Drawing.Size(112, 18);
            this.labelDisp.TabIndex = 4;
            this.labelDisp.Text = "Phone Number:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(15, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AlphNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(412, 210);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelDisp);
            this.Controls.Add(this.textBoxDisp);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.labelInpu);
            this.Controls.Add(this.maskedTextBoxInput);
            this.Name = "AlphNum";
            this.Text = "Alphabetic Phone Number";
            this.Load += new System.EventHandler(this.AlphNum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxInput;
        private System.Windows.Forms.Label labelInpu;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox textBoxDisp;
        private System.Windows.Forms.Label labelDisp;
        private System.Windows.Forms.Button btnExit;
    }
}

