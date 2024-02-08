namespace Windows_Sim
{
    partial class Escritorio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escritorio));
            panelAdmiTar = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelChrome = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panelAdmiTar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChrome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelAdmiTar
            // 
            panelAdmiTar.BackColor = Color.Transparent;
            panelAdmiTar.Controls.Add(label1);
            panelAdmiTar.Controls.Add(pictureBox1);
            panelAdmiTar.Location = new Point(12, 39);
            panelAdmiTar.Name = "panelAdmiTar";
            panelAdmiTar.Size = new Size(156, 98);
            panelAdmiTar.TabIndex = 0;
            panelAdmiTar.DoubleClick += label1_Click;
            panelAdmiTar.MouseDown += panelAdmiTar_MouseDown;
            panelAdmiTar.MouseMove += panelAdmiTar_MouseMove;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 73);
            label1.Name = "label1";
            label1.Size = new Size(152, 17);
            label1.TabIndex = 1;
            label1.Text = "Administrador de Tareas";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.DoubleClick += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += label1_Click;
            // 
            // panelChrome
            // 
            panelChrome.BackColor = Color.Transparent;
            panelChrome.Controls.Add(label2);
            panelChrome.Controls.Add(pictureBox2);
            panelChrome.Location = new Point(10, 154);
            panelChrome.Name = "panelChrome";
            panelChrome.Size = new Size(158, 98);
            panelChrome.TabIndex = 1;
            panelChrome.DoubleClick += panelChrome_DoubleClick;
            panelChrome.MouseDown += panelAdmiTar_MouseDown;
            panelChrome.MouseMove += panelAdmiTar_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 1;
            label2.Text = "Chrome";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.DoubleClick += panelChrome_DoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(51, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.DoubleClick += panelChrome_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 19, 82);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 544);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 51);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(61, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // Escritorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(997, 595);
            Controls.Add(panel1);
            Controls.Add(panelChrome);
            Controls.Add(panelAdmiTar);
            Name = "Escritorio";
            Text = "CacuOS";
            panelAdmiTar.ResumeLayout(false);
            panelAdmiTar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelChrome.ResumeLayout(false);
            panelChrome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAdmiTar;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelChrome;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
    }
}
