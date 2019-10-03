using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191003eszj
{
    public partial class Form1 : Form
    {
        List<Jatekos> jatekosok;
        public Form1()
        {
            InitializeComponent();
            FileBoeolvas();
        }

        private void FileBoeolvas()
        {
            jatekosok = new List<Jatekos>();
            var sr = new StreamReader("egyszamjatek2.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                jatekosok.Add(new Jatekos(sr.ReadLine()));
            }
            sr.Close();
        }

        private void TbTippek_TextChanged(object sender, EventArgs e)
        {
            string[] t = tbTippek.Text.Split(' ');

            if (tbTippek.Text[tbTippek.Text.Length - 1] == ' ')
            {
                lblDb.Text = t.Length - 1 + " db";
            }
            else
            {
                lblDb.Text = t.Length + " db";
            }
        }

        private void BtnHozzaAd_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i < jatekosok.Count && jatekosok[i].Nev != tbNev.Text)
            {
                i++;
            }

            if(i < jatekosok.Count)
            {
                MessageBox.Show("van már ilyen b+!");
            }
            else if (int.Parse(lblDb.Text.Split(' ')[0]) != jatekosok[0].Tippek.Length)
            {
                MessageBox.Show("nem jó a tippek száma!");
            }
            else
            {
                var sw = new StreamWriter("egyszamjatek2.txt", true, Encoding.UTF8);

                sw.WriteLine($"{tbNev.Text} {tbTippek.Text}");
                sw.Close();

                MessageBox.Show("sikeresen rögzítve!");
            }
        }
    }
}
