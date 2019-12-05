namespace ListView_AspectoNativo
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nativeListView1 = new ListView_AspectoNativo.NativeListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nativeListView1
            // 
            this.nativeListView1.HideSelection = false;
            this.nativeListView1.LargeImageList = this.imageList2;
            this.nativeListView1.Location = new System.Drawing.Point(12, 39);
            this.nativeListView1.Name = "nativeListView1";
            this.nativeListView1.Size = new System.Drawing.Size(360, 310);
            this.nativeListView1.SmallImageList = this.imageList1;
            this.nativeListView1.TabIndex = 1;
            this.nativeListView1.UseCompatibleStateImageBehavior = false;
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
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "9gag-icon.png");
            this.imageList2.Images.SetKeyName(1, "500px-icon.png");
            this.imageList2.Images.SetKeyName(2, "evernote-icon.png");
            this.imageList2.Images.SetKeyName(3, "facebook-messenger-icon.png");
            this.imageList2.Images.SetKeyName(4, "fb-icon.png");
            this.imageList2.Images.SetKeyName(5, "feedly-icon.png");
            this.imageList2.Images.SetKeyName(6, "firefox-icon.png");
            this.imageList2.Images.SetKeyName(7, "flipboard-icon.png");
            this.imageList2.Images.SetKeyName(8, "google-icon.png");
            this.imageList2.Images.SetKeyName(9, "google-plus-icon.png");
            this.imageList2.Images.SetKeyName(10, "ie-icon.png");
            this.imageList2.Images.SetKeyName(11, "ingress-icon.png");
            this.imageList2.Images.SetKeyName(12, "instagram-icon.png");
            this.imageList2.Images.SetKeyName(13, "office-2013-icon.png");
            this.imageList2.Images.SetKeyName(14, "opera-icon.png");
            this.imageList2.Images.SetKeyName(15, "pinterest-icon.png");
            this.imageList2.Images.SetKeyName(16, "pocket-icon.png");
            this.imageList2.Images.SetKeyName(17, "skydrive-icon.png");
            this.imageList2.Images.SetKeyName(18, "twitter-icon.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.nativeListView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainForm";
            this.Text = "Native ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private NativeListView nativeListView1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

