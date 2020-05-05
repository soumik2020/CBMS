

namespace City_bus_mgmt_system
{
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticketing tkt = new ticketing();
            tkt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
