namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {
            string msg = txtb.Text.Trim();
            if (!string.IsNullOrWhiteSpace(msg))
            {
                string result = $"{DateTime.Now:[HH:mm:ss]} {msg}";
                lstb.Items.Add(result);
                label1.Text = "Echo Messenger,현재 대화 : " + lstb.Items.Count.ToString() + "개";
                txtb.Clear();
            }

            txtb.Focus();
        }

        private void bt_MouseClick(object sender, MouseEventArgs e)
        {



        }
    }
}
