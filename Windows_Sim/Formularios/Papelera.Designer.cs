namespace Windows_Sim
{
    partial class Papelera
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btborrar = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(5, 53);
            webView21.Name = "webView21";
            webView21.Size = new Size(946, 501);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // btborrar
            // 
            btborrar.Location = new Point(5, 12);
            btborrar.Name = "btborrar";
            btborrar.Size = new Size(155, 29);
            btborrar.TabIndex = 1;
            btborrar.Text = "Vaciar Papelera";
            btborrar.UseVisualStyleBackColor = true;
            btborrar.Click += btborrar_Click;
            // 
            // Papelera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 566);
            Controls.Add(btborrar);
            Controls.Add(webView21);
            Name = "Papelera";
            Text = "Papelera";
            Load += Papelera_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btborrar;
    }
}