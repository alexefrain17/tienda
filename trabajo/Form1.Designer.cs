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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            SuspendLayout();
            // 
            // imagen
            // 
            imagen.Image = (Image)resources.GetObject("imagen.Image");
            imagen.Location = new Point(12, 30);
            imagen.Name = "imagen";
            imagen.Size = new Size(245, 185);
            imagen.SizeMode = PictureBoxSizeMode.Zoom;
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
            // button1
            // 
            button1.Location = new Point(89, 260);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(225, 260);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(366, 260);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 296);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
    }
}