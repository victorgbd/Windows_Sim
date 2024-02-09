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
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            panelAdmiTar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChrome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            label2.Location = new Point(43, 73);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "Navegador";
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
            panel1.Location = new Point(0, 919);
            panel1.Name = "panel1";
            panel1.Size = new Size(1472, 51);
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
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(38, 419);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 494);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(23, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 98);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 73);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 1;
            label3.Text = "Navegador";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(51, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(25, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(156, 98);
            panel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 73);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 1;
            label4.Text = "Administrador de Tareas";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(51, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 65);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // Escritorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1472, 970);
            Controls.Add(panel1);
            Controls.Add(panelChrome);
            Controls.Add(panelAdmiTar);
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Label label4;
        private PictureBox pictureBox5;
    }
}
