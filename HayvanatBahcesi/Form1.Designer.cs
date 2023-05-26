namespace HayvanatBahcesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTur = new TextBox();
            gboxEkleme = new GroupBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            cboxCinsiyet = new ComboBox();
            nudYas = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            dgvShow = new DataGridView();
            gboxEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 0;
            label1.Text = "Tur:";
            // 
            // txtTur
            // 
            txtTur.Location = new Point(88, 45);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(249, 29);
            txtTur.TabIndex = 1;
            // 
            // gboxEkleme
            // 
            gboxEkleme.BackColor = Color.PaleGoldenrod;
            gboxEkleme.Controls.Add(btnSil);
            gboxEkleme.Controls.Add(btnGuncelle);
            gboxEkleme.Controls.Add(btnEkle);
            gboxEkleme.Controls.Add(cboxCinsiyet);
            gboxEkleme.Controls.Add(nudYas);
            gboxEkleme.Controls.Add(txtTur);
            gboxEkleme.Controls.Add(label2);
            gboxEkleme.Controls.Add(label3);
            gboxEkleme.Controls.Add(label1);
            gboxEkleme.Location = new Point(12, 12);
            gboxEkleme.Name = "gboxEkleme";
            gboxEkleme.Size = new Size(351, 403);
            gboxEkleme.TabIndex = 2;
            gboxEkleme.TabStop = false;
            gboxEkleme.Text = "EKLE";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(176, 297);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(136, 41);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(20, 351);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(292, 41);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(20, 297);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(136, 41);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cboxCinsiyet
            // 
            cboxCinsiyet.FormattingEnabled = true;
            cboxCinsiyet.Location = new Point(88, 152);
            cboxCinsiyet.Name = "cboxCinsiyet";
            cboxCinsiyet.Size = new Size(249, 29);
            cboxCinsiyet.TabIndex = 3;
            // 
            // nudYas
            // 
            nudYas.Location = new Point(88, 98);
            nudYas.Margin = new Padding(4);
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(249, 29);
            nudYas.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 0;
            label2.Text = "Yas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 0;
            label3.Text = "Cinsiyet:";
            // 
            // dgvShow
            // 
            dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvShow.BackgroundColor = SystemColors.ButtonHighlight;
            dgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShow.Location = new Point(380, 12);
            dgvShow.MultiSelect = false;
            dgvShow.Name = "dgvShow";
            dgvShow.ReadOnly = true;
            dgvShow.RowHeadersVisible = false;
            dgvShow.RowTemplate.Height = 25;
            dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShow.Size = new Size(354, 403);
            dgvShow.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(746, 431);
            Controls.Add(dgvShow);
            Controls.Add(gboxEkleme);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hayvanat Bahçesi";
            FormClosing += Form1_FormClosing;
            gboxEkleme.ResumeLayout(false);
            gboxEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtTur;
        private GroupBox gboxEkleme;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private ComboBox cboxCinsiyet;
        private NumericUpDown nudYas;
        private Label label2;
        private Label label3;
        private DataGridView dgvShow;
    }
}