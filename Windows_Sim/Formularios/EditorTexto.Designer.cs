namespace Windows_Sim.Formularios
{
    partial class EditorTexto
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
            richTextBox1 = new RichTextBox();
            btAbrir = new Button();
            btGuardar = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(12, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 411);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btAbrir
            // 
            btAbrir.Location = new Point(12, 2);
            btAbrir.Name = "btAbrir";
            btAbrir.Size = new Size(94, 29);
            btAbrir.TabIndex = 1;
            btAbrir.Text = "Abrir";
            btAbrir.UseVisualStyleBackColor = true;
            btAbrir.Click += btAbrir_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(112, 2);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(94, 29);
            btGuardar.TabIndex = 2;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // EditorTexto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 457);
            Controls.Add(btGuardar);
            Controls.Add(btAbrir);
            Controls.Add(richTextBox1);
            Name = "EditorTexto";
            Text = "EditorTexto";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btAbrir;
        private Button btGuardar;
    }
}