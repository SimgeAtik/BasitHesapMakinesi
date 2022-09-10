using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitHesapMakinesi
{
    public partial class Form1 : Form
    {
        char _islem;
        bool  _ekranTemizlenecekMi;
        int  _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) 
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "1"; 
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            {
                ekranLbl.Text += "0";
            }
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLbl.Text);
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLbl.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;

                default:
                    sonuc = 0;
                    break;
            }
            ekranLbl.Text = Convert.ToString(sonuc);
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {

            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLbl.Text);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {

            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLbl.Text);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {

            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLbl.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ekranLbl.Text = "0";
        }
    }
}
