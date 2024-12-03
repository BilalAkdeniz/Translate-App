using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TranslateApp
{
    public partial class TranslateApp : Form
    {
        private const string baseUrl = "http://api.mymemory.translated.net";
        private HttpClient httpClient;

        public TranslateApp()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textInput.BorderRadius = 20;
            TextOutput.BorderRadius = 20;
            cmbSourceLang.BorderRadius = 20;
            cmbTargetLang.BorderRadius = 20;
            cmbSourceLang.Items.AddRange(new string[] { "tr", "en", "es", "fr", "de" });
            cmbTargetLang.Items.AddRange(new string[] { "tr", "en", "es", "fr", "de" });
            cmbSourceLang.SelectedIndex = 0;
            cmbTargetLang.SelectedIndex = 1;
        }

        private async void translateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(textInput.Text, cmbSourceLang.SelectedItem.ToString(), cmbTargetLang.SelectedItem.ToString());
                TextOutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen daha sonra tekrar deneyiniz. Hata : \r\n" + ex);
                throw;
            }
        }

        private void TextOutput_TextChanged(object sender, EventArgs e)
        {


        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("responseData")]
        public TranslationData ResponseData { get; set; }

        public string TranslatedText => ResponseData.TranslatedText;
    }

    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
    }
}
