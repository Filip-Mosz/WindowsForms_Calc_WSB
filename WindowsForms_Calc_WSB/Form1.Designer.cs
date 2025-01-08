namespace WindowsForms_Calc_WSB
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.staticSpine = new System.Windows.Forms.RadioButton();
            this.poundage = new System.Windows.Forms.RadioButton();
            this.arrowWeight = new System.Windows.Forms.RadioButton();
            this.arrowSpeed = new System.Windows.Forms.RadioButton();
            this.resultPrecision = new System.Windows.Forms.ComboBox();
            this.DarkModeCheckbox = new System.Windows.Forms.CheckBox();
            this.calculationGroup = new System.Windows.Forms.GroupBox();
            this.unitInput = new System.Windows.Forms.Label();
            this.unitResult = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.GroupBox();
            this.descriptionContent = new System.Windows.Forms.Label();
            this.exchangeUnits = new System.Windows.Forms.Button();
            this.calculationGroup.SuspendLayout();
            this.description.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(85, 61);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 22);
            this.inputBox.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultLabel.Location = new System.Drawing.Point(303, 60);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(180, 25);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "result will be here";
            // 
            // calculateButton
            // 
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.calculateButton.Location = new System.Drawing.Point(215, 60);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 27);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Przelicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // staticSpine
            // 
            this.staticSpine.AutoSize = true;
            this.staticSpine.Location = new System.Drawing.Point(23, 21);
            this.staticSpine.Name = "staticSpine";
            this.staticSpine.Size = new System.Drawing.Size(111, 20);
            this.staticSpine.TabIndex = 4;
            this.staticSpine.TabStop = true;
            this.staticSpine.Text = "spin statyczny";
            this.staticSpine.UseVisualStyleBackColor = true;
            this.staticSpine.CheckedChanged += new System.EventHandler(this.staticSpine_CheckedChanged);
            // 
            // poundage
            // 
            this.poundage.AutoSize = true;
            this.poundage.Location = new System.Drawing.Point(23, 58);
            this.poundage.Name = "poundage";
            this.poundage.Size = new System.Drawing.Size(82, 20);
            this.poundage.TabIndex = 5;
            this.poundage.TabStop = true;
            this.poundage.Text = "siła łuku";
            this.poundage.UseVisualStyleBackColor = true;
            // 
            // arrowWeight
            // 
            this.arrowWeight.AutoSize = true;
            this.arrowWeight.Location = new System.Drawing.Point(23, 97);
            this.arrowWeight.Name = "arrowWeight";
            this.arrowWeight.Size = new System.Drawing.Size(105, 20);
            this.arrowWeight.TabIndex = 6;
            this.arrowWeight.TabStop = true;
            this.arrowWeight.Text = "waga strzały";
            this.arrowWeight.UseVisualStyleBackColor = true;
            // 
            // arrowSpeed
            // 
            this.arrowSpeed.AutoSize = true;
            this.arrowSpeed.Location = new System.Drawing.Point(23, 136);
            this.arrowSpeed.Name = "arrowSpeed";
            this.arrowSpeed.Size = new System.Drawing.Size(129, 20);
            this.arrowSpeed.TabIndex = 7;
            this.arrowSpeed.TabStop = true;
            this.arrowSpeed.Text = "prędkość strzały";
            this.arrowSpeed.UseVisualStyleBackColor = true;
            // 
            // resultPrecision
            // 
            this.resultPrecision.FormattingEnabled = true;
            this.resultPrecision.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.resultPrecision.Location = new System.Drawing.Point(456, 132);
            this.resultPrecision.Name = "resultPrecision";
            this.resultPrecision.Size = new System.Drawing.Size(134, 24);
            this.resultPrecision.TabIndex = 8;
            this.resultPrecision.Text = "precyzja wyniku";
            this.resultPrecision.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DarkModeCheckbox
            // 
            this.DarkModeCheckbox.AutoSize = true;
            this.DarkModeCheckbox.Location = new System.Drawing.Point(560, 22);
            this.DarkModeCheckbox.Name = "DarkModeCheckbox";
            this.DarkModeCheckbox.Size = new System.Drawing.Size(105, 20);
            this.DarkModeCheckbox.TabIndex = 9;
            this.DarkModeCheckbox.Text = "Tryb Ciemny";
            this.DarkModeCheckbox.UseVisualStyleBackColor = true;
            this.DarkModeCheckbox.CheckedChanged += new System.EventHandler(this.DarkModeCheckbox_CheckedChanged);
            // 
            // calculationGroup
            // 
            this.calculationGroup.Controls.Add(this.staticSpine);
            this.calculationGroup.Controls.Add(this.poundage);
            this.calculationGroup.Controls.Add(this.arrowWeight);
            this.calculationGroup.Controls.Add(this.arrowSpeed);
            this.calculationGroup.Location = new System.Drawing.Point(456, 210);
            this.calculationGroup.Name = "calculationGroup";
            this.calculationGroup.Size = new System.Drawing.Size(200, 179);
            this.calculationGroup.TabIndex = 10;
            this.calculationGroup.TabStop = false;
            this.calculationGroup.Text = "groupBox1";
            // 
            // unitInput
            // 
            this.unitInput.AutoSize = true;
            this.unitInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitInput.Location = new System.Drawing.Point(80, 20);
            this.unitInput.Name = "unitInput";
            this.unitInput.Size = new System.Drawing.Size(94, 20);
            this.unitInput.TabIndex = 11;
            this.unitInput.Text = "jednostka 1";
            // 
            // unitResult
            // 
            this.unitResult.AutoSize = true;
            this.unitResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitResult.Location = new System.Drawing.Point(306, 20);
            this.unitResult.Name = "unitResult";
            this.unitResult.Size = new System.Drawing.Size(94, 20);
            this.unitResult.TabIndex = 12;
            this.unitResult.Text = " jednostka2";
            // 
            // description
            // 
            this.description.Controls.Add(this.descriptionContent);
            this.description.Location = new System.Drawing.Point(84, 132);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(332, 257);
            this.description.TabIndex = 13;
            this.description.TabStop = false;
            this.description.Text = "Opis";
            // 
            // descriptionContent
            // 
            this.descriptionContent.AutoSize = true;
            this.descriptionContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionContent.Location = new System.Drawing.Point(7, 31);
            this.descriptionContent.Name = "descriptionContent";
            this.descriptionContent.Size = new System.Drawing.Size(94, 20);
            this.descriptionContent.TabIndex = 13;
            this.descriptionContent.Text = " jednostka2";
            // 
            // exchangeUnits
            // 
            this.exchangeUnits.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exchangeUnits.Location = new System.Drawing.Point(240, 16);
            this.exchangeUnits.Name = "exchangeUnits";
            this.exchangeUnits.Size = new System.Drawing.Size(25, 25);
            this.exchangeUnits.TabIndex = 14;
            this.exchangeUnits.Text = "↔";
            this.exchangeUnits.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 453);
            this.Controls.Add(this.exchangeUnits);
            this.Controls.Add(this.description);
            this.Controls.Add(this.unitResult);
            this.Controls.Add(this.unitInput);
            this.Controls.Add(this.calculationGroup);
            this.Controls.Add(this.DarkModeCheckbox);
            this.Controls.Add(this.resultPrecision);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.inputBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.calculationGroup.ResumeLayout(false);
            this.calculationGroup.PerformLayout();
            this.description.ResumeLayout(false);
            this.description.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RadioButton staticSpine;
        private System.Windows.Forms.RadioButton poundage;
        private System.Windows.Forms.RadioButton arrowWeight;
        private System.Windows.Forms.RadioButton arrowSpeed;
        private System.Windows.Forms.ComboBox resultPrecision;
        private System.Windows.Forms.CheckBox DarkModeCheckbox;
        private System.Windows.Forms.GroupBox calculationGroup;
        private System.Windows.Forms.Label unitInput;
        private System.Windows.Forms.Label unitResult;
        private System.Windows.Forms.GroupBox description;
        private System.Windows.Forms.Label descriptionContent;
        private System.Windows.Forms.Button exchangeUnits;
    }
}

