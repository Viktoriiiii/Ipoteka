using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ipoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tBCNedv_KeyPress(object sender, KeyPressEventArgs e)
        {         
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.Contains(","))
                    e.Handled = true;
                if ((sender as TextBox).Text == "")
                    e.Handled = true;
                return;
            } 
            if (e.KeyChar == 8) return;
            if (e.KeyChar == 27)
            {
                (sender as TextBox).Text = "";
                return;
            }
            e.Handled = true;
        }                

        private void tBVznosOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bRasschet_Click(object sender, EventArgs e)
        {
            Encoding en = Encoding.GetEncoding(1251); // Русский алфавит
            if (tBCNedv.Text == "" || tBGodProc.Text == "" || tBSrok.Text == "" || tBVznos.Text == "")
            {
                MessageBox.Show("Не заполнено одно(или несколько) полей входных данных. Пожалуйста заполните его(их).");                
                return;
            }
            double cena_nedv = Convert.ToDouble(tBCNedv.Text);
            double god_proc = Convert.ToDouble(tBGodProc.Text);
            double kol_mes = Convert.ToInt32(tBSrok.Text);
            double perv_vznos_proc = Convert.ToDouble(tBVznos.Text);

            double perv_vznos = cena_nedv * perv_vznos_proc / 100;
            tBVznosOut.Text = perv_vznos.ToString("C2");

            double summa_ipoteki = cena_nedv - perv_vznos;
            tBIpotekaSum.Text = summa_ipoteki.ToString("C2");

            double percent_month = god_proc / 100 / 12; // месячная ставка

            DateTime dt = new DateTime();
            dt = DateTime.Today;
            labelDataStart.Visible = true;
            labelDataStart.Text = "Дата начала платежей: " + dt.ToLongDateString();

            // Аннуитетная схема
            double K, annuitet, osn_dolg, cost_bank, cost_dolg;
            double sum_percent_annuitet = 0, sum_annuitet = 0, itog_annuitet = 0;
            //int days;
            StreamWriter sw = new StreamWriter(@"Аннуитетный платеж.txt", false); // открытие перезаписи файла            
            K = percent_month + percent_month / (Math.Pow(1 + percent_month, kol_mes) - 1);
            //K = percent_month * Math.Pow(1 + percent_month, kol_mes) / (Math.Pow(1 + percent_month, kol_mes) - 1);
            annuitet = summa_ipoteki * K; // сумма аннуитета - ежемесячный платеж

            sw.WriteLine($"Сумма ипотеки: {summa_ipoteki}\nПроцент первоначального взноса: {perv_vznos_proc}%\nПроцентная ставка: {god_proc}% годовых");
            sw.WriteLine($"Срок платежа: {kol_mes} месяцев\nСумма первоначального взноса: {perv_vznos}\nСумма аннуитетного платежа: {Math.Round(annuitet, 2)}");
            sw.WriteLine($"Дата начала платежа: {dt.ToString()}\n");
            sw.WriteLine(" Период  | Месячный платеж | Оплата основного долга | Оплата % банку | Остаток основного долга ");
            sw.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            sw.WriteLine("{0,80}", Math.Round(summa_ipoteki, 2)); // непосредственная запись данных в файл
            sw.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            osn_dolg = summa_ipoteki; // основной долг будет уменьшаться
            for (int i = 1; i <= kol_mes; i++)
            {
                // Високосность года
                //if (DateTime.IsLeapYear(dt.Year) == true)
                //    days = 366;
                //else days = 365;
                int D = DateTime.DaysInMonth(dt.Year, dt.Month);
                //cost_bank = (osn_dolg * (god_proc / 100) * D) / days;
                cost_bank = osn_dolg * percent_month;
                cost_dolg = annuitet - cost_bank; // Платеж в месяц основного долга
                osn_dolg -= cost_dolg; // Остаток основного долга
                sw.WriteLine(" {0,2} - {1,2} | {2,15} | {3,22 } | {4,15} | {5,15}", i, D, Math.Round(annuitet, 2), Math.Round(cost_dolg, 2), Math.Round(cost_bank, 2), Math.Round(osn_dolg, 2));
                sw.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                // Суммарные расчеты
                sum_percent_annuitet += cost_bank; // Сумма выплат процентов по аннуитетному платежу
                sum_annuitet += annuitet; // Общая сума выплат по аннуитетному платежу
                dt = dt.AddMonths(1); // Добавление месяца
            }
            sw.Close();
            // Итоговые расчеты
            tBSumBankuA.Text = sum_percent_annuitet.ToString("C2");
            itog_annuitet = cena_nedv + sum_percent_annuitet;
            tBItogJilA.Text = itog_annuitet.ToString("C2");
            tBPereplataA.Text = ((itog_annuitet - cena_nedv) / cena_nedv * 100).ToString("F2");

            dt = DateTime.Today;
            // Дифференцированная схема
            double sum_percent_diff = 0, sum_diff = 0, itog_diff = 0, difference;
            sw = new StreamWriter(@"Дифференцированный платеж.txt", false); // открытие перезаписи файла
            double osn_dolgDiff = summa_ipoteki;
            difference = osn_dolgDiff / kol_mes;

            sw.WriteLine($"Сумма ипотеки: {summa_ipoteki}\nПроцент первоначального взноса: {perv_vznos_proc}%\nПроцентная ставка: {god_proc}% годовых");
            sw.WriteLine($"Срок платежа: {kol_mes} месяцев\nСумма первоначального взноса: {perv_vznos}\nСумма дифференцированного платежа за основной долг: {Math.Round(difference, 2)}");
            sw.WriteLine($"Дата начала платежа: {dt.ToString()}\n");
            sw.WriteLine(" Период  | Месячный платеж | Оплата основного долга | Оплата % банку | Остаток основного долга ");
            sw.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            sw.WriteLine("{0,80}", Math.Round(summa_ipoteki, 2)); // непосредственная запись данных в файл
            sw.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            for (int i = 1; i <= kol_mes; i++)
            {                
                int D = DateTime.DaysInMonth(dt.Year, dt.Month);
                cost_bank = osn_dolgDiff * god_proc / 100 / 12;
                cost_dolg = difference + cost_bank; // Платеж в месяц основного долга
                osn_dolgDiff -= difference; // Остаток основного долга
                sw.WriteLine(" {0,2} - {1,2} | {2,15} | {3,22 } | {4,15} | {5,15}", i, D, Math.Round(cost_dolg, 2), Math.Round(difference, 2), Math.Round(cost_bank, 2), Math.Round(osn_dolgDiff, 2));
                sw.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                // Суммарные расчеты
                sum_percent_diff += cost_bank; // Сумма выплат процентов по дифференцированному платежу
                sum_diff += difference; // Общая сума выплат по дифференцированному платежу
                dt = dt.AddMonths(1); // Добавление месяца
            }
            // Итоговые расчеты
            tBSumBankuD.Text = sum_percent_diff.ToString("C2");
            itog_diff = cena_nedv + sum_percent_diff;
            tBItogJilD.Text = itog_diff.ToString("C2");
            tBPereplataD.Text = ((itog_diff - cena_nedv) / cena_nedv * 100).ToString("F2");
            sw.Close();
            labelDataEnd.Visible = true;
            labelDataEnd.Text = "Дата окончания платежей: " + dt.ToLongDateString();

            labelVigoda.Visible = true;
            if (itog_annuitet > itog_diff) labelVigoda.Text = "Выгоднее дифференциальная схема на " + (itog_annuitet - itog_diff).ToString("C2");
            else labelVigoda.Text = "Выгоднее аннуитетная схема на " + (itog_diff - itog_annuitet).ToString("C2");
        }        
    }
}
