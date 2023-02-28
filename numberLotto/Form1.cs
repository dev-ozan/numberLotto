namespace numberLotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnSayilarOlustur_Click(object sender, EventArgs e)
        {
            listSayilar.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                int lotto = rnd.Next(1, 50);
                if (!listSayilar.Items.Contains(lotto))
                {
                    listSayilar.Items.Add(lotto);
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.YellowGreen;
            listSayilar.BackColor = Color.Red;
            btnSayilarOlustur.BackColor = Color.Green;
            this.Text = "Number Lotto";

        }
    }
}