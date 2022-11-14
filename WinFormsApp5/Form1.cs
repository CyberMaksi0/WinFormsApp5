namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DodawanieDanych(string tytul, string rezyser, string data, string aktorrr)
        {
            ListViewItem item = new ListViewItem(new string[] {tytul, rezyser, data, aktorrr});
            listView1.Items.Add(item);
        }
        private void DodawanieDanych(string[] dane)
        {
            ListViewItem item = new ListViewItem(dane);
            listView1.Items.Add(item);
        }
        private void UsuwanieDanych()
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            listView1.Refresh();
        }
        private string[] WierszeDoPliku()
        {
            string[] linie = new string[listView1.Items.Count];
            int i = 0;
            foreach(ListViewItem item in listView1.Items)
            {
                linie[i] = "";
                for (int k = 0; k < item.SubItems.Count; k++)
                    linie[i] += item.SubItems[k].Text + "*";
                i++;
            }
            return linie;
        }
        private void bntSave_Click(object sender, EventArgs e)
        {
            string[] linie = WierszeDoPliku();
            File.WriteAllLines("filmy.txt", linie);
        }
        private void OdczytZPliku()
        {
            if (!File.Exists("filmy.txt"))
                return;
            string[] linie = File.ReadAllLines("filmy.txt");
            foreach(string linia in linie)
            {
                string[] temp = linia.Split('*');
                DodawanieDanych(temp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodawanieDanych(tytul.Text, rezyser.Text, dateTimePicker1.Text, aktorrr.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void usunWybraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuwanieDanych();
            
        }
    }
}