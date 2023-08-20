namespace Promedios_3010746
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double Cali1 = Convert.ToDouble(c1.Text);
            double Cali2 = Convert.ToDouble(c2.Text);
            double Cali3 = Convert.ToDouble(c3.Text);
            double Cali4 = Convert.ToDouble(c4.Text);
            double Cali5 = Convert.ToDouble(c5.Text);

            double resultado = (Cali1 + Cali2 + Cali3 + Cali4 + 334
            prom.Text = "El promedio del alumno es: " + resultado;
        }
    }
}