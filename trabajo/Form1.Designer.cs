namespace trabajo
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            imagen = new PictureBox();
            nom = new Label();
            INSER = new TextBox();
            CONTRA = new Label();
            CMMM = new TextBox();
            uno = new Button();
            DOS = new Button();
            TRES = new Button();
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            SuspendLayout();
            // 
            // imagen
            // 
            imagen.Image = (Image)resources.GetObject("imagen.Image");
            imagen.Location = new Point(12, 30);
            imagen.Name = "imagen";
            imagen.Size = new Size(245, 213);
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen.TabIndex = 0;
            imagen.TabStop = false;
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            nom.Location = new Point(263, 30);
            nom.Name = "nom";
            nom.Size = new Size(104, 30);
            nom.TabIndex = 1;
            nom.Text = "NOMBRE";
            // 
            // INSER
            // 
            INSER.Location = new Point(265, 82);
            INSER.Name = "INSER";
            INSER.Size = new Size(224, 23);
            INSER.TabIndex = 2;
            // 
            // CONTRA
            // 
            CONTRA.AutoSize = true;
            CONTRA.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CONTRA.Location = new Point(263, 127);
            CONTRA.Name = "CONTRA";
            CONTRA.Size = new Size(155, 30);
            CONTRA.TabIndex = 3;
            CONTRA.Text = "CONTRASEÑA";
            // 
            // CMMM
            // 
            CMMM.Location = new Point(265, 192);
            CMMM.Name = "CMMM";
            CMMM.Size = new Size(224, 23);
            CMMM.TabIndex = 4;
            // 
            // uno
            // 
            uno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            uno.Location = new Point(72, 260);
            uno.Name = "uno";
            uno.Size = new Size(132, 23);
            uno.TabIndex = 5;
            uno.Text = "CREAR USUSARIO";
            uno.UseVisualStyleBackColor = true;
            uno.Click += uno_Click;
            // 
            // DOS
            // 
            DOS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DOS.Location = new Point(220, 261);
            DOS.Name = "DOS";
            DOS.Size = new Size(115, 23);
            DOS.TabIndex = 6;
            DOS.Text = "INGRESAR";
            DOS.UseVisualStyleBackColor = true;
            // 
            // TRES
            // 
            TRES.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TRES.Location = new Point(367, 261);
            TRES.Name = "TRES";
            TRES.Size = new Size(115, 23);
            TRES.TabIndex = 7;
            TRES.Text = "SALIR";
            TRES.UseVisualStyleBackColor = true;
            TRES.Click += TRES_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 296);
            Controls.Add(TRES);
            Controls.Add(DOS);
            Controls.Add(uno);
            Controls.Add(CMMM);
            Controls.Add(CONTRA);
            Controls.Add(INSER);
            Controls.Add(nom);
            Controls.Add(imagen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            Text = "TIENDA";
            ((System.ComponentModel.ISupportInitialize)imagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imagen;
        private Label nom;
        private TextBox INSER;
        private Label CONTRA;
        private TextBox CMMM;
        private Button uno;
        private Button DOS;
        private Button TRES;
    }
}