namespace SIFRADO
{
    public partial class Form1 : Form
    {
        public List<string> abecedario;
        public List<string> caracteres;

        public Form1()
        {
            InitializeComponent();
            abecedario = ["a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G",
                "h", "H", "i", "I", "j", "J", "k", "K", "l", "L", "m", "M", "n", "N", "o", "O", "p", "P",
                "q", "Q", "r", "R", "s", "S", "t", "T", "u", "U", "v", "V", "w", "W", "x", "X", "y", "Y",
                "z", "Z"];
            caracteres = ["1", "2", "3", "4", "5", "6", "7, 8", "9",
                "#", "$", "%", "/", "=", "?", "¿","{","}","+","-","<"
                ,">","[","]","-","^"];

        }
        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lblCifrado.Text = "";
            int encontre = -1;
            string resultado = "";

            for (int i = 0; i < txtPantalla.Text.Length; i++)
            {
                // lblCifrado.Text += "..."  +  txtPantalla.Text[i];

                for (int j = 0; j < abecedario.Count; j++)
                {
                    string variable = "" + txtPantalla.Text[i];

                    if (variable == abecedario[j])
                    {
                        encontre = j;
                    }
                }
                resultado += caracteres[encontre];
            }

            lblCifrado.Text = resultado;
        }

       

       
    }
}
