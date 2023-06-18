namespace NumberOperations
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnAriphmeticOperations = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnCompare);
            this.panelMenu.Controls.Add(this.btnConvert);
            this.panelMenu.Controls.Add(this.btnAriphmeticOperations);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(325, 729);
            this.panelMenu.TabIndex = 0;
            
            // 
            // btnCompare
            // 
            this.btnCompare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompare.FlatAppearance.BorderSize = 0;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.btnCompare.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompare.Location = new System.Drawing.Point(0, 245);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCompare.Size = new System.Drawing.Size(325, 62);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "   Порівняння";
            this.btnCompare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.btnConvert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConvert.Location = new System.Drawing.Point(0, 183);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnConvert.Size = new System.Drawing.Size(325, 62);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "   Конвертування";
            this.btnConvert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnAriphmeticOperations
            // 
            this.btnAriphmeticOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAriphmeticOperations.FlatAppearance.BorderSize = 0;
            this.btnAriphmeticOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAriphmeticOperations.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.btnAriphmeticOperations.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAriphmeticOperations.Location = new System.Drawing.Point(0, 121);
            this.btnAriphmeticOperations.Name = "btnAriphmeticOperations";
            this.btnAriphmeticOperations.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAriphmeticOperations.Size = new System.Drawing.Size(325, 62);
            this.btnAriphmeticOperations.TabIndex = 1;
            this.btnAriphmeticOperations.Text = "   Арифметичні дії";
            this.btnAriphmeticOperations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAriphmeticOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAriphmeticOperations.UseVisualStyleBackColor = true;
            this.btnAriphmeticOperations.Click += new System.EventHandler(this.btnAriphmeticOperations_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(325, 121);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(325, 121);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1047, 608);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(325, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1047, 121);
            this.panelTitle.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 529);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор чисел різних систем числення";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAriphmeticOperations;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitle;
    }
}
