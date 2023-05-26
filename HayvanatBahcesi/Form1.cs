using AltYapi;
using System.ComponentModel;
using System.Drawing.Text;
using System.Text.Json;
using System.IO;

namespace HayvanatBahcesi
{
    public partial class Form1 : Form
    {
        public BindingList<Hayvan> hayvanlar = new BindingList<Hayvan>();
        public Form1()
        {
            InitializeComponent();
            cboxCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cboxCinsiyet.SelectedIndex = 0;
            VerileriYukle();   // Form kapanýrken kaydedilmiþ verileri yükler
            Listele();          // hayvanlar listesindeki verileri datagridview e yükler
        }

        private void VerileriYukle()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                hayvanlar = JsonSerializer.Deserialize<BindingList<Hayvan>>(json);

            }
            catch (Exception)
            {
                OrnekVerileriYukle();
            }


        }

        private void OrnekVerileriYukle()
        {
            hayvanlar.Add(new Hayvan() { Tur = "Kedi", Cinsiyet = Cinsiyet.Disi, Yas = 10, Tag = 0 });
            hayvanlar.Add(new Hayvan() { Tur = "Köpek", Cinsiyet = Cinsiyet.Erkek, Yas = 11, Tag = 1 });
            hayvanlar.Add(new Hayvan() { Tur = "Kuþ", Cinsiyet = Cinsiyet.Disi, Yas = 12, Tag = 2 });
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            HayvanEkle();
        }

        int etiket = 3;
        private void HayvanEkle()
        {
            Hayvan hayvan = new Hayvan();
            hayvan.Tur = txtTur.Text;
            hayvan.Yas = (int)nudYas.Value;
            hayvan.Cinsiyet = cboxCinsiyet.SelectedIndex == 0 ? Cinsiyet.Disi : Cinsiyet.Erkek;
            hayvan.Tag = etiket++;

            hayvanlar.Add(hayvan);

            Listele();

            txtTur.Clear();
            nudYas.Value = 0;
            cboxCinsiyet.SelectedIndex = -1;
        }

        private void Listele()
        {
            dgvShow.DataSource = hayvanlar;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istiyor musunuz?", "Uyarý", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes && dgvShow.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvShow.SelectedRows[0];
                dgvShow.Rows.Remove(selectedRow);
            }
            return;

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Seçilen row un deðerleri kayýt kutularýnda belirdi
            if (dgvShow.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvShow.SelectedRows[0];

                txtTur.Text = selectedRow.Cells["Tur"].Value.ToString();
                nudYas.Value = Convert.ToInt32(selectedRow.Cells["Yas"].Value);

                Cinsiyet cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), selectedRow.Cells["Cinsiyet"].Value.ToString());

                if (cinsiyet == Cinsiyet.Disi)
                    cboxCinsiyet.SelectedIndex = 0;
                else if (cinsiyet == Cinsiyet.Erkek)
                    cboxCinsiyet.SelectedItem = 1;
            }

           

            // Bu eski deðerleri deðiþtirip kaydet tuþuna bastýðýnda eski satýrýn silinip yeni hayvan nesnesi oluþturulup dgv in listelenmesi gerekiyor

            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonSerializer.Serialize(hayvanlar);
            File.WriteAllText("veri.json", json);
        }
    }
}