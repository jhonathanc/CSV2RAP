namespace CSV2RAP
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCSVFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectCSVFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRAPOutputPath = new System.Windows.Forms.TextBox();
            this.btnSelectOutputPath = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCSVFileName
            // 
            this.tbCSVFileName.Location = new System.Drawing.Point(102, 12);
            this.tbCSVFileName.Name = "tbCSVFileName";
            this.tbCSVFileName.Size = new System.Drawing.Size(419, 20);
            this.tbCSVFileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input CSV file";
            // 
            // btnSelectCSVFile
            // 
            this.btnSelectCSVFile.Location = new System.Drawing.Point(527, 10);
            this.btnSelectCSVFile.Name = "btnSelectCSVFile";
            this.btnSelectCSVFile.Size = new System.Drawing.Size(45, 23);
            this.btnSelectCSVFile.TabIndex = 2;
            this.btnSelectCSVFile.Text = "...";
            this.btnSelectCSVFile.UseVisualStyleBackColor = true;
            this.btnSelectCSVFile.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output RAP path";
            // 
            // tbRAPOutputPath
            // 
            this.tbRAPOutputPath.Location = new System.Drawing.Point(102, 38);
            this.tbRAPOutputPath.Name = "tbRAPOutputPath";
            this.tbRAPOutputPath.Size = new System.Drawing.Size(419, 20);
            this.tbRAPOutputPath.TabIndex = 4;
            // 
            // btnSelectOutputPath
            // 
            this.btnSelectOutputPath.Location = new System.Drawing.Point(527, 36);
            this.btnSelectOutputPath.Name = "btnSelectOutputPath";
            this.btnSelectOutputPath.Size = new System.Drawing.Size(45, 23);
            this.btnSelectOutputPath.TabIndex = 5;
            this.btnSelectOutputPath.Text = "...";
            this.btnSelectOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputPath.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(446, 64);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 94);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSelectOutputPath);
            this.Controls.Add(this.tbRAPOutputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectCSVFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCSVFileName);
            this.Name = "FormPrincipal";
            this.Text = "CSV2RAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCSVFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectCSVFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRAPOutputPath;
        private System.Windows.Forms.Button btnSelectOutputPath;
        private System.Windows.Forms.Button btnConvert;
    }
}

