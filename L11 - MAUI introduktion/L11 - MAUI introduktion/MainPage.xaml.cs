namespace L11___MAUI_introduktion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //SWAP1.Clicked += swap;
            //SWAP2.Clicked += swap;
        }

        private async void swap(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Grid grid = (Grid)button.Parent;

            if (button == SWAP1)
            {
                (L1.Text, L0.Text) = (L0.Text, L1.Text);
            }
            else if (button == SWAP2)
            {
                (L3.Text, L2.Text) = (L2.Text, L3.Text);
            }
        }
    }

}
