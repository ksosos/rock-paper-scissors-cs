namespace rock_paper_scissorss
{
    public partial class Form1 : Form
    {
        string sidea = "";// two strings which show what the side A and B have chosen
        string sideb = "";
        void es()// two functions which don't let the users choose another option.
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
            sidea = "rock"; // the side becomes what they click, the button they click basically
            x(); // then it greys out the rest of the buttons
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
            string[] s = {"rock","paper","scissors" }; // here my solution to figuring out who won is to make two arrays which when compared in terms of indexes, the x array beats out the s array
            string[] x = {"paper","scissors","rock" };
            int sidai = Array.IndexOf(s, sidea); // so i made 4 different integers which check the positions of whatever the user chosoe
            int sidbit = Array.IndexOf(x, sideb);// sideai is where SIDE A is in array S. sidbit is where SIDE B is in array X. if sideai == sidbit which means that side B wins because since the X array is made to beat out the B array.
            int sidebi = Array.IndexOf(s, sideb);
            int sidait = Array.IndexOf(x, sidea);

            if (sidai == sidbit) { label1.Text = "side b wins"; }
            else if(sidebi==sidait) { label1.Text = "side  a wins"; } 
            else if(sidebi==sidai) { label1.Text = "draw"; }

            }
    }
}
