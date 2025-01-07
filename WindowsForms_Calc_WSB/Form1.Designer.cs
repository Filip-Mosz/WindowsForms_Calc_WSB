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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.staticSpine = new System.Windows.Forms.RadioButton();
            this.poundage = new System.Windows.Forms.RadioButton();
            this.arrowWeight = new System.Windows.Forms.RadioButton();
            this.arrowSpeed = new System.Windows.Forms.RadioButton();
            this.resultPrecision = new System.Windows.Forms.ComboBox();
            this.LightDarkMode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unitInput = new System.Windows.Forms.Label();
            this.unitResult = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.GroupBox();
            this.descriptionContent = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.description.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.Location = new System.Drawing.Point(303, 60);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(180, 25);
            this.result.TabIndex = 2;
            this.result.Text = "result will be here";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(213, 60);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Przelicz";
            this.button.UseVisualStyleBackColor = true;
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
            this.resultPrecision.Location = new System.Drawing.Point(456, 132);
            this.resultPrecision.Name = "resultPrecision";
            this.resultPrecision.Size = new System.Drawing.Size(121, 24);
            this.resultPrecision.TabIndex = 8;
            this.resultPrecision.Text = "precyzja wyniku";
            this.resultPrecision.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LightDarkMode
            // 
            this.LightDarkMode.AutoSize = true;
            this.LightDarkMode.Location = new System.Drawing.Point(560, 22);
            this.LightDarkMode.Name = "LightDarkMode";
            this.LightDarkMode.Size = new System.Drawing.Size(96, 20);
            this.LightDarkMode.TabIndex = 9;
            this.LightDarkMode.Text = "Dark Mode";
            this.LightDarkMode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.staticSpine);
            this.groupBox1.Controls.Add(this.poundage);
            this.groupBox1.Controls.Add(this.arrowWeight);
            this.groupBox1.Controls.Add(this.arrowSpeed);
            this.groupBox1.Location = new System.Drawing.Point(456, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 179);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.description);
            this.Controls.Add(this.unitResult);
            this.Controls.Add(this.unitInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LightDarkMode);
            this.Controls.Add(this.resultPrecision);
            this.Controls.Add(this.button);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.description.ResumeLayout(false);
            this.description.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RadioButton staticSpine;
        private System.Windows.Forms.RadioButton poundage;
        private System.Windows.Forms.RadioButton arrowWeight;
        private System.Windows.Forms.RadioButton arrowSpeed;
        private System.Windows.Forms.ComboBox resultPrecision;
        private System.Windows.Forms.CheckBox LightDarkMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label unitInput;
        private System.Windows.Forms.Label unitResult;
        private System.Windows.Forms.GroupBox description;
        private System.Windows.Forms.Label descriptionContent;
    }
}

