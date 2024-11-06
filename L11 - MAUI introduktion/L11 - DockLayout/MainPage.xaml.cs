namespace L11___DockLayout
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Hent knappen som blev trykket
            Button button = (Button)sender;

            // Tilføj knapteksten til en ny linje i editoren
            MainEditor.Text += button.Text + "\n";
        }
    }

}
