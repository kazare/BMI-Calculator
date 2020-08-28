namespace BMI_Calculator
{
    partial class MetricResultForm
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
            this.bmiCatLabel = new System.Windows.Forms.Label();
            this.bmiNumLabel = new System.Windows.Forms.Label();
            this.metWeightLabel = new System.Windows.Forms.Label();
            this.metHeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bmiCatLabel
            // 
            this.bmiCatLabel.AutoSize = true;
            this.bmiCatLabel.Location = new System.Drawing.Point(201, 382);
            this.bmiCatLabel.Name = "bmiCatLabel";
            this.bmiCatLabel.Size = new System.Drawing.Size(176, 32);
            this.bmiCatLabel.TabIndex = 11;
            this.bmiCatLabel.Text = "bmiCatLabel";
            // 
            // bmiNumLabel
            // 
            this.bmiNumLabel.AutoSize = true;
            this.bmiNumLabel.Location = new System.Drawing.Point(201, 303);
            this.bmiNumLabel.Name = "bmiNumLabel";
            this.bmiNumLabel.Size = new System.Drawing.Size(191, 32);
            this.bmiNumLabel.TabIndex = 10;
            this.bmiNumLabel.Text = "bmiNumLabel";
            // 
            // metWeightLabel
            // 
            this.metWeightLabel.AutoSize = true;
            this.metWeightLabel.Location = new System.Drawing.Point(201, 213);
            this.metWeightLabel.Name = "metWeightLabel";
            this.metWeightLabel.Size = new System.Drawing.Size(222, 32);
            this.metWeightLabel.TabIndex = 8;
            this.metWeightLabel.Text = "metWeightLabel";
            // 
            // metHeightLabel
            // 
            this.metHeightLabel.AutoSize = true;
            this.metHeightLabel.Location = new System.Drawing.Point(201, 129);
            this.metHeightLabel.Name = "metHeightLabel";
            this.metHeightLabel.Size = new System.Drawing.Size(216, 32);
            this.metHeightLabel.TabIndex = 7;
            this.metHeightLabel.Text = "metHeightLabel";
            // 
            // MetricResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 587);
            this.Controls.Add(this.bmiCatLabel);
            this.Controls.Add(this.bmiNumLabel);
            this.Controls.Add(this.metWeightLabel);
            this.Controls.Add(this.metHeightLabel);
            this.Name = "MetricResultForm";
            this.Text = "BMI Calculator - Results (Metric)";
            this.Load += new System.EventHandler(this.MetricResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bmiCatLabel;
        private System.Windows.Forms.Label bmiNumLabel;
        private System.Windows.Forms.Label metWeightLabel;
        private System.Windows.Forms.Label metHeightLabel;
    }
}