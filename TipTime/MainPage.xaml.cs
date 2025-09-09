namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            PorcentagemSlider.Value = 17;
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
            try
            {
                double ValorTotal = Convert.ToDouble(ValorTotalEntry.Text);
                double Porcentagem = PorcentagemSlider.Value / 100;
                /*PorcentagemGorjeta = $"{Porcentagem}";*/
                double Gorjeta = Porcentagem * ValorTotal;
                //ValorGorjetaLabel.Text = $"R$ {Gorjeta}";
                ValorGorjetaLabel.Text = Gorjeta.ToString("c");
                double ValorFinal = Gorjeta + ValorTotal;
                ValorTotalLabel.Text = $"{ValorFinal}";
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString);
                DisplayAlert("Erro.", "Por gentileza digite um valor valido.", "OK");
            }




            //Do professor Bellotti:
            /*double porcentagem = PorcentagemSlider_Value;
            double gorjeta;
            double valortotal = double..Parse(ValorTotalEntry.Text);
            //outra forma de converter double valortotal = Convert.ToDouble(ValorTotalEntry.Text);
            float = valorfinal;
            gorjeta = valortotal * (porcentagem / 100);
            ValorGorjetaLabel.Text = $"R$ {gorjeta}";
            //Estamos interpolando uma variavél que tem conteudo
            double valorfinal = valortotoal + gorjeta;
            ValorFinalLabel.Text = $"R$ {valorfinal}"*/
        }
    }

}
