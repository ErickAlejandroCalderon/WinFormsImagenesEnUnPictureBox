namespace WinFormsImagenesEnUnPictureBox
{
    partial class Form1
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
            pictureBoxImagenes = new PictureBox();
            buttonImagen1 = new Button();
            buttonImagen2 = new Button();
            buttonImagen3 = new Button();
            buttonImagen4 = new Button();
            labelNombre = new Label();
            labelId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenes).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImagenes
            // 
            pictureBoxImagenes.Image = Properties.Resources.Imagen_1;
            pictureBoxImagenes.Location = new Point(258, 50);
            pictureBoxImagenes.Name = "pictureBoxImagenes";
            pictureBoxImagenes.Size = new Size(626, 372);
            pictureBoxImagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagenes.TabIndex = 0;
            pictureBoxImagenes.TabStop = false;
            // 
            // buttonImagen1
            // 
            buttonImagen1.Location = new Point(150, 540);
            buttonImagen1.Name = "buttonImagen1";
            buttonImagen1.Size = new Size(112, 34);
            buttonImagen1.TabIndex = 1;
            buttonImagen1.Text = "Imagen 1";
            buttonImagen1.UseVisualStyleBackColor = true;
            buttonImagen1.Click += buttonImagen1_Click;
            // 
            // buttonImagen2
            // 
            buttonImagen2.Location = new Point(378, 540);
            buttonImagen2.Name = "buttonImagen2";
            buttonImagen2.Size = new Size(112, 34);
            buttonImagen2.TabIndex = 2;
            buttonImagen2.Text = "Imagen 2";
            buttonImagen2.UseVisualStyleBackColor = true;
            buttonImagen2.Click += buttonImagen2_Click;
            // 
            // buttonImagen3
            // 
            buttonImagen3.Location = new Point(665, 540);
            buttonImagen3.Name = "buttonImagen3";
            buttonImagen3.Size = new Size(112, 34);
            buttonImagen3.TabIndex = 3;
            buttonImagen3.Text = "Imagen 3";
            buttonImagen3.UseVisualStyleBackColor = true;
            buttonImagen3.Click += buttonImagen3_Click;
            // 
            // buttonImagen4
            // 
            buttonImagen4.Location = new Point(890, 540);
            buttonImagen4.Name = "buttonImagen4";
            buttonImagen4.Size = new Size(112, 34);
            buttonImagen4.TabIndex = 4;
            buttonImagen4.Text = "Imagen 4";
            buttonImagen4.UseVisualStyleBackColor = true;
            buttonImagen4.Click += buttonImagen4_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Yu Gothic UI", 14F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(258, 466);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(419, 38);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Calderón Álvarez Erick Alejandro";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Yu Gothic UI", 14F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(717, 466);
            labelId.Name = "labelId";
            labelId.Size = new Size(148, 38);
            labelId.TabIndex = 6;
            labelId.Text = "ID: 332250";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1210, 710);
            Controls.Add(labelId);
            Controls.Add(labelNombre);
            Controls.Add(buttonImagen4);
            Controls.Add(buttonImagen3);
            Controls.Add(buttonImagen2);
            Controls.Add(buttonImagen1);
            Controls.Add(pictureBoxImagenes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImagenes;
        private Button buttonImagen1;
        private Button buttonImagen2;
        private Button buttonImagen3;
        private Button buttonImagen4;
        private Label labelNombre;
        private Label labelId;
    }
}
