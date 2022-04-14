namespace rock_paper_scissorss
{
    public partial class Form1 : Form
    {
        string sidea = "";
        string sideb = "";
        void es()
        {
            button6.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
        }
        void x()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidea = "rock";
            x();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidea = "paper";
            x();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidea = "scissors";
            x();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sideb = "rock";
            es();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sideb = "paper";
            es();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sideb = "scissors";
            es();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string[] s = {"rock","paper","scissors" };
            string[] x = {"paper","scissors","rock" };
            int sidai = Array.IndexOf(s, sidea);
            int sidbit = Array.IndexOf(x, sideb);
            int sidebi = Array.IndexOf(s, sideb);
            int sidait = Array.IndexOf(x, sidea);

            if (sidai == sidbit) { label1.Text = "side a wins"; }
            else if(sidebi==sidait) { label1.Text = "side  b wins"; } 
            else if(sidebi==sidai) { label1.Text = "draw"; }

            }
    }
}
