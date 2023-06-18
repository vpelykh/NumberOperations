namespace NumberOperations.Forms
{
    partial class FormAriphmeticOperations
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
            this.comboBoxFirstNum = new System.Windows.Forms.ComboBox();
            this.comboBoxSecondNum = new System.Windows.Forms.ComboBox();
            this.labelFirstNum = new System.Windows.Forms.Label();
            this.labelSecondNum = new System.Windows.Forms.Label();
            this.labelFirstSystem = new System.Windows.Forms.Label();
            this.labelSecondSystem = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.resultNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxFirstNum
            // 
            this.comboBoxFirstNum.Items.AddRange(new object[] {
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9});
            this.comboBoxFirstNum.Location = new System.Drawing.Point(215, 116);
            this.comboBoxFirstNum.Name = "comboBoxFirstNum";
            this.comboBoxFirstNum.Size = new System.Drawing.Size(132, 30);
            this.comboBoxFirstNum.TabIndex = 0;
            // 
            // comboBoxSecondNum
            // 
            this.comboBoxSecondNum.Items.AddRange(new object[] {
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9});
            this.comboBoxSecondNum.Location = new System.Drawing.Point(586, 116);
            this.comboBoxSecondNum.Name = "comboBoxSecondNum";
            this.comboBoxSecondNum.Size = new System.Drawing.Size(143, 30);
            this.comboBoxSecondNum.TabIndex = 0;
            // 
            // labelFirstNum
            // 
            this.labelFirstNum.Location = new System.Drawing.Point(12, 63);
            this.labelFirstNum.Name = "labelFirstNum";
            this.labelFirstNum.Size = new System.Drawing.Size(121, 23);
            this.labelFirstNum.TabIndex = 0;
            this.labelFirstNum.Text = "Перше число";
            // 
            // labelSecondNum
            // 
            this.labelSecondNum.Location = new System.Drawing.Point(407, 63);
            this.labelSecondNum.Name = "labelSecondNum";
            this.labelSecondNum.Size = new System.Drawing.Size(121, 23);
            this.labelSecondNum.TabIndex = 0;
            this.labelSecondNum.Text = "Друге число";
            // 
            // labelFirstSystem
            // 
            this.labelFirstSystem.Location = new System.Drawing.Point(189, 63);
            this.labelFirstSystem.Name = "labelFirstSystem";
            this.labelFirstSystem.Size = new System.Drawing.Size(178, 43);
            this.labelFirstSystem.TabIndex = 0;
            this.labelFirstSystem.Text = "Система числення\n першого числа";
            this.labelFirstSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondSystem
            // 
            this.labelSecondSystem.Location = new System.Drawing.Point(570, 63);
            this.labelSecondSystem.Name = "labelSecondSystem";
            this.labelSecondSystem.Size = new System.Drawing.Size(183, 43);
            this.labelSecondSystem.TabIndex = 0;
            this.labelSecondSystem.Text = "Система числення\n другого числа";
            this.labelSecondSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(766, 63);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(155, 50);
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
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 189);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(262, 189);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(147, 32);
            this.buttonSubstract.TabIndex = 1;
            this.buttonSubstract.Text = "Відняти";
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(505, 189);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(147, 32);
            this.buttonMultiply.TabIndex = 1;
            this.buttonMultiply.Text = "Помножити";
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(755, 189);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(147, 32);
            this.buttonDivide.TabIndex = 1;
            this.buttonDivide.Text = "Поділити";
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(12, 116);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(147, 30);
            this.firstNum.TabIndex = 2;
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(388, 116);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(140, 30);
            this.secondNum.TabIndex = 3;
            // 
            // resultNum
            // 
            this.resultNum.Location = new System.Drawing.Point(781, 116);
            this.resultNum.Name = "resultNum";
            this.resultNum.Size = new System.Drawing.Size(121, 30);
            this.resultNum.TabIndex = 4;
            // 
            // FormAriphmeticOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 330);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.labelFirstNum);
            this.Controls.Add(this.labelSecondNum);
            this.Controls.Add(this.labelFirstSystem);
            this.Controls.Add(this.labelSecondSystem);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.resultNum);
            this.Controls.Add(this.comboBoxFirstNum);
            this.Controls.Add(this.comboBoxSecondNum);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAriphmeticOperations";
            this.Text = "FormAriphmeticOperations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxFirstNum;
        private System.Windows.Forms.ComboBox comboBoxSecondNum;
        private System.Windows.Forms.Label labelFirstNum;
        private System.Windows.Forms.Label labelSecondNum;
        private System.Windows.Forms.Label labelFirstSystem;
        private System.Windows.Forms.Label labelSecondSystem;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox secondNum;
        private System.Windows.Forms.TextBox resultNum;
    }
}