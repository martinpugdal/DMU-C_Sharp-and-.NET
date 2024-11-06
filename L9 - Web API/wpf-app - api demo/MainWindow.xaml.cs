using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_app___api_demo
{
    public partial class MainWindow : Window
    {
        private static readonly HttpClient client = new() { BaseAddress = new Uri("https://localhost:7261/") }; // Sæt din base URL

        public MainWindow() => InitializeComponent();

        private async void GetPersoner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var response = await client.GetStringAsync("person");
                MessageBox.Show(response, "Liste af Personer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private async void GetPersonById_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = "1"; // Hardkodet Id, men du kan hente dette fra en tekstboks
                var response = await client.GetStringAsync($"person/{id}");
                MessageBox.Show(response, "Person Detaljer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private async void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var personJson = "{ \"Id\": 3, \"Name\": \"Ny Person\", \"Age\": 30 }"; // Hardkodet person
                HttpContent person = new StringContent(personJson, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("person", person);
                MessageBox.Show(response.IsSuccessStatusCode ? "Person tilføjet!" : "Fejl i tilføjelse", "Status");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}