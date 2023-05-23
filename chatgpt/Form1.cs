using System.CodeDom;
using System.Text;
using System.Text.Json;

namespace chatgpt
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            lblresult.Text = "";
            richTextBox1.Visible = false;
            richTextBox1.ReadOnly = true;
            lblresult.ReadOnly = true;
        }

        async Task pergunta(string prompt)
        {
            string apiKey = "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";




            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);
                var response = await client.PostAsync("https://api.openai.com/v1/completions",
                new StringContent("{\"model\": \"text-davinci-003\", \"prompt\": \"" + prompt + "\", \"temperature\": 0, \"max_tokens\": 1024}", Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    Resposta data = JsonSerializer.Deserialize<Resposta>(responseString);
                    Array.ForEach(data.choices.ToArray(), (item) => lblresult.Text = item.text);
                    //rtxHist.ForeColor = Color.Green;
                    richTextBox1.Text = richTextBox1.Text + "R: " + lblresult.Text + "\n";
                }
                else
                {
                    lblresult.Text = "Ocorreu um erro ao enviar a pergunta.";
                }
            }
        }
        class Resposta
        {
            public List<Choice> choices { get; set; }
            public class Choice
            {
                public string text { get; set; }
            }


        }
        public class cont
        {
            public int cnt { get; set; }
        }


        private async void btnPesq_Click(object sender, EventArgs e)
        {
            var prompt = rtxPesq.Text;
            if (rtxPesq.Text == null || rtxPesq.Text == "")
            {
                lblresult.Text = "Por favor informar a pergunta";
            }
            else
            {
                richTextBox1.ForeColor = Color.Green;
                richTextBox1.Text =  richTextBox1.Text + "P: " + prompt;



                rtxPesq.Text = "";
                lblresult.Text = "Pesquisando...";
                await pergunta(prompt);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Visible == false)
            {
                richTextBox1.Visible = true;
            }
            else 
            { 
                richTextBox1.Visible = false; 
            }
        }
    }
}