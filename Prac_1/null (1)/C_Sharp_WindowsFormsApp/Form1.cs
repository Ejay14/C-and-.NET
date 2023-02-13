using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_WindowsFormsApp
{
    public partial class Form1 : Form
    {

        private const double HStyle = 60;
        private const double MOver = 125;
        private const double Manicure = 35;
        private const double Permanent = 200;

        private double _Value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void DiscountMethod()
        {

            if (rdNone.Checked)
            {
                if (rdHairstyle.Checked)
                {
                    txtCurrentService.Text = "R" + HStyle.ToString();
                    _Value += HStyle;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdMOver.Checked)
                {
                    txtCurrentService.Text = "R" + MOver.ToString();
                    _Value += MOver;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdManicure.Checked)
                {
                    txtCurrentService.Text = "R" + Manicure.ToString();
                    _Value += Manicure;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdPermanent.Checked)
                {
                    txtCurrentService.Text = "R" + Permanent.ToString();
                    _Value += Permanent;
                    txtTotal.Text = "R" + _Value.ToString();
                }
            }

            double capt;

            if (rd10.Checked)
            {
                if (rdHairstyle.Checked)
                {
                    capt = HStyle - (HStyle * 0.1);
                    txtCurrentService.Text = "R" + capt.ToString();
                    _Value += capt;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdMOver.Checked)
                {
                    capt = MOver - (MOver * 0.1);
                    txtCurrentService.Text = "R" + capt.ToString();
                    _Value += capt;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdManicure.Checked)
                {
                    capt = Manicure - (Manicure * 0.1);
                    txtCurrentService.Text = "R" + capt.ToString();
                    _Value += capt;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdPermanent.Checked)
                {
                    capt = Permanent - (Permanent * 0.1);
                    txtCurrentService.Text = "R" + capt.ToString();
                    _Value += capt;
                    txtTotal.Text = "R" + _Value.ToString();
                }
            }
            if (rd20.Checked)
            {
                if (rdHairstyle.Checked)
                {
                    capt = HStyle - (HStyle * 0.2);
                    txtCurrentService.Text = "R" + capt.ToString();
                    _Value += capt;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdMOver.Checked)
                {
                    capt = MOver - (MOver * 0.2);
                    txtCurrentService.Text = "R" + capt.ToString();
                    _Value += capt;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdManicure.Checked)
                {
                    capt = Manicure - (Manicure * 0.2);
                    txtCurrentService.Text = "R" + capt.ToString();
                    _Value += capt;
                    txtTotal.Text = "R" + _Value.ToString();
                }
                else if (rdPermanent.Checked)
                {
                    capt = Permanent - (Permanent * 0.2);
                    txtCurrentService.Text = "R" + capt.ToString();
                    _Value += capt;
                    txtTotal.Text = "R" + _Value.ToString();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiscountMethod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
