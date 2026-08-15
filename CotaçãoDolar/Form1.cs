using System.Globalization;

namespace CotaçãoDolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object? sender, EventArgs e)
        {
           
            string usdText = txtUsd.Text.Trim().Replace(',', '.');
            string cotText = txtCotacao.Text.Trim().Replace(',', '.');

            if (!double.TryParse(usdText, NumberStyles.Number, CultureInfo.InvariantCulture, out double usd))
            {
                MessageBox.Show("Valor em US$ inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(cotText, NumberStyles.Number, CultureInfo.InvariantCulture, out double cot))
            {
                MessageBox.Show("Cotação inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = usd * cot;
            lblResultado.Text = $"Valor em R$: {resultado.ToString("N2", new CultureInfo("pt-BR"))}";
        }
    }
}
