namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;





        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
                Pantalla.Text = Pantalla.Text + "1";
            

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {

            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "x";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "x":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
            }


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }
    }
}