namespace Windows_Sim
{
    partial class Explorer
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
            textBox1 = new TextBox();
            btCrear = new Button();
            btModificar = new Button();
            btEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 50);
            webView21.Name = "webView21";
            webView21.Size = new Size(1089, 727);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 1;
            // 
            // btCrear
            // 
            btCrear.Location = new Point(315, 17);
            btCrear.Name = "btCrear";
            btCrear.Size = new Size(94, 29);
            btCrear.TabIndex = 2;
            btCrear.Text = "Crear";
            btCrear.UseVisualStyleBackColor = true;
            btCrear.Click += btCrear_Click;
            // 
            // btModificar
            // 
            btModificar.Location = new Point(437, 17);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(94, 29);
            btModificar.TabIndex = 3;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            btModificar.Click += btModificar_Click;
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(558, 17);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 29);
            btEliminar.TabIndex = 4;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // Explorer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 789);
            Controls.Add(btEliminar);
            Controls.Add(btModificar);
            Controls.Add(btCrear);
            Controls.Add(textBox1);
            Controls.Add(webView21);
            Name = "Explorer";
            Text = "Explorer";
            Load += Explorer_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox textBox1;
        private Button btCrear;
        private Button btModificar;
        private Button btEliminar;
    }
}