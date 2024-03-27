namespace Aula_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            a = Convert.ToDouble(txt_valorA.Text);
            b = Convert.ToDouble(txt_valorB.Text);
            soma = a + b;

            txt_result.Text = Convert.ToString(soma);

            lbl_sinal.Text = "+";
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_sub_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            a = Convert.ToDouble(txt_valorA.Text);
            b = Convert.ToDouble(txt_valorB.Text);
            soma = a - b;

            txt_result.Text = Convert.ToString(soma);

            lbl_sinal.Text = "-";
        }


        private void bt_mult_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            a = Convert.ToDouble(txt_valorA.Text);
            b = Convert.ToDouble(txt_valorB.Text);
            soma = a * b;

            txt_result.Text = Convert.ToString(soma);

            lbl_sinal.Text = "X";
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            a = Convert.ToDouble(txt_valorA.Text);
            b = Convert.ToDouble(txt_valorB.Text);
            soma = a / b;

            txt_result.Text = Convert.ToString(soma);

            lbl_sinal.Text = "/";
        }

        private void lbl_sinal_Click(object sender, EventArgs e)
        {

        }

        private void txt_valorA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}