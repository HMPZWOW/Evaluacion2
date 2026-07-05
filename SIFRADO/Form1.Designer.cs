namespace SIFRADO
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
            txtPantalla = new TextBox();
            btnIniciar = new Button();
            txtCifrado1 = new TextBox();
            txtPantalla2 = new TextBox();
            txtCifrado2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(14, 12);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(774, 104);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextChanged += txtPantalla_TextChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(349, 143);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(111, 45);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Cifrar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtCifrado1
            // 
            txtCifrado1.Location = new Point(14, 209);
            txtCifrado1.Name = "txtCifrado1";
            txtCifrado1.Size = new Size(774, 23);
            txtCifrado1.TabIndex = 4;
            // 
            // txtPantalla2
            // 
            txtPantalla2.Location = new Point(14, 278);
            txtPantalla2.Name = "txtPantalla2";
            txtPantalla2.Size = new Size(774, 23);
            txtPantalla2.TabIndex = 5;
            txtPantalla2.TextChanged += textBox2_TextChanged;
            // 
            // txtCifrado2
            // 
            txtCifrado2.Location = new Point(14, 398);
            txtCifrado2.Name = "txtCifrado2";
            txtCifrado2.Size = new Size(774, 23);
            txtCifrado2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(349, 336);
            button1.Name = "button1";
            button1.Size = new Size(111, 46);
            button1.TabIndex = 7;
            button1.Text = "Decifrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtCifrado2);
            Controls.Add(txtPantalla2);
            Controls.Add(txtCifrado1);
            Controls.Add(btnIniciar);
            Controls.Add(txtPantalla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Button btnIniciar;
        private TextBox txtCifrado1;
        private TextBox txtPantalla2;
        private TextBox txtCifrado2;
        private Button button1;
    }
}
