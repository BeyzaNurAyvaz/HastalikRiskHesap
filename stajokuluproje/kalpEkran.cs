﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajokuluproje
{
    public partial class KALP_HASTALIĞI : Form
    {
        public HASTALIK_SECİMİ parent;
        private int goodModifier ;
        private int badModifier;

        public KALP_HASTALIĞI()
        {
            InitializeComponent();
        }

        private void KALP_HASTALIĞI_Load(object sender, EventArgs e)
        {

        }
        private void hesaplaFunc(object sender, EventArgs e)                //Gerekli ayarlar yapıldı sorgu yazılması lazım
        {
            hesap();
        }

        private void geriDon(object sender, EventArgs e)    //Geri dön fonksiyonu
        {
            parent.Show();
            this.Hide();
        }

        private void hesap() {
                                            //badThing goodThing 2 degisken  tanımlanır. kötü değişkenlere evet denildiğinde badThing artırılır.terside geçerli düşürülmez hiç.

        }

        private void btnKadin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
