using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            var total = (decimal.Parse(txtTotal.Text));
            var propina = (int.Parse(txtPropina.Text));
            var noPersonas = (int.Parse(txtNoPersonas.Text));
            var totalPropina = ((total * propina) / 100);
            var totalConPropina = total + totalPropina;

            lblPropina.Detail = totalPropina.ToString("C");
            lblTotal.Detail = totalConPropina.ToString("C");
            lblPropinaPorPersona.Detail = (totalPropina / noPersonas).ToString("C");
            lblTotalPorPersona.Detail = (totalConPropina / noPersonas).ToString("C");

        }
    }
}
