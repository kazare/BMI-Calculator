namespace BMI_Calculator
{
    partial class ImperialResultForm
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
            this.impHeightLabel = new System.Windows.Forms.Label();
            this.impWeightLabel = new System.Windows.Forms.Label();
            this.bmiNumLabel = new System.Windows.Forms.Label();
            this.bmiCatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // impHeightLabel
            // 
            this.impHeightLabel.AutoSize = true;
            this.impHeightLabel.Location = new System.Drawing.Point(187, 128);
            this.impHeightLabel.Name = "impHeightLabel";
            this.impHeightLabel.Size = new System.Drawing.Size(215, 32);
            this.impHeightLabel.TabIndex = 0;
            this.impHeightLabel.Text = "impHeightLabel";
            // 
            // impWeightLabel
            // 
            this.impWeightLabel.AutoSize = true;
            this.impWeightLabel.Location = new System.Drawing.Point(187, 213);
            this.impWeightLabel.Name = "impWeightLabel";
            this.impWeightLabel.Size = new System.Drawing.Size(221, 32);
            this.impWeightLabel.TabIndex = 1;
            this.impWeightLabel.Text = "impWeightLabel";
            // 
            // bmiNumLabel
            // 
            this.bmiNumLabel.AutoSize = true;
            this.bmiNumLabel.Location = new System.Drawing.Point(187, 298);
            this.bmiNumLabel.Name = "bmiNumLabel";
            this.bmiNumLabel.Size = new System.Drawing.Size(191, 32);
            this.bmiNumLabel.TabIndex = 5;
            this.bmiNumLabel.Text = "bmiNumLabel";
            // 
            // bmiCatLabel
            // 
            this.bmiCatLabel.AutoSize = true;
            this.bmiCatLabel.Location = new System.Drawing.Point(187, 377);
            this.bmiCatLabel.Name = "bmiCatLabel";
            this.bmiCatLabel.Size = new System.Drawing.Size(176, 32);
            this.bmiCatLabel.TabIndex = 6;
            this.bmiCatLabel.Text = "bmiCatLabel";
            // 
            // ImperialResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 587);
            this.Controls.Add(this.bmiCatLabel);
            this.Controls.Add(this.bmiNumLabel);
            this.Controls.Add(this.impWeightLabel);
            this.Controls.Add(this.impHeightLabel);
            this.Name = "ImperialResultForm";
            this.Text = "BMI Calculator - Results (Imperial)";
            this.Load += new System.EventHandler(this.resultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label impHeightLabel;
        private System.Windows.Forms.Label impWeightLabel;
        private System.Windows.Forms.Label bmiNumLabel;
        private System.Windows.Forms.Label bmiCatLabel;
    }
}