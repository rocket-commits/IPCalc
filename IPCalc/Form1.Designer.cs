﻿namespace IPCalc
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstOctet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSecondOctet = new System.Windows.Forms.TextBox();
            this.tbThirdOctet = new System.Windows.Forms.TextBox();
            this.tbFourthOctet = new System.Windows.Forms.TextBox();
            this.cbMask = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIPBinary = new System.Windows.Forms.TextBox();
            this.tbMaskBinary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIDIP = new System.Windows.Forms.TextBox();
            this.tbIDIPBinary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBroadcast = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbFirstIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLastIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNumberHosts = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Calculator AIO";
            // 
            // tbFirstOctet
            // 
            this.tbFirstOctet.Location = new System.Drawing.Point(109, 14);
            this.tbFirstOctet.Name = "tbFirstOctet";
            this.tbFirstOctet.Size = new System.Drawing.Size(69, 20);
            this.tbFirstOctet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP";
            // 
            // tbSecondOctet
            // 
            this.tbSecondOctet.Location = new System.Drawing.Point(184, 14);
            this.tbSecondOctet.Name = "tbSecondOctet";
            this.tbSecondOctet.Size = new System.Drawing.Size(69, 20);
            this.tbSecondOctet.TabIndex = 3;
            // 
            // tbThirdOctet
            // 
            this.tbThirdOctet.Location = new System.Drawing.Point(259, 14);
            this.tbThirdOctet.Name = "tbThirdOctet";
            this.tbThirdOctet.Size = new System.Drawing.Size(69, 20);
            this.tbThirdOctet.TabIndex = 4;
            // 
            // tbFourthOctet
            // 
            this.tbFourthOctet.Location = new System.Drawing.Point(334, 14);
            this.tbFourthOctet.Name = "tbFourthOctet";
            this.tbFourthOctet.Size = new System.Drawing.Size(69, 20);
            this.tbFourthOctet.TabIndex = 5;
            // 
            // cbMask
            // 
            this.cbMask.FormattingEnabled = true;
            this.cbMask.Location = new System.Drawing.Point(409, 14);
            this.cbMask.Name = "cbMask";
            this.cbMask.Size = new System.Drawing.Size(57, 21);
            this.cbMask.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP binary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mask binary";
            // 
            // tbIPBinary
            // 
            this.tbIPBinary.Location = new System.Drawing.Point(109, 40);
            this.tbIPBinary.Name = "tbIPBinary";
            this.tbIPBinary.Size = new System.Drawing.Size(357, 20);
            this.tbIPBinary.TabIndex = 9;
            // 
            // tbMaskBinary
            // 
            this.tbMaskBinary.Location = new System.Drawing.Point(109, 92);
            this.tbMaskBinary.Name = "tbMaskBinary";
            this.tbMaskBinary.Size = new System.Drawing.Size(357, 20);
            this.tbMaskBinary.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID IP Binary";
            // 
            // tbIDIP
            // 
            this.tbIDIP.Location = new System.Drawing.Point(109, 118);
            this.tbIDIP.Name = "tbIDIP";
            this.tbIDIP.Size = new System.Drawing.Size(357, 20);
            this.tbIDIP.TabIndex = 13;
            // 
            // tbIDIPBinary
            // 
            this.tbIDIPBinary.Location = new System.Drawing.Point(109, 144);
            this.tbIDIPBinary.Name = "tbIDIPBinary";
            this.tbIDIPBinary.Size = new System.Drawing.Size(357, 20);
            this.tbIDIPBinary.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Broadcast IP";
            // 
            // tbBroadcast
            // 
            this.tbBroadcast.Location = new System.Drawing.Point(109, 170);
            this.tbBroadcast.Name = "tbBroadcast";
            this.tbBroadcast.Size = new System.Drawing.Size(357, 20);
            this.tbBroadcast.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 367);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tbMask);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnProcess);
            this.tabPage1.Controls.Add(this.tbNumberHosts);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbLastIP);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbFirstIP);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbBroadcast);
            this.tabPage1.Controls.Add(this.tbFirstOctet);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbSecondOctet);
            this.tabPage1.Controls.Add(this.tbIDIPBinary);
            this.tabPage1.Controls.Add(this.tbThirdOctet);
            this.tabPage1.Controls.Add(this.tbIDIP);
            this.tabPage1.Controls.Add(this.tbFourthOctet);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbMask);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbMaskBinary);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbIPBinary);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IPv4";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IPv6";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(483, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Converter";
            // 
            // tbFirstIP
            // 
            this.tbFirstIP.Location = new System.Drawing.Point(109, 196);
            this.tbFirstIP.Name = "tbFirstIP";
            this.tbFirstIP.Size = new System.Drawing.Size(357, 20);
            this.tbFirstIP.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "First IP";
            // 
            // tbLastIP
            // 
            this.tbLastIP.Location = new System.Drawing.Point(109, 222);
            this.tbLastIP.Name = "tbLastIP";
            this.tbLastIP.Size = new System.Drawing.Size(357, 20);
            this.tbLastIP.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Last IP";
            // 
            // tbNumberHosts
            // 
            this.tbNumberHosts.Location = new System.Drawing.Point(109, 248);
            this.tbNumberHosts.Name = "tbNumberHosts";
            this.tbNumberHosts.Size = new System.Drawing.Size(357, 20);
            this.tbNumberHosts.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hosts available";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(391, 295);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 18;
            this.btnProcess.Text = "Go";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // tbMask
            // 
            this.tbMask.Location = new System.Drawing.Point(109, 66);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(357, 20);
            this.tbMask.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Mask";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IPCalc.Properties.Resources.geometric_1732847_640;
            this.ClientSize = new System.Drawing.Size(524, 415);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IP Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstOctet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSecondOctet;
        private System.Windows.Forms.TextBox tbThirdOctet;
        private System.Windows.Forms.TextBox tbFourthOctet;
        private System.Windows.Forms.ComboBox cbMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIPBinary;
        private System.Windows.Forms.TextBox tbMaskBinary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIDIP;
        private System.Windows.Forms.TextBox tbIDIPBinary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBroadcast;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox tbNumberHosts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLastIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFirstIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMask;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}
