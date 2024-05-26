namespace Checksum_Check
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExpectedChecksum = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cmbHashAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtCalculatedChecksum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtExpectedChecksum
            // 
            this.txtExpectedChecksum.Location = new System.Drawing.Point(397, 12);
            this.txtExpectedChecksum.Name = "txtExpectedChecksum";
            this.txtExpectedChecksum.Size = new System.Drawing.Size(388, 20);
            this.txtExpectedChecksum.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 21);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Durchsuchen";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(107, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(284, 20);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Click += new System.EventHandler(this.Form1_Load);
            // 
            // cmbHashAlgorithm
            // 
            this.cmbHashAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHashAlgorithm.FormattingEnabled = true;
            this.cmbHashAlgorithm.Location = new System.Drawing.Point(791, 11);
            this.cmbHashAlgorithm.Name = "cmbHashAlgorithm";
            this.cmbHashAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cmbHashAlgorithm.TabIndex = 3;
            this.cmbHashAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbHashAlgorithm.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 39);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(394, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label1";
            // 
            // txtCalculatedChecksum
            // 
            this.txtCalculatedChecksum.Location = new System.Drawing.Point(397, 42);
            this.txtCalculatedChecksum.Name = "txtCalculatedChecksum";
            this.txtCalculatedChecksum.Size = new System.Drawing.Size(388, 20);
            this.txtCalculatedChecksum.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 124);
            this.Controls.Add(this.txtCalculatedChecksum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbHashAlgorithm);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtExpectedChecksum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load); // Dies stellt sicher, dass Form1_Load beim Laden des Formulars aufgerufen wird.
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpectedChecksum;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.ComboBox cmbHashAlgorithm;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtCalculatedChecksum;
    }
}

