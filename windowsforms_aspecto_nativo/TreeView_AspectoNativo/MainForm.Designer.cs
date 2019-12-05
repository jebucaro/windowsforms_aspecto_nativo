namespace TreeView_AspectoNativo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nativeTreeView1 = new TreeView_AspectoNativo.NativeTreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "9gag-icon.png");
            this.imageList1.Images.SetKeyName(1, "500px-icon.png");
            this.imageList1.Images.SetKeyName(2, "evernote-icon.png");
            this.imageList1.Images.SetKeyName(3, "facebook-messenger-icon.png");
            this.imageList1.Images.SetKeyName(4, "fb-icon.png");
            this.imageList1.Images.SetKeyName(5, "feedly-icon.png");
            this.imageList1.Images.SetKeyName(6, "firefox-icon.png");
            this.imageList1.Images.SetKeyName(7, "flipboard-icon.png");
            this.imageList1.Images.SetKeyName(8, "google-icon.png");
            this.imageList1.Images.SetKeyName(9, "google-plus-icon.png");
            this.imageList1.Images.SetKeyName(10, "ie-icon.png");
            this.imageList1.Images.SetKeyName(11, "ingress-icon.png");
            this.imageList1.Images.SetKeyName(12, "instagram-icon.png");
            this.imageList1.Images.SetKeyName(13, "office-2013-icon.png");
            this.imageList1.Images.SetKeyName(14, "opera-icon.png");
            this.imageList1.Images.SetKeyName(15, "pinterest-icon.png");
            this.imageList1.Images.SetKeyName(16, "pocket-icon.png");
            this.imageList1.Images.SetKeyName(17, "skydrive-icon.png");
            this.imageList1.Images.SetKeyName(18, "twitter-icon.png");
            // 
            // nativeTreeView1
            // 
            this.nativeTreeView1.ImageIndex = 0;
            this.nativeTreeView1.ImageList = this.imageList1;
            this.nativeTreeView1.Location = new System.Drawing.Point(12, 12);
            this.nativeTreeView1.Name = "nativeTreeView1";
            this.nativeTreeView1.SelectedImageIndex = 0;
            this.nativeTreeView1.Size = new System.Drawing.Size(360, 337);
            this.nativeTreeView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.nativeTreeView1);
            this.Name = "MainForm";
            this.Text = "Native TreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private NativeTreeView nativeTreeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

