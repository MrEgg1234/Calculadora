namespace Aula_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "2";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "7";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "6";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "9";
        }

        private void bt_adicao_Click(object sender, EventArgs e)
        {
            btn_visor.Text += "+";

        }
    }
}