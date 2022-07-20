using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ResistenciasCS
{
	public partial class frmResistenciasCS : Form
	{


		private double banda1, banda2, banda3, banda4, valorPrincipal, resultado;

		

		private string digitos;



		public frmResistenciasCS()
		{
			InitializeComponent();
		}


		//Cargar form
		private void frmResistenciasCS_Load(object sender, EventArgs e)
		{
			rdbValor.Checked = true;
			rdbColores.Checked = false;
			grpBanda1.Enabled = false;
			grpBanda2.Enabled = false;
			grpBanda3.Enabled = false;
			grpBanda4.Enabled = false;
			rdbNegro1.Checked = true;
			rdbNegro2.Checked = true;
			rdbNegro3.Checked = true;
			rdbRojo4.Checked = true;
			pnlBanda1.BackColor = Color.Black;
			pnlBanda2.BackColor = Color.Black;
			pnlBanda3.BackColor = Color.Black;
			pnlBandaTolerancia.BackColor = Color.Red;
			cmbPrimerDigito.SelectedIndex = 0;
			cmbSegundoDigito.SelectedIndex = 0;
			cmbMultiplicador.SelectedIndex = 0;
			cmbTolerancia.SelectedIndex = 0;
		}



		//Timer
		private void tmrTiempo_Tick(object sender, EventArgs e)
		{
			if (rdbColores.Checked == true)
			{
				grpBanda1.Enabled = true;
				grpBanda2.Enabled = true;
				grpBanda3.Enabled = true;
				grpBanda4.Enabled = true;
				grpConValores.Enabled = false;




				// Banda 1
				if (rdbNegro1.Checked == true)
				{
					banda1 = 0;
					pnlBanda1.BackColor = Color.Black;
				}
				else if (rdbCafe1.Checked == true)
				{
					banda1 = 1;
					pnlBanda1.BackColor = Color.Brown;
				}
				else if (rdbRojo1.Checked == true)
				{
					banda1 = 2;
					pnlBanda1.BackColor = Color.Red;
				}
				else if (rdbNaranja1.Checked == true)
				{
					banda1 = 3;
					pnlBanda1.BackColor = Color.Orange;
				}
				else if (rdbAmarillo1.Checked == true)
				{
					banda1 = 4;
					pnlBanda1.BackColor = Color.Yellow;
				}
				else if (rdbVerde1.Checked == true)
				{
					banda1 = 5;
					pnlBanda1.BackColor = Color.Green;
				}
				else if (rdbAzul1.Checked == true)
				{
					banda1 = 6;
					pnlBanda1.BackColor = Color.Blue;
				}
				else if (rdbMorado1.Checked == true)
				{
					banda1 = 7;
					pnlBanda1.BackColor = Color.Purple;
				}
				else if (rdbGris1.Checked == true)
				{
					banda1 = 8;
					pnlBanda1.BackColor = Color.Gray;
				}
				else if (rdbBlanco1.Checked == true)
				{
					banda1 = 9;
					pnlBanda1.BackColor = Color.White;
				}





				// Banda 2
				if (rdbNegro2.Checked == true)
				{
					banda2 = 0;
					pnlBanda2.BackColor = Color.Black;
				}
				else if (rdbCafe2.Checked == true)
				{
					banda2 = 1;
					pnlBanda2.BackColor = Color.Brown;
				}
				else if (rdbRojo2.Checked == true)
				{
					banda2 = 2;
					pnlBanda2.BackColor = Color.Red;
				}
				else if (rdbNaranja2.Checked == true)
				{
					banda2 = 3;
					pnlBanda2.BackColor = Color.Orange;
				}
				else if (rdbAmarillo2.Checked == true)
				{
					banda2 = 4;
					pnlBanda2.BackColor = Color.Yellow;
				}
				else if (rdbVerde2.Checked == true)
				{
					banda2 = 5;
					pnlBanda2.BackColor = Color.Green;
				}
				else if (rdbAzul2.Checked == true)
				{
					banda2 = 6;
					pnlBanda2.BackColor = Color.Blue;
				}
				else if (rdbMorado2.Checked == true)
				{
					banda2 = 7;
					pnlBanda2.BackColor = Color.Purple;
				}
				else if (rdbGris2.Checked == true)
				{
					banda2 = 8;
					pnlBanda2.BackColor = Color.Gray;
				}
				else if (rdbBlanco2.Checked == true)
				{
					banda2 = 9;
					pnlBanda2.BackColor = Color.White;
				}






				// Banda 3
				if (rdbNegro3.Checked == true)
				{
					banda3 = Math.Pow(10, 0);
					pnlBanda3.BackColor = Color.Black;
					if (banda1 == 0)
					{
						lblValor.Text = Conversions.ToString(banda2) + " Ω";
					}
					else
					{
						lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + " Ω";
					}
				}
				else if (rdbCafe3.Checked == true)
				{
					banda3 = Math.Pow(10, 1);
					pnlBanda3.BackColor = Color.Brown;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + "0" + " Ω";
						}
					}
					else
					{
						lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + "0" + " Ω";
					}
				}

				else if (rdbRojo3.Checked == true)
				{
					banda3 = Math.Pow(10, 2);
					pnlBanda3.BackColor = Color.Red;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + "0" + "0" + " Ω";
						}
					}
					else
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda1) + " KΩ";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda1) + "." + Conversions.ToString(banda2) + " KΩ";
						}
					}
				}

				else if (rdbNaranja3.Checked == true)
				{
					banda3 = Math.Pow(10, 3);
					pnlBanda3.BackColor = Color.Orange;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + " KΩ";
						}
					}
					else
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda1) + "0" + " KΩ";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + " KΩ";
						}
					}
				}

				else if (rdbAmarillo3.Checked == true)
				{
					banda3 = Math.Pow(10, 4);
					pnlBanda3.BackColor = Color.Yellow;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + "0" + " KΩ";
						}
					}
					else
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + "0" + " KΩ";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + "0" + " KΩ";
						}
					}
				}

				else if (rdbVerde3.Checked == true)
				{
					banda3 = Math.Pow(10, 5);
					pnlBanda3.BackColor = Color.Green;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + "00" + " KΩ";
						}
					}
					else
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda1) + " MΩ";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda1) + "." + Conversions.ToString(banda2) + " MΩ";
						}
					}
				}

				else if (rdbAzul3.Checked == true)
				{
					banda3 = Math.Pow(10, 6);
					pnlBanda3.BackColor = Color.Blue;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + " MΩ";
						}
					}
					else
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + " MΩ";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + " MΩ";
						}
					}
				}

				else if (rdbMorado3.Checked == true)
				{
					banda3 = Math.Pow(10, 7);
					pnlBanda3.BackColor = Color.Purple;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + "0" + " MΩ";
						}
					}
					else
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + "0" + " MΩ";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + "0" + " MΩ";
						}
					}
				}

				else if (rdbGris3.Checked == true)
				{
					banda3 = Math.Pow(10, 8);
					pnlBanda3.BackColor = Color.Gray;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + "00" + " MΩ";
						}
					}
					else
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda1) + " GΩ";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda1) + "." + Conversions.ToString(banda2) + " GΩ";
						}
					}
				}

				else if (rdbBlanco3.Checked == true)
				{
					banda3 = Math.Pow(10, 9);
					pnlBanda3.BackColor = Color.White;
					if (banda1 == 0)
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda2) + " Ω";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda2) + " GΩ";
						}
					}
					else
					{
						if (banda2 == 0)
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + " GΩ";
						}
						else
						{
							lblValor.Text = Conversions.ToString(banda1) + Conversions.ToString(banda2) + " GΩ";
						}
					}
				}







				// Banda 4 Tolerancia
				if (rdbRojo4.Checked == true)
				{
					banda4 = 2;
					pnlBandaTolerancia.BackColor = Color.Red;
					lblValor.Text = lblValor.Text + " +-2%";
				}
				else if (rdbDorado4.Checked == true)
				{
					banda4 = 5;
					pnlBandaTolerancia.BackColor = Color.Gold;
					lblValor.Text = lblValor.Text + " +-5%";
				}
				else if (rdbPlateado4.Checked == true)
				{
					banda4 = 10;
					pnlBandaTolerancia.BackColor = Color.Silver;
					lblValor.Text = lblValor.Text + " +-10%";
				}

				digitos = Conversions.ToString(banda1) + Conversions.ToString(banda2);
			}

			if (rdbValor.Checked == true)
			{
				grpConValores.Enabled = true;
				grpBanda1.Enabled = false;
				grpBanda2.Enabled = false;
				grpBanda3.Enabled = false;
				grpBanda4.Enabled = false;
				if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
				{
					pnlBanda1.BackColor = Color.Black;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 1, false)))
				{
					pnlBanda1.BackColor = Color.Brown;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 2, false)))
				{
					pnlBanda1.BackColor = Color.Red;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 3, false)))
				{
					pnlBanda1.BackColor = Color.Orange;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 4, false)))
				{
					pnlBanda1.BackColor = Color.Yellow;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 5, false)))
				{
					pnlBanda1.BackColor = Color.Green;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 6, false)))
				{
					pnlBanda1.BackColor = Color.Blue;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 7, false)))
				{
					pnlBanda1.BackColor = Color.Purple;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 8, false)))
				{
					pnlBanda1.BackColor = Color.Gray;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 9, false)))
				{
					pnlBanda1.BackColor = Color.White;
				}

				if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
				{
					pnlBanda2.BackColor = Color.Black;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 1, false)))
				{
					pnlBanda2.BackColor = Color.Brown;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 2, false)))
				{
					pnlBanda2.BackColor = Color.Red;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 3, false)))
				{
					pnlBanda2.BackColor = Color.Orange;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 4, false)))
				{
					pnlBanda2.BackColor = Color.Yellow;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 5, false)))
				{
					pnlBanda2.BackColor = Color.Green;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 6, false)))
				{
					pnlBanda2.BackColor = Color.Blue;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 7, false)))
				{
					pnlBanda2.BackColor = Color.Purple;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 8, false)))
				{
					pnlBanda2.BackColor = Color.Gray;
				}
				else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 9, false)))
				{
					pnlBanda2.BackColor = Color.White;
				}



				if (cmbMultiplicador.SelectedIndex == 0)
				{
					pnlBanda3.BackColor = Color.Black;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
					}
					else
					{
						lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + " Ω");
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 1)
				{
					pnlBanda3.BackColor = Color.Brown;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + "0" + " Ω");
						}
					}
					else
					{
						lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + "0" + " Ω");
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 2)
				{
					pnlBanda3.BackColor = Color.Red;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + "0" + "0" + " Ω");
						}
					}
					else
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbPrimerDigito.SelectedItem + " KΩ");
						}
						else
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem + ".") + cmbSegundoDigito.SelectedItem + " KΩ");
						}
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 3)
				{
					pnlBanda3.BackColor = Color.Orange;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " KΩ");
						}
					}
					else
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbPrimerDigito.SelectedItem + "0" + " KΩ");
						}
						else
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + " KΩ");
						}
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 4)
				{
					pnlBanda3.BackColor = Color.Yellow;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + "0" + " KΩ");
						}
					}
					else
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + "0" + " KΩ");
						}
						else
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + "0" + " KΩ");
						}
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 5)
				{
					pnlBanda3.BackColor = Color.Green;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + "00" + " KΩ");
						}
					}
					else
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbPrimerDigito.SelectedItem + " MΩ");
						}
						else
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem + ".") + cmbSegundoDigito.SelectedItem + " MΩ");
						}
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 6)
				{
					pnlBanda3.BackColor = Color.Blue;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " MΩ");
						}
					}
					else
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + " MΩ");
						}
						else
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + " MΩ");
						}
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 7)
				{
					pnlBanda3.BackColor = Color.Purple;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + "0" + " MΩ");
						}
					}
					else
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + "0" + " MΩ");
						}
						else
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + "0" + " MΩ");
						}
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 8)
				{
					pnlBanda3.BackColor = Color.Gray;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + "00" + " MΩ");
						}
					}
					else
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbPrimerDigito.SelectedItem + " GΩ");
						}
						else
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem + ".") + cmbSegundoDigito.SelectedItem + " GΩ");
						}
					}
				}
				else if (cmbMultiplicador.SelectedIndex == 9)
				{
					pnlBanda3.BackColor = Color.White;
					if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbPrimerDigito.SelectedItem, 0, false)))
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " Ω");
						}
						else
						{
							lblValor.Text = Conversions.ToString(cmbSegundoDigito.SelectedItem + " GΩ");
						}
					}
					else
					{
						if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbSegundoDigito.SelectedItem, 0, false)))
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + " GΩ");
						}
						else
						{
							lblValor.Text = Conversions.ToString(Conversions.ToString(cmbPrimerDigito.SelectedItem) + cmbSegundoDigito.SelectedItem + " GΩ");
						}
					}
				}

				if (cmbTolerancia.SelectedIndex == 0)
				{
					pnlBandaTolerancia.BackColor = Color.Red;
					lblValor.Text = lblValor.Text + " +-2%";
				}
				else if (cmbTolerancia.SelectedIndex == 1)
				{
					pnlBandaTolerancia.BackColor = Color.Gold;
					lblValor.Text = lblValor.Text + " +-5%";
				}
				else if (cmbTolerancia.SelectedIndex == 2)
				{
					pnlBandaTolerancia.BackColor = Color.Silver;
					lblValor.Text = lblValor.Text + " +-10%";
				}
			}
		}
	}

	
}
