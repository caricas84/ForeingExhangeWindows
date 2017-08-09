using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForeingExhangeWindows
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ConvertButton.Clicked += ConvertButton_Clicked;
        }
        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PesosEntry.Text))
            {
                DisplayAlert("Error", "You must enter a value in pesos.", "Accept");
                return;
            }

            var pesos = decimal.Parse(PesosEntry.Text);

            var dollars = pesos / 2994.01198M;
            var euros = pesos / 3518.11377M;
            var pounds = pesos / 3890.41916M;

            DollarsEntry.Text = string.Format("{0:C2}", dollars);
            EurosEntry.Text = string.Format("{0:C2}", euros);
            PoundsEntry.Text = string.Format("{0:C2}", pounds);
        }
    }
}
