namespace OpelDensoCodeFinder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxOpenFirmware = new System.Windows.Forms.TextBox();
            this.labelFirmware = new System.Windows.Forms.Label();
            this.buttonOpenFirmware = new System.Windows.Forms.Button();
            this.labelVINCode = new System.Windows.Forms.Label();
            this.textBoxVINCode = new System.Windows.Forms.TextBox();
            this.buttonFindPIN = new System.Windows.Forms.Button();
            this.labelPINCode = new System.Windows.Forms.Label();
            this.textBoxPINCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxOpenFirmware
            // 
            this.textBoxOpenFirmware.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxOpenFirmware.Location = new System.Drawing.Point(109, 28);
            this.textBoxOpenFirmware.Name = "textBoxOpenFirmware";
            this.textBoxOpenFirmware.ReadOnly = true;
            this.textBoxOpenFirmware.Size = new System.Drawing.Size(416, 26);
            this.textBoxOpenFirmware.TabIndex = 0;
            // 
            // labelFirmware
            // 
            this.labelFirmware.AutoSize = true;
            this.labelFirmware.Location = new System.Drawing.Point(12, 31);
            this.labelFirmware.Name = "labelFirmware";
            this.labelFirmware.Size = new System.Drawing.Size(91, 20);
            this.labelFirmware.TabIndex = 1;
            this.labelFirmware.Text = "Прошивка:";
            // 
            // buttonOpenFirmware
            // 
            this.buttonOpenFirmware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFirmware.Location = new System.Drawing.Point(531, 28);
            this.buttonOpenFirmware.Name = "buttonOpenFirmware";
            this.buttonOpenFirmware.Size = new System.Drawing.Size(35, 26);
            this.buttonOpenFirmware.TabIndex = 2;
            this.buttonOpenFirmware.Text = "...";
            this.buttonOpenFirmware.UseVisualStyleBackColor = true;
            this.buttonOpenFirmware.Click += new System.EventHandler(this.buttonOpenFirmware_Click);
            // 
            // labelVINCode
            // 
            this.labelVINCode.AutoSize = true;
            this.labelVINCode.Location = new System.Drawing.Point(63, 81);
            this.labelVINCode.Name = "labelVINCode";
            this.labelVINCode.Size = new System.Drawing.Size(40, 20);
            this.labelVINCode.TabIndex = 3;
            this.labelVINCode.Text = "VIN:";
            // 
            // textBoxVINCode
            // 
            this.textBoxVINCode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxVINCode.Location = new System.Drawing.Point(109, 78);
            this.textBoxVINCode.Name = "textBoxVINCode";
            this.textBoxVINCode.Size = new System.Drawing.Size(214, 26);
            this.textBoxVINCode.TabIndex = 4;
            // 
            // buttonFindPIN
            // 
            this.buttonFindPIN.Location = new System.Drawing.Point(238, 123);
            this.buttonFindPIN.Name = "buttonFindPIN";
            this.buttonFindPIN.Size = new System.Drawing.Size(158, 31);
            this.buttonFindPIN.TabIndex = 5;
            this.buttonFindPIN.Text = "Найти PIN";
            this.buttonFindPIN.UseVisualStyleBackColor = true;
            this.buttonFindPIN.Click += new System.EventHandler(this.buttonFindPIN_Click);
            // 
            // labelPINCode
            // 
            this.labelPINCode.AutoSize = true;
            this.labelPINCode.Location = new System.Drawing.Point(63, 172);
            this.labelPINCode.Name = "labelPINCode";
            this.labelPINCode.Size = new System.Drawing.Size(39, 20);
            this.labelPINCode.TabIndex = 6;
            this.labelPINCode.Text = "PIN:";
            // 
            // textBoxPINCode
            // 
            this.textBoxPINCode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxPINCode.Location = new System.Drawing.Point(109, 169);
            this.textBoxPINCode.Name = "textBoxPINCode";
            this.textBoxPINCode.ReadOnly = true;
            this.textBoxPINCode.Size = new System.Drawing.Size(214, 26);
            this.textBoxPINCode.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 214);
            this.Controls.Add(this.textBoxPINCode);
            this.Controls.Add(this.labelPINCode);
            this.Controls.Add(this.buttonFindPIN);
            this.Controls.Add(this.textBoxVINCode);
            this.Controls.Add(this.labelVINCode);
            this.Controls.Add(this.buttonOpenFirmware);
            this.Controls.Add(this.labelFirmware);
            this.Controls.Add(this.textBoxOpenFirmware);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OpelDensoCodeFinder by ButterDevelop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOpenFirmware;
        private System.Windows.Forms.Label labelFirmware;
        private System.Windows.Forms.Button buttonOpenFirmware;
        private System.Windows.Forms.Label labelVINCode;
        private System.Windows.Forms.TextBox textBoxVINCode;
        private System.Windows.Forms.Button buttonFindPIN;
        private System.Windows.Forms.Label labelPINCode;
        private System.Windows.Forms.TextBox textBoxPINCode;
    }
}

