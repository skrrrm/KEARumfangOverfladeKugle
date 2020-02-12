namespace KEARumfangOverfladeKugle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelVolume = new System.Windows.Forms.Label();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius:";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(265, 163);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(239, 31);
            this.textBoxRadius.TabIndex = 1;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(109, 238);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(403, 53);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(104, 335);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(90, 25);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "Volume:";
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(265, 335);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(239, 31);
            this.textBoxVolume.TabIndex = 4;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(104, 414);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(141, 25);
            this.labelArea.TabIndex = 5;
            this.labelArea.Text = "Surface area:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(265, 408);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(239, 31);
            this.textBoxArea.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(642, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 521);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(109, 76);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1036);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelError;
    }
}

