using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WizQuizPractice.UI
{
	public partial class DamageCalc : Form
	{
		private const string DamageShowFormat = "{1:f0} ({0:f0}-{2:f0})";

		public DamageCalc()
		{
			InitializeComponent();
		}

		private void DamageCalc_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 1;	// Main: Water
			comboBox2.SelectedIndex = 0;	// Sub: (None)
			comboBox3.SelectedIndex = 0;	// Enemy: Fire
			comboBox4.SelectedIndex = 0;	// Rand: No Select
			comboBox5.SelectedIndex = 0;	// AttackType: AS
		}

		private void ValueChanged(object sender, EventArgs e)
		{
			if(comboBox2.SelectedIndex == 0) {
				comboBox4.SelectedIndex = 0;
			}
			comboBox4.Enabled = comboBox2.SelectedIndex != 0 && comboBox5.SelectedIndex == 0;
			comboBox5.Enabled = numericUpDown4.Value > 0;
			// --------------------
			// 攻撃タイプ
			bool IsASAttack = comboBox5.SelectedIndex == 0;
			// 攻撃力
			double BaseAtk = (int)numericUpDown1.Value + (int)numericUpDown2.Value;
			// AS倍率
			double AS_Rate = (int)numericUpDown3.Value + (int)numericUpDown5.Value + (int)numericUpDown6.Value + 100;
			// SS倍率
			double SS_Rate = (int)numericUpDown4.Value + (int)numericUpDown6.Value;
			// チェイン数
			double Chains = (int)numericUpDown8.Value;
			// 属性1と敵属性の相性
			double TypeFst
				= CalcTypeDamageRate(comboBox1.SelectedIndex, comboBox3.SelectedIndex)
				* (comboBox4.SelectedIndex != 1 ? 1.0 : 0.5);
			// 属性2と敵属性の相性
			double TypeSec
				= (comboBox2.SelectedIndex != 0 && comboBox1.SelectedIndex != comboBox2.SelectedIndex-1
				? CalcTypeDamageRate(comboBox2.SelectedIndex - 1, comboBox3.SelectedIndex)
				: 0)
				* (comboBox4.SelectedIndex != 0 ? 1.0 : 0.5);
			// --------------------
			double CalcDmg;
			if(IsASAttack) {
				CalcDmg = BaseAtk / 2 * AS_Rate / 100 * (1 + Chains / 100) * (TypeFst + TypeSec);
			}
			else {
				CalcDmg = BaseAtk * SS_Rate / 100 * (1 + Chains / 100) * (TypeFst + TypeSec);
			}
			label13.Text = String.Format(DamageShowFormat, CalcDmg * 0.95, CalcDmg, CalcDmg * 1.05);


		}

		private double CalcTypeDamageRate(int Ty, int En)
		{
			double[,] TypeList = {
				{1, 0.5, 1.5, 1, 1},		// Fire
				{1.5, 1, 0.5, 1, 1},		// Water
				{0.5, 1.5, 1, 1, 1},		// Thunder
				{1, 1, 1, 1, 2},			// Light
				{1, 1, 1, 2, 1},			// Dark
			};
			if(Ty < 0 || En < 0) {
				return 0;
			}
			return TypeList[Ty,En];
		}

		private double CalcDamageWithPanel(int tyn, bool chk, bool isAs)
		{
			return isAs ? comboBox4.SelectedIndex != tyn ? 1.0 : 0.5 : 1;
		}
	}
}
