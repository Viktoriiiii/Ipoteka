namespace Ipoteka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBInput = new System.Windows.Forms.GroupBox();
            this.tBVznos = new System.Windows.Forms.TextBox();
            this.lVznos = new System.Windows.Forms.Label();
            this.tBSrok = new System.Windows.Forms.TextBox();
            this.lSrok = new System.Windows.Forms.Label();
            this.tBGodProc = new System.Windows.Forms.TextBox();
            this.lGodProc = new System.Windows.Forms.Label();
            this.tBCNedv = new System.Windows.Forms.TextBox();
            this.lCNedv = new System.Windows.Forms.Label();
            this.gBMid = new System.Windows.Forms.GroupBox();
            this.tBIpotekaSum = new System.Windows.Forms.TextBox();
            this.lIpotekaSum = new System.Windows.Forms.Label();
            this.tBVznosOut = new System.Windows.Forms.TextBox();
            this.lVznosOut = new System.Windows.Forms.Label();
            this.gBAnnui = new System.Windows.Forms.GroupBox();
            this.lPereplataA = new System.Windows.Forms.Label();
            this.tBPereplataA = new System.Windows.Forms.TextBox();
            this.tBItogJilA = new System.Windows.Forms.TextBox();
            this.lItogJilA = new System.Windows.Forms.Label();
            this.tBSumBankuA = new System.Windows.Forms.TextBox();
            this.lSumBankuA = new System.Windows.Forms.Label();
            this.gBDiff = new System.Windows.Forms.GroupBox();
            this.lPereplataD = new System.Windows.Forms.Label();
            this.tBPereplataD = new System.Windows.Forms.TextBox();
            this.tBItogJilD = new System.Windows.Forms.TextBox();
            this.lItogJilD = new System.Windows.Forms.Label();
            this.tBSumBankuD = new System.Windows.Forms.TextBox();
            this.lSumBankuD = new System.Windows.Forms.Label();
            this.bRasschet = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.labelDataStart = new System.Windows.Forms.Label();
            this.labelDataEnd = new System.Windows.Forms.Label();
            this.labelVigoda = new System.Windows.Forms.Label();
            this.gBInput.SuspendLayout();
            this.gBMid.SuspendLayout();
            this.gBAnnui.SuspendLayout();
            this.gBDiff.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBInput
            // 
            this.gBInput.Controls.Add(this.tBVznos);
            this.gBInput.Controls.Add(this.lVznos);
            this.gBInput.Controls.Add(this.tBSrok);
            this.gBInput.Controls.Add(this.lSrok);
            this.gBInput.Controls.Add(this.tBGodProc);
            this.gBInput.Controls.Add(this.lGodProc);
            this.gBInput.Controls.Add(this.tBCNedv);
            this.gBInput.Controls.Add(this.lCNedv);
            this.gBInput.Location = new System.Drawing.Point(12, 12);
            this.gBInput.Name = "gBInput";
            this.gBInput.Size = new System.Drawing.Size(311, 146);
            this.gBInput.TabIndex = 0;
            this.gBInput.TabStop = false;
            this.gBInput.Text = "Входные данные";
            // 
            // tBVznos
            // 
            this.tBVznos.Location = new System.Drawing.Point(191, 114);
            this.tBVznos.Name = "tBVznos";
            this.tBVznos.Size = new System.Drawing.Size(114, 20);
            this.tBVznos.TabIndex = 7;
            this.tBVznos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCNedv_KeyPress);
            // 
            // lVznos
            // 
            this.lVznos.AutoSize = true;
            this.lVznos.Location = new System.Drawing.Point(39, 117);
            this.lVznos.Name = "lVznos";
            this.lVznos.Size = new System.Drawing.Size(144, 13);
            this.lVznos.TabIndex = 6;
            this.lVznos.Text = "Первоначальный взнос (%)";
            // 
            // tBSrok
            // 
            this.tBSrok.Location = new System.Drawing.Point(191, 85);
            this.tBSrok.Name = "tBSrok";
            this.tBSrok.Size = new System.Drawing.Size(114, 20);
            this.tBSrok.TabIndex = 5;
            this.tBSrok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCNedv_KeyPress);
            // 
            // lSrok
            // 
            this.lSrok.AutoSize = true;
            this.lSrok.Location = new System.Drawing.Point(48, 88);
            this.lSrok.Name = "lSrok";
            this.lSrok.Size = new System.Drawing.Size(135, 13);
            this.lSrok.TabIndex = 4;
            this.lSrok.Text = "Срок кредитовая (месяц)";
            // 
            // tBGodProc
            // 
            this.tBGodProc.Location = new System.Drawing.Point(191, 55);
            this.tBGodProc.Name = "tBGodProc";
            this.tBGodProc.Size = new System.Drawing.Size(114, 20);
            this.tBGodProc.TabIndex = 3;
            this.tBGodProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCNedv_KeyPress);
            // 
            // lGodProc
            // 
            this.lGodProc.AutoSize = true;
            this.lGodProc.Location = new System.Drawing.Point(17, 58);
            this.lGodProc.Name = "lGodProc";
            this.lGodProc.Size = new System.Drawing.Size(166, 13);
            this.lGodProc.TabIndex = 2;
            this.lGodProc.Text = "Годовая процентная ставка (%)";
            // 
            // tBCNedv
            // 
            this.tBCNedv.Location = new System.Drawing.Point(191, 24);
            this.tBCNedv.Name = "tBCNedv";
            this.tBCNedv.Size = new System.Drawing.Size(114, 20);
            this.tBCNedv.TabIndex = 1;
            this.tBCNedv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCNedv_KeyPress);
            // 
            // lCNedv
            // 
            this.lCNedv.AutoSize = true;
            this.lCNedv.Location = new System.Drawing.Point(6, 27);
            this.lCNedv.Name = "lCNedv";
            this.lCNedv.Size = new System.Drawing.Size(179, 13);
            this.lCNedv.TabIndex = 0;
            this.lCNedv.Text = "Введите цену недвижимости (руб)";
            // 
            // gBMid
            // 
            this.gBMid.Controls.Add(this.tBIpotekaSum);
            this.gBMid.Controls.Add(this.lIpotekaSum);
            this.gBMid.Controls.Add(this.tBVznosOut);
            this.gBMid.Controls.Add(this.lVznosOut);
            this.gBMid.Location = new System.Drawing.Point(12, 184);
            this.gBMid.Name = "gBMid";
            this.gBMid.Size = new System.Drawing.Size(291, 133);
            this.gBMid.TabIndex = 1;
            this.gBMid.TabStop = false;
            this.gBMid.Text = "Промежуточные расчеты";
            // 
            // tBIpotekaSum
            // 
            this.tBIpotekaSum.Location = new System.Drawing.Point(139, 60);
            this.tBIpotekaSum.Name = "tBIpotekaSum";
            this.tBIpotekaSum.Size = new System.Drawing.Size(146, 20);
            this.tBIpotekaSum.TabIndex = 11;
            this.tBIpotekaSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBVznosOut_KeyPress);
            // 
            // lIpotekaSum
            // 
            this.lIpotekaSum.AutoSize = true;
            this.lIpotekaSum.Location = new System.Drawing.Point(48, 63);
            this.lIpotekaSum.Name = "lIpotekaSum";
            this.lIpotekaSum.Size = new System.Drawing.Size(85, 13);
            this.lIpotekaSum.TabIndex = 10;
            this.lIpotekaSum.Text = "Сумма ипотеки";
            // 
            // tBVznosOut
            // 
            this.tBVznosOut.Location = new System.Drawing.Point(139, 26);
            this.tBVznosOut.Name = "tBVznosOut";
            this.tBVznosOut.Size = new System.Drawing.Size(146, 20);
            this.tBVznosOut.TabIndex = 9;
            this.tBVznosOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBVznosOut_KeyPress);
            // 
            // lVznosOut
            // 
            this.lVznosOut.AutoSize = true;
            this.lVznosOut.Location = new System.Drawing.Point(6, 29);
            this.lVznosOut.Name = "lVznosOut";
            this.lVznosOut.Size = new System.Drawing.Size(127, 13);
            this.lVznosOut.TabIndex = 8;
            this.lVznosOut.Text = "Первоначальный взнос";
            // 
            // gBAnnui
            // 
            this.gBAnnui.Controls.Add(this.lPereplataA);
            this.gBAnnui.Controls.Add(this.tBPereplataA);
            this.gBAnnui.Controls.Add(this.tBItogJilA);
            this.gBAnnui.Controls.Add(this.lItogJilA);
            this.gBAnnui.Controls.Add(this.tBSumBankuA);
            this.gBAnnui.Controls.Add(this.lSumBankuA);
            this.gBAnnui.Location = new System.Drawing.Point(329, 12);
            this.gBAnnui.Name = "gBAnnui";
            this.gBAnnui.Size = new System.Drawing.Size(331, 146);
            this.gBAnnui.TabIndex = 2;
            this.gBAnnui.TabStop = false;
            this.gBAnnui.Text = "Аннуитетная схема";
            // 
            // lPereplataA
            // 
            this.lPereplataA.AutoSize = true;
            this.lPereplataA.Location = new System.Drawing.Point(65, 94);
            this.lPereplataA.Name = "lPereplataA";
            this.lPereplataA.Size = new System.Drawing.Size(108, 13);
            this.lPereplataA.TabIndex = 17;
            this.lPereplataA.Text = "Процент переплаты";
            // 
            // tBPereplataA
            // 
            this.tBPereplataA.Location = new System.Drawing.Point(179, 91);
            this.tBPereplataA.Name = "tBPereplataA";
            this.tBPereplataA.Size = new System.Drawing.Size(146, 20);
            this.tBPereplataA.TabIndex = 16;
            this.tBPereplataA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBVznosOut_KeyPress);
            // 
            // tBItogJilA
            // 
            this.tBItogJilA.Location = new System.Drawing.Point(179, 58);
            this.tBItogJilA.Name = "tBItogJilA";
            this.tBItogJilA.Size = new System.Drawing.Size(146, 20);
            this.tBItogJilA.TabIndex = 15;
            this.tBItogJilA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBVznosOut_KeyPress);
            // 
            // lItogJilA
            // 
            this.lItogJilA.AutoSize = true;
            this.lItogJilA.Location = new System.Drawing.Point(26, 58);
            this.lItogJilA.Name = "lItogJilA";
            this.lItogJilA.Size = new System.Drawing.Size(147, 13);
            this.lItogJilA.TabIndex = 14;
            this.lItogJilA.Text = "Итоговая стоимость жилья";
            // 
            // tBSumBankuA
            // 
            this.tBSumBankuA.Location = new System.Drawing.Point(179, 24);
            this.tBSumBankuA.Name = "tBSumBankuA";
            this.tBSumBankuA.Size = new System.Drawing.Size(146, 20);
            this.tBSumBankuA.TabIndex = 13;
            this.tBSumBankuA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBVznosOut_KeyPress);
            // 
            // lSumBankuA
            // 
            this.lSumBankuA.AutoSize = true;
            this.lSumBankuA.Location = new System.Drawing.Point(26, 24);
            this.lSumBankuA.Name = "lSumBankuA";
            this.lSumBankuA.Size = new System.Drawing.Size(147, 13);
            this.lSumBankuA.TabIndex = 12;
            this.lSumBankuA.Text = "Суммарные выплаты банку";
            // 
            // gBDiff
            // 
            this.gBDiff.Controls.Add(this.lPereplataD);
            this.gBDiff.Controls.Add(this.tBPereplataD);
            this.gBDiff.Controls.Add(this.tBItogJilD);
            this.gBDiff.Controls.Add(this.lItogJilD);
            this.gBDiff.Controls.Add(this.tBSumBankuD);
            this.gBDiff.Controls.Add(this.lSumBankuD);
            this.gBDiff.Location = new System.Drawing.Point(329, 171);
            this.gBDiff.Name = "gBDiff";
            this.gBDiff.Size = new System.Drawing.Size(331, 146);
            this.gBDiff.TabIndex = 3;
            this.gBDiff.TabStop = false;
            this.gBDiff.Text = "Дифференциальная схема";
            // 
            // lPereplataD
            // 
            this.lPereplataD.AutoSize = true;
            this.lPereplataD.Location = new System.Drawing.Point(55, 100);
            this.lPereplataD.Name = "lPereplataD";
            this.lPereplataD.Size = new System.Drawing.Size(108, 13);
            this.lPereplataD.TabIndex = 23;
            this.lPereplataD.Text = "Процент переплаты";
            // 
            // tBPereplataD
            // 
            this.tBPereplataD.Location = new System.Drawing.Point(169, 97);
            this.tBPereplataD.Name = "tBPereplataD";
            this.tBPereplataD.Size = new System.Drawing.Size(146, 20);
            this.tBPereplataD.TabIndex = 22;
            this.tBPereplataD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBVznosOut_KeyPress);
            // 
            // tBItogJilD
            // 
            this.tBItogJilD.Location = new System.Drawing.Point(169, 64);
            this.tBItogJilD.Name = "tBItogJilD";
            this.tBItogJilD.Size = new System.Drawing.Size(146, 20);
            this.tBItogJilD.TabIndex = 21;
            this.tBItogJilD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBVznosOut_KeyPress);
            // 
            // lItogJilD
            // 
            this.lItogJilD.AutoSize = true;
            this.lItogJilD.Location = new System.Drawing.Point(16, 64);
            this.lItogJilD.Name = "lItogJilD";
            this.lItogJilD.Size = new System.Drawing.Size(147, 13);
            this.lItogJilD.TabIndex = 20;
            this.lItogJilD.Text = "Итоговая стоимость жилья";
            // 
            // tBSumBankuD
            // 
            this.tBSumBankuD.Location = new System.Drawing.Point(169, 30);
            this.tBSumBankuD.Name = "tBSumBankuD";
            this.tBSumBankuD.Size = new System.Drawing.Size(146, 20);
            this.tBSumBankuD.TabIndex = 19;
            this.tBSumBankuD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBVznosOut_KeyPress);
            // 
            // lSumBankuD
            // 
            this.lSumBankuD.AutoSize = true;
            this.lSumBankuD.Location = new System.Drawing.Point(16, 30);
            this.lSumBankuD.Name = "lSumBankuD";
            this.lSumBankuD.Size = new System.Drawing.Size(147, 13);
            this.lSumBankuD.TabIndex = 18;
            this.lSumBankuD.Text = "Суммарные выплаты банку";
            // 
            // bRasschet
            // 
            this.bRasschet.Location = new System.Drawing.Point(329, 341);
            this.bRasschet.Name = "bRasschet";
            this.bRasschet.Size = new System.Drawing.Size(248, 48);
            this.bRasschet.TabIndex = 4;
            this.bRasschet.Text = "Рассчитать";
            this.bRasschet.UseVisualStyleBackColor = true;
            this.bRasschet.Click += new System.EventHandler(this.bRasschet_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(601, 341);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(62, 48);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // labelDataStart
            // 
            this.labelDataStart.AutoSize = true;
            this.labelDataStart.Location = new System.Drawing.Point(9, 333);
            this.labelDataStart.Name = "labelDataStart";
            this.labelDataStart.Size = new System.Drawing.Size(129, 13);
            this.labelDataStart.TabIndex = 6;
            this.labelDataStart.Text = "Дата начала платежей: ";
            this.labelDataStart.Visible = false;
            // 
            // labelDataEnd
            // 
            this.labelDataEnd.AutoSize = true;
            this.labelDataEnd.Location = new System.Drawing.Point(9, 358);
            this.labelDataEnd.Name = "labelDataEnd";
            this.labelDataEnd.Size = new System.Drawing.Size(147, 13);
            this.labelDataEnd.TabIndex = 7;
            this.labelDataEnd.Text = "Дата окончания платежей: ";
            this.labelDataEnd.Visible = false;
            // 
            // labelVigoda
            // 
            this.labelVigoda.AutoSize = true;
            this.labelVigoda.Location = new System.Drawing.Point(9, 383);
            this.labelVigoda.Name = "labelVigoda";
            this.labelVigoda.Size = new System.Drawing.Size(57, 13);
            this.labelVigoda.TabIndex = 8;
            this.labelVigoda.Text = "Выгоднее";
            this.labelVigoda.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 401);
            this.Controls.Add(this.labelVigoda);
            this.Controls.Add(this.labelDataEnd);
            this.Controls.Add(this.labelDataStart);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bRasschet);
            this.Controls.Add(this.gBDiff);
            this.Controls.Add(this.gBAnnui);
            this.Controls.Add(this.gBMid);
            this.Controls.Add(this.gBInput);
            this.Name = "Form1";
            this.Text = "Ипотечный калькулятор";
            this.gBInput.ResumeLayout(false);
            this.gBInput.PerformLayout();
            this.gBMid.ResumeLayout(false);
            this.gBMid.PerformLayout();
            this.gBAnnui.ResumeLayout(false);
            this.gBAnnui.PerformLayout();
            this.gBDiff.ResumeLayout(false);
            this.gBDiff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBInput;
        private System.Windows.Forms.GroupBox gBMid;
        private System.Windows.Forms.GroupBox gBAnnui;
        private System.Windows.Forms.GroupBox gBDiff;
        private System.Windows.Forms.Button bRasschet;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox tBCNedv;
        private System.Windows.Forms.Label lCNedv;
        private System.Windows.Forms.TextBox tBVznos;
        private System.Windows.Forms.Label lVznos;
        private System.Windows.Forms.TextBox tBSrok;
        private System.Windows.Forms.Label lSrok;
        private System.Windows.Forms.TextBox tBGodProc;
        private System.Windows.Forms.Label lGodProc;
        private System.Windows.Forms.TextBox tBIpotekaSum;
        private System.Windows.Forms.Label lIpotekaSum;
        private System.Windows.Forms.TextBox tBVznosOut;
        private System.Windows.Forms.Label lVznosOut;
        private System.Windows.Forms.Label lPereplataA;
        private System.Windows.Forms.TextBox tBPereplataA;
        private System.Windows.Forms.TextBox tBItogJilA;
        private System.Windows.Forms.Label lItogJilA;
        private System.Windows.Forms.TextBox tBSumBankuA;
        private System.Windows.Forms.Label lSumBankuA;
        private System.Windows.Forms.Label lPereplataD;
        private System.Windows.Forms.TextBox tBPereplataD;
        private System.Windows.Forms.TextBox tBItogJilD;
        private System.Windows.Forms.Label lItogJilD;
        private System.Windows.Forms.TextBox tBSumBankuD;
        private System.Windows.Forms.Label lSumBankuD;
        private System.Windows.Forms.Label labelDataStart;
        private System.Windows.Forms.Label labelDataEnd;
        private System.Windows.Forms.Label labelVigoda;
    }
}

