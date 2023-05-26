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
            VerileriYukle();   // Form kapan�rken kaydedilmi� verileri y�kler
            Listele();          // hayvanlar listesindeki verileri datagridview e y�kler
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
            hayvanlar.Add(new Hayvan() { Tur = "K�pek", Cinsiyet = Cinsiyet.Erkek, Yas = 11, Tag = 1 });
            hayvanlar.Add(new Hayvan() { Tur = "Ku�", Cinsiyet = Cinsiyet.Disi, Yas = 12, Tag = 2 });
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
            DialogResult result = MessageBox.Show("Silmek istiyor musunuz?", "Uyar�", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes && dgvShow.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvShow.SelectedRows[0];
                dgvShow.Rows.Remove(selectedRow);
            }
            return;

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Se�ilen row un de�erleri kay�t kutular�nda belirdi
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

           

            // Bu eski de�erleri de�i�tirip kaydet tu�una bast���nda eski sat�r�n silinip yeni hayvan nesnesi olu�turulup dgv in listelenmesi gerekiyor

            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonSerializer.Serialize(hayvanlar);
            File.WriteAllText("veri.json", json);
        }
    }
}