
namespace NumberOperations.Forms
{
    partial class FormConvertToOtherSystem
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
            this.comboBoxFromSystem = new System.Windows.Forms.ComboBox();
            this.comboBoxToSystem = new System.Windows.Forms.ComboBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelFirstSystem = new System.Windows.Forms.Label();
            this.labelSecondSystem = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.TextBox();
            this.resultNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxFromSystem
            // 
            this.comboBoxFromSystem.Items.AddRange(new object[] {
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9});
            this.comboBoxFromSystem.Location = new System.Drawing.Point(250, 116);
            this.comboBoxFromSystem.Name = "comboBoxFromSystem";
            this.comboBoxFromSystem.Size = new System.Drawing.Size(151, 30);
            this.comboBoxFromSystem.TabIndex = 0;
            // 
            // comboBoxToSystem
            // 
            this.comboBoxToSystem.Items.AddRange(new object[] {
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9});
            this.comboBoxToSystem.Location = new System.Drawing.Point(469, 116);
            this.comboBoxToSystem.Name = "comboBoxToSystem";
            this.comboBoxToSystem.Size = new System.Drawing.Size(165, 30);
            this.comboBoxToSystem.TabIndex = 0;
            // 
            // labelNum
            // 
            this.labelNum.Location = new System.Drawing.Point(71, 67);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(121, 23);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Число";
            // 
            // labelFirstSystem
            // 
            this.labelFirstSystem.Location = new System.Drawing.Point(240, 57);
            this.labelFirstSystem.Name = "labelFirstSystem";
            this.labelFirstSystem.Size = new System.Drawing.Size(178, 43);
            this.labelFirstSystem.TabIndex = 0;
            this.labelFirstSystem.Text = "Поточна система\n числення";
            this.labelFirstSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondSystem
            // 
            this.labelSecondSystem.Location = new System.Drawing.Point(458, 57);
            this.labelSecondSystem.Name = "labelSecondSystem";
            this.labelSecondSystem.Size = new System.Drawing.Size(206, 43);
            this.labelSecondSystem.TabIndex = 0;
            this.labelSecondSystem.Text = "Результуюча система\n числення";
            this.labelSecondSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(724, 43);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(161, 70);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат\n";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelError
            // 
            this.labelError.Location = new System.Drawing.Point(189, 9);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(502, 23);
            this.labelError.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(362, 200);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(147, 32);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Конвертувати";
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(32, 116);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(160, 30);
            this.num.TabIndex = 3;
            // 
            // resultNum
            // 
            this.resultNum.Location = new System.Drawing.Point(724, 116);
            this.resultNum.Name = "resultNum";
            this.resultNum.Size = new System.Drawing.Size(161, 30);
            this.resultNum.TabIndex = 4;
            // 
            // FormConvertToOtherSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 330);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelFirstSystem);
            this.Controls.Add(this.labelSecondSystem);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.num);
            this.Controls.Add(this.resultNum);
            this.Controls.Add(this.comboBoxFromSystem);
            this.Controls.Add(this.comboBoxToSystem);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConvertToOtherSystem";
            this.Text = "FormConvertToOtherSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxFromSystem;
        private System.Windows.Forms.ComboBox comboBoxToSystem;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelFirstSystem;
        private System.Windows.Forms.Label labelSecondSystem;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox resultNum;
    }
}