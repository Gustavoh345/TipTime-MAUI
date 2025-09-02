namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /*private void OnCounterClicked(object sender, EventArgs e)
         {
             count++;

             if (count == 1)
                 CounterBtn.Text = $"Clicked {count} time";
             else
                 CounterBtn.Text = $"Clicked {count} times";

             SemanticScreenReader.Announce(CounterBtn.Text);
         }*/

        private void QuinzeBtn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;


        }

        private void VinteBtn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void RoundDownBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void RoundUpBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double ValorTotal = Double.Parse(ValorTotalEntry.Text);
            double Porcentagem = PorcentagemSlider.Value/100;
            double Gorjeta = PorcentagemSlider.Value * ValorTotal;
            ValorGorjetaLabel.Text = Gorjeta + "%";
            double ValorFinal = Gorjeta + ValorTotal;
        }
    }

}
