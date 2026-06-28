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
            lblCifrado = new Label();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(14, 17);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(774, 104);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextChanged += txtPantalla_TextChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(339, 384);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(111, 45);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "button1";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblCifrado
            // 
            lblCifrado.AutoSize = true;
            lblCifrado.Location = new Point(379, 241);
            lblCifrado.Name = "lblCifrado";
            lblCifrado.Size = new Size(38, 15);
            lblCifrado.TabIndex = 2;
            lblCifrado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCifrado);
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
        private Label lblCifrado;
    }
}
