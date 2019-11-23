namespace IndicadorDeProgreso
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tkbProgress = new System.Windows.Forms.TrackBar();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnPaused = new System.Windows.Forms.Button();
            this.btnNoProgress = new System.Windows.Forms.Button();
            this.btnIndeterminate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkbProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbProgress
            // 
            this.tkbProgress.LargeChange = 10;
            this.tkbProgress.Location = new System.Drawing.Point(12, 31);
            this.tkbProgress.Maximum = 100;
            this.tkbProgress.Name = "tkbProgress";
            this.tkbProgress.Size = new System.Drawing.Size(360, 45);
            this.tkbProgress.SmallChange = 5;
            this.tkbProgress.TabIndex = 0;
            this.tkbProgress.Value = 25;
            this.tkbProgress.Scroll += new System.EventHandler(this.TkbProgress_Scroll);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(12, 99);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(360, 23);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(12, 149);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(360, 23);
            this.btnError.TabIndex = 2;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // btnPaused
            // 
            this.btnPaused.Location = new System.Drawing.Point(12, 199);
            this.btnPaused.Name = "btnPaused";
            this.btnPaused.Size = new System.Drawing.Size(360, 23);
            this.btnPaused.TabIndex = 3;
            this.btnPaused.Text = "Paused";
            this.btnPaused.UseVisualStyleBackColor = true;
            this.btnPaused.Click += new System.EventHandler(this.BtnPaused_Click);
            // 
            // btnNoProgress
            // 
            this.btnNoProgress.Location = new System.Drawing.Point(12, 249);
            this.btnNoProgress.Name = "btnNoProgress";
            this.btnNoProgress.Size = new System.Drawing.Size(360, 23);
            this.btnNoProgress.TabIndex = 4;
            this.btnNoProgress.Text = "NoProgress";
            this.btnNoProgress.UseVisualStyleBackColor = true;
            this.btnNoProgress.Click += new System.EventHandler(this.BtnNoProgress_Click);
            // 
            // btnIndeterminate
            // 
            this.btnIndeterminate.Location = new System.Drawing.Point(12, 299);
            this.btnIndeterminate.Name = "btnIndeterminate";
            this.btnIndeterminate.Size = new System.Drawing.Size(360, 23);
            this.btnIndeterminate.TabIndex = 5;
            this.btnIndeterminate.Text = "Indeterminate";
            this.btnIndeterminate.UseVisualStyleBackColor = true;
            this.btnIndeterminate.Click += new System.EventHandler(this.BtnIndeterminate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnIndeterminate);
            this.Controls.Add(this.btnNoProgress);
            this.Controls.Add(this.btnPaused);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.tkbProgress);
            this.Name = "MainForm";
            this.Text = "Indicador de Progreso";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tkbProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbProgress;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnPaused;
        private System.Windows.Forms.Button btnNoProgress;
        private System.Windows.Forms.Button btnIndeterminate;
    }
}

