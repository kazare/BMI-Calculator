namespace BMI_Calculator
{
    partial class IntroForm
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
            this.metricRadio = new System.Windows.Forms.RadioButton();
            this.imperialRadio = new System.Windows.Forms.RadioButton();
            this.weightLbs = new System.Windows.Forms.NumericUpDown();
            this.imperialWeightLabel = new System.Windows.Forms.Label();
            this.imperialHeightLabel = new System.Windows.Forms.Label();
            this.heightIn = new System.Windows.Forms.NumericUpDown();
            this.heightCm = new System.Windows.Forms.NumericUpDown();
            this.metricHeight = new System.Windows.Forms.Label();
            this.metricWeight = new System.Windows.Forms.Label();
            this.weightKg = new System.Windows.Forms.NumericUpDown();
            this.imperialGroup = new System.Windows.Forms.GroupBox();
            this.metricGroup = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weightLbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightKg)).BeginInit();
            this.imperialGroup.SuspendLayout();
            this.metricGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // metricRadio
            // 
            this.metricRadio.AutoSize = true;
            this.metricRadio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.metricRadio.Location = new System.Drawing.Point(173, 59);
            this.metricRadio.Name = "metricRadio";
            this.metricRadio.Size = new System.Drawing.Size(152, 37);
            this.metricRadio.TabIndex = 0;
            this.metricRadio.Text = "Metric";
            this.metricRadio.UseVisualStyleBackColor = true;
            this.metricRadio.CheckedChanged += new System.EventHandler(this.metricRadio_CheckedChanged);
            // 
            // imperialRadio
            // 
            this.imperialRadio.AutoSize = true;
            this.imperialRadio.Checked = true;
            this.imperialRadio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imperialRadio.Location = new System.Drawing.Point(729, 59);
            this.imperialRadio.Name = "imperialRadio";
            this.imperialRadio.Size = new System.Drawing.Size(176, 37);
            this.imperialRadio.TabIndex = 1;
            this.imperialRadio.TabStop = true;
            this.imperialRadio.Text = "Imperial";
            this.imperialRadio.UseVisualStyleBackColor = true;
            this.imperialRadio.CheckedChanged += new System.EventHandler(this.imperialRadio_CheckedChanged);
            // 
            // weightLbs
            // 
            this.weightLbs.Location = new System.Drawing.Point(219, 192);
            this.weightLbs.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.weightLbs.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.weightLbs.Name = "weightLbs";
            this.weightLbs.Size = new System.Drawing.Size(120, 38);
            this.weightLbs.TabIndex = 2;
            this.weightLbs.Value = new decimal(new int[] {
            177,
            0,
            0,
            0});
            // 
            // imperialWeightLabel
            // 
            this.imperialWeightLabel.AutoSize = true;
            this.imperialWeightLabel.Location = new System.Drawing.Point(23, 192);
            this.imperialWeightLabel.Name = "imperialWeightLabel";
            this.imperialWeightLabel.Size = new System.Drawing.Size(166, 32);
            this.imperialWeightLabel.TabIndex = 3;
            this.imperialWeightLabel.Text = "Weight (lbs)";
            // 
            // imperialHeightLabel
            // 
            this.imperialHeightLabel.AutoSize = true;
            this.imperialHeightLabel.Location = new System.Drawing.Point(23, 81);
            this.imperialHeightLabel.Name = "imperialHeightLabel";
            this.imperialHeightLabel.Size = new System.Drawing.Size(146, 32);
            this.imperialHeightLabel.TabIndex = 4;
            this.imperialHeightLabel.Text = "Height (in)";
            // 
            // heightIn
            // 
            this.heightIn.Location = new System.Drawing.Point(219, 81);
            this.heightIn.Minimum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.heightIn.Name = "heightIn";
            this.heightIn.Size = new System.Drawing.Size(120, 38);
            this.heightIn.TabIndex = 5;
            this.heightIn.Value = new decimal(new int[] {
            63,
            0,
            0,
            0});
            // 
            // heightCm
            // 
            this.heightCm.Location = new System.Drawing.Point(205, 79);
            this.heightCm.Maximum = new decimal(new int[] {
            205,
            0,
            0,
            0});
            this.heightCm.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.heightCm.Name = "heightCm";
            this.heightCm.Size = new System.Drawing.Size(120, 38);
            this.heightCm.TabIndex = 9;
            this.heightCm.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // metricHeight
            // 
            this.metricHeight.AutoSize = true;
            this.metricHeight.Location = new System.Drawing.Point(9, 79);
            this.metricHeight.Name = "metricHeight";
            this.metricHeight.Size = new System.Drawing.Size(160, 32);
            this.metricHeight.TabIndex = 8;
            this.metricHeight.Text = "Height (cm)";
            // 
            // metricWeight
            // 
            this.metricWeight.AutoSize = true;
            this.metricWeight.Location = new System.Drawing.Point(9, 190);
            this.metricWeight.Name = "metricWeight";
            this.metricWeight.Size = new System.Drawing.Size(159, 32);
            this.metricWeight.TabIndex = 7;
            this.metricWeight.Text = "Weight (kg)";
            // 
            // weightKg
            // 
            this.weightKg.Location = new System.Drawing.Point(205, 190);
            this.weightKg.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.weightKg.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.weightKg.Name = "weightKg";
            this.weightKg.Size = new System.Drawing.Size(120, 38);
            this.weightKg.TabIndex = 6;
            this.weightKg.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // imperialGroup
            // 
            this.imperialGroup.Controls.Add(this.imperialHeightLabel);
            this.imperialGroup.Controls.Add(this.weightLbs);
            this.imperialGroup.Controls.Add(this.imperialWeightLabel);
            this.imperialGroup.Controls.Add(this.heightIn);
            this.imperialGroup.Location = new System.Drawing.Point(610, 123);
            this.imperialGroup.Name = "imperialGroup";
            this.imperialGroup.Size = new System.Drawing.Size(364, 320);
            this.imperialGroup.TabIndex = 10;
            this.imperialGroup.TabStop = false;
            // 
            // metricGroup
            // 
            this.metricGroup.Controls.Add(this.metricHeight);
            this.metricGroup.Controls.Add(this.weightKg);
            this.metricGroup.Controls.Add(this.heightCm);
            this.metricGroup.Controls.Add(this.metricWeight);
            this.metricGroup.Enabled = false;
            this.metricGroup.Location = new System.Drawing.Point(71, 142);
            this.metricGroup.Name = "metricGroup";
            this.metricGroup.Size = new System.Drawing.Size(358, 301);
            this.metricGroup.TabIndex = 11;
            this.metricGroup.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submitButton.Location = new System.Drawing.Point(401, 513);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(210, 88);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 665);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.metricGroup);
            this.Controls.Add(this.imperialGroup);
            this.Controls.Add(this.imperialRadio);
            this.Controls.Add(this.metricRadio);
            this.Name = "IntroForm";
            this.Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.weightLbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightKg)).EndInit();
            this.imperialGroup.ResumeLayout(false);
            this.imperialGroup.PerformLayout();
            this.metricGroup.ResumeLayout(false);
            this.metricGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton metricRadio;
        private System.Windows.Forms.RadioButton imperialRadio;
        private System.Windows.Forms.NumericUpDown weightLbs;
        private System.Windows.Forms.Label imperialWeightLabel;
        private System.Windows.Forms.Label imperialHeightLabel;
        private System.Windows.Forms.NumericUpDown heightIn;
        private System.Windows.Forms.NumericUpDown heightCm;
        private System.Windows.Forms.Label metricHeight;
        private System.Windows.Forms.Label metricWeight;
        private System.Windows.Forms.NumericUpDown weightKg;
        private System.Windows.Forms.GroupBox imperialGroup;
        private System.Windows.Forms.GroupBox metricGroup;
        private System.Windows.Forms.Button submitButton;
    }
}

