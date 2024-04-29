using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ApiSample
{
    public partial class Form1 : Form
    {
        private bool ContainsNumber(string input)
        {
           
            return Regex.IsMatch(input, @"\d");
        }

        private bool IsValidQuantity(string input)
        {
            
            return Regex.IsMatch(input.Trim(), @"^-?\d+(\.\d+)?$");
        }
        List<Termek> termeklista = new List<Termek>();
        public Form1()

        {
            InitializeComponent();
            peldanyositas();
        }

        private void peldanyositas()
        {
            var snaps = proxy.ProductsFindAll();
            for (int i = 0; i < snaps.Content.Count; i++)
            {
                var prodinv = proxy.ProductInventoryFindForProduct(snaps.Content[i].Bvin);
                listBox1.Items.Add(snaps.Content[i].ProductName);
                Termek t = new Termek();
                t.id = i + 1;
                t.nev = snaps.Content[i].ProductName;
                t.keszlet = prodinv.Content[0].QuantityOnHand;
                t.inventory_id = prodinv.Content[0].Bvin;

                termeklista.Add(t);
            }
        }

        static string url = "http://20.234.113.211:8086/";
        static string key = "1-2fa07268-d07a-4bd6-9719-5af01cd8b808";

        Api proxy = new Api(url, key);

        private void Szures()
        {
            List<string> szures = new List<string>();
            for (int i = 0; i < termeklista.Count; i++)
            {
                if (termeklista[i].nev.ToLower().StartsWith(textBox_kereses.Text.ToLower()))
                {
                    szures.Add(termeklista[i].nev);
                }
            }

            listBox1.DataSource = szures;
            
        }

        private void textBox_kereses_TextChanged_1(object sender, EventArgs e)
        {
            Szures();
            if (ContainsNumber(textBox_kereses.Text))
            {
                MessageBox.Show("Kérjük csak betűket írjon be", "Érvénytelen bemenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
            }

        }

        private void button_plus_Click_1(object sender, EventArgs e)
        {
            var z = int.Parse(textBox_mennyiseg.Text);
            z = z + 1;
            textBox_mennyiseg.Text = z.ToString();
        }

        private void button_minus_Click_1(object sender, EventArgs e)
        {
            var z = int.Parse(textBox_mennyiseg.Text);
            z = z - 1;
            textBox_mennyiseg.Text = z.ToString();
        }
        private void button_mentes_Click(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex; 
            if (index == -1) return;

            try
            {
                var curproduct = termeklista[index];
                var inv = proxy.ProductInventoryFind(curproduct.inventory_id).Content;
                inv.QuantityOnHand = int.Parse(textBox_mennyiseg.Text);

                var response = proxy.ProductInventoryUpdate(inv);

                textBox_mennyiseg.Text = inv.QuantityOnHand.ToString();

                if (!(response == null ))
                {
                    termeklista[index].keszlet = inv.QuantityOnHand;
                    textBox_mennyiseg.Text = inv.QuantityOnHand.ToString();
                    MessageBox.Show("Sikeres frissítés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    termeklista[index].keszlet = inv.QuantityOnHand;

                    
                    


                }
                else
                {
                    MessageBox.Show("Nem sikerült frissíteni az adatbázist.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Kérjük, érvényes számot adjon meg!", "Érvénytelen bemenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
           
             textBox_mennyiseg.Text = (termeklista[index].keszlet).ToString();
            
           
        }

        private void button_megse_Click(object sender, EventArgs e)
        {
            textBox_mennyiseg.Text = termeklista[listBox1.SelectedIndex].keszlet.ToString();

        }

        
    }
}
