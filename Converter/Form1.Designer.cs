namespace Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_showEnergy = new System.Windows.Forms.TextBox();
            this.comboBox_Energy2 = new System.Windows.Forms.ComboBox();
            this.button_Energy = new System.Windows.Forms.Button();
            this.comboBox_Energy1 = new System.Windows.Forms.ComboBox();
            this.textBox_Energy = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_showLength = new System.Windows.Forms.TextBox();
            this.comboBox_Length2 = new System.Windows.Forms.ComboBox();
            this.button_Length = new System.Windows.Forms.Button();
            this.comboBox_Length1 = new System.Windows.Forms.ComboBox();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_showArea = new System.Windows.Forms.TextBox();
            this.comboBox_Area2 = new System.Windows.Forms.ComboBox();
            this.button_Area = new System.Windows.Forms.Button();
            this.comboBox_Area1 = new System.Windows.Forms.ComboBox();
            this.textBox_Area = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox_showWeight = new System.Windows.Forms.TextBox();
            this.comboBox_Weight2 = new System.Windows.Forms.ComboBox();
            this.button_Weight = new System.Windows.Forms.Button();
            this.comboBox_Weight1 = new System.Windows.Forms.ComboBox();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox_showTemp = new System.Windows.Forms.TextBox();
            this.comboBox_Temp2 = new System.Windows.Forms.ComboBox();
            this.button_Temp = new System.Windows.Forms.Button();
            this.comboBox_Temp1 = new System.Windows.Forms.ComboBox();
            this.textBox_Temp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 284);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 284);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.textBox_showEnergy);
            this.tabPage1.Controls.Add(this.comboBox_Energy2);
            this.tabPage1.Controls.Add(this.button_Energy);
            this.tabPage1.Controls.Add(this.comboBox_Energy1);
            this.tabPage1.Controls.Add(this.textBox_Energy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "功/热/能";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_showEnergy
            // 
            this.textBox_showEnergy.Location = new System.Drawing.Point(22, 106);
            this.textBox_showEnergy.Name = "textBox_showEnergy";
            this.textBox_showEnergy.Size = new System.Drawing.Size(377, 20);
            this.textBox_showEnergy.TabIndex = 4;
            // 
            // comboBox_Energy2
            // 
            this.comboBox_Energy2.FormattingEnabled = true;
            this.comboBox_Energy2.Items.AddRange(new object[] {
            "千卡(Kcal)",
            "千焦(KJ)",
            "卡(Cal)"});
            this.comboBox_Energy2.Location = new System.Drawing.Point(316, 39);
            this.comboBox_Energy2.Name = "comboBox_Energy2";
            this.comboBox_Energy2.Size = new System.Drawing.Size(81, 21);
            this.comboBox_Energy2.TabIndex = 3;
            this.comboBox_Energy2.Text = "千卡(Kcal)";
            // 
            // button_Energy
            // 
            this.button_Energy.Location = new System.Drawing.Point(229, 39);
            this.button_Energy.Name = "button_Energy";
            this.button_Energy.Size = new System.Drawing.Size(75, 23);
            this.button_Energy.TabIndex = 2;
            this.button_Energy.Text = "Convert";
            this.button_Energy.UseVisualStyleBackColor = true;
            this.button_Energy.Click += new System.EventHandler(this.button_Energy_Click);
            // 
            // comboBox_Energy1
            // 
            this.comboBox_Energy1.FormattingEnabled = true;
            this.comboBox_Energy1.Items.AddRange(new object[] {
            "千卡(Kcal)",
            "千焦(KJ)",
            "卡(Cal)"});
            this.comboBox_Energy1.Location = new System.Drawing.Point(138, 42);
            this.comboBox_Energy1.Name = "comboBox_Energy1";
            this.comboBox_Energy1.Size = new System.Drawing.Size(81, 21);
            this.comboBox_Energy1.TabIndex = 1;
            this.comboBox_Energy1.Text = "千焦(KJ)";
            // 
            // textBox_Energy
            // 
            this.textBox_Energy.Location = new System.Drawing.Point(23, 43);
            this.textBox_Energy.Name = "textBox_Energy";
            this.textBox_Energy.Size = new System.Drawing.Size(100, 20);
            this.textBox_Energy.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.textBox_showLength);
            this.tabPage2.Controls.Add(this.comboBox_Length2);
            this.tabPage2.Controls.Add(this.button_Length);
            this.tabPage2.Controls.Add(this.comboBox_Length1);
            this.tabPage2.Controls.Add(this.textBox_Length);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "长度";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_showLength
            // 
            this.textBox_showLength.Location = new System.Drawing.Point(22, 106);
            this.textBox_showLength.Name = "textBox_showLength";
            this.textBox_showLength.Size = new System.Drawing.Size(377, 20);
            this.textBox_showLength.TabIndex = 9;
            // 
            // comboBox_Length2
            // 
            this.comboBox_Length2.FormattingEnabled = true;
            this.comboBox_Length2.Items.AddRange(new object[] {
            "米(M)",
            "千米(KM)",
            "里(LI)",
            "英里(MI)",
            "英尺(FT)",
            "英寸(IN)",
            "海里(NMI)",
            "码(YD)",
            "尺(CH)",
            "丈(ZH)"});
            this.comboBox_Length2.Location = new System.Drawing.Point(316, 39);
            this.comboBox_Length2.Name = "comboBox_Length2";
            this.comboBox_Length2.Size = new System.Drawing.Size(81, 21);
            this.comboBox_Length2.TabIndex = 8;
            this.comboBox_Length2.Text = "英尺(FT)";
            // 
            // button_Length
            // 
            this.button_Length.Location = new System.Drawing.Point(229, 39);
            this.button_Length.Name = "button_Length";
            this.button_Length.Size = new System.Drawing.Size(75, 23);
            this.button_Length.TabIndex = 7;
            this.button_Length.Text = "Convert";
            this.button_Length.UseVisualStyleBackColor = true;
            this.button_Length.Click += new System.EventHandler(this.button_Length_Click);
            // 
            // comboBox_Length1
            // 
            this.comboBox_Length1.FormattingEnabled = true;
            this.comboBox_Length1.Items.AddRange(new object[] {
            "米(M)",
            "千米(KM)",
            "里(LI)",
            "英里(MI)",
            "英尺(FT)",
            "英寸(IN)",
            "海里(NMI)",
            "码(YD)",
            "尺(CH)",
            "丈(ZH)"});
            this.comboBox_Length1.Location = new System.Drawing.Point(138, 42);
            this.comboBox_Length1.Name = "comboBox_Length1";
            this.comboBox_Length1.Size = new System.Drawing.Size(81, 21);
            this.comboBox_Length1.TabIndex = 6;
            this.comboBox_Length1.Text = "千米(KM)";
            // 
            // textBox_Length
            // 
            this.textBox_Length.Location = new System.Drawing.Point(23, 43);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(100, 20);
            this.textBox_Length.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_showArea);
            this.tabPage3.Controls.Add(this.comboBox_Area2);
            this.tabPage3.Controls.Add(this.button_Area);
            this.tabPage3.Controls.Add(this.comboBox_Area1);
            this.tabPage3.Controls.Add(this.textBox_Area);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(474, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "面积";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_showArea
            // 
            this.textBox_showArea.Location = new System.Drawing.Point(22, 106);
            this.textBox_showArea.Name = "textBox_showArea";
            this.textBox_showArea.Size = new System.Drawing.Size(377, 20);
            this.textBox_showArea.TabIndex = 14;
            // 
            // comboBox_Area2
            // 
            this.comboBox_Area2.FormattingEnabled = true;
            this.comboBox_Area2.Items.AddRange(new object[] {
            "亩(MU)",
            "公亩(ARE)",
            "公顷(HA)",
            "分(FEN)",
            "平方千米(KMM)",
            "平方米(MM)",
            "平方英寸(SQ.IN)",
            "平方英尺(SQ.FT)",
            "英亩(ACRE)",
            "顷(QIN)"});
            this.comboBox_Area2.Location = new System.Drawing.Point(336, 39);
            this.comboBox_Area2.Name = "comboBox_Area2";
            this.comboBox_Area2.Size = new System.Drawing.Size(97, 21);
            this.comboBox_Area2.TabIndex = 13;
            this.comboBox_Area2.Text = "公顷(HA)";
            // 
            // button_Area
            // 
            this.button_Area.Location = new System.Drawing.Point(246, 39);
            this.button_Area.Name = "button_Area";
            this.button_Area.Size = new System.Drawing.Size(75, 23);
            this.button_Area.TabIndex = 12;
            this.button_Area.Text = "Convert";
            this.button_Area.UseVisualStyleBackColor = true;
            this.button_Area.Click += new System.EventHandler(this.button_Area_Click);
            // 
            // comboBox_Area1
            // 
            this.comboBox_Area1.FormattingEnabled = true;
            this.comboBox_Area1.Items.AddRange(new object[] {
            "亩(MU)",
            "公亩(ARE)",
            "公顷(HA)",
            "分(FEN)",
            "平方千米(KMM)",
            "平方米(MM)",
            "平方英寸(SQ.IN)",
            "平方英尺(SQ.FT)",
            "英亩(ACRE)",
            "顷(QIN)"});
            this.comboBox_Area1.Location = new System.Drawing.Point(138, 42);
            this.comboBox_Area1.Name = "comboBox_Area1";
            this.comboBox_Area1.Size = new System.Drawing.Size(98, 21);
            this.comboBox_Area1.TabIndex = 11;
            this.comboBox_Area1.Text = "平方米(MM)";
            // 
            // textBox_Area
            // 
            this.textBox_Area.Location = new System.Drawing.Point(23, 43);
            this.textBox_Area.Name = "textBox_Area";
            this.textBox_Area.Size = new System.Drawing.Size(100, 20);
            this.textBox_Area.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox_showWeight);
            this.tabPage4.Controls.Add(this.comboBox_Weight2);
            this.tabPage4.Controls.Add(this.button_Weight);
            this.tabPage4.Controls.Add(this.comboBox_Weight1);
            this.tabPage4.Controls.Add(this.textBox_Weight);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(474, 258);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "重量";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox_showWeight
            // 
            this.textBox_showWeight.Location = new System.Drawing.Point(22, 106);
            this.textBox_showWeight.Name = "textBox_showWeight";
            this.textBox_showWeight.Size = new System.Drawing.Size(430, 20);
            this.textBox_showWeight.TabIndex = 14;
            // 
            // comboBox_Weight2
            // 
            this.comboBox_Weight2.FormattingEnabled = true;
            this.comboBox_Weight2.Items.AddRange(new object[] {
            "千克(KG)",
            "克(G)",
            "盎司(OZ)",
            "克拉(CT)",
            "磅(LB)"});
            this.comboBox_Weight2.Location = new System.Drawing.Point(330, 39);
            this.comboBox_Weight2.Name = "comboBox_Weight2";
            this.comboBox_Weight2.Size = new System.Drawing.Size(117, 21);
            this.comboBox_Weight2.TabIndex = 13;
            this.comboBox_Weight2.Text = "克(G)";
            // 
            // button_Weight
            // 
            this.button_Weight.Location = new System.Drawing.Point(247, 39);
            this.button_Weight.Name = "button_Weight";
            this.button_Weight.Size = new System.Drawing.Size(75, 23);
            this.button_Weight.TabIndex = 12;
            this.button_Weight.Text = "Convert";
            this.button_Weight.UseVisualStyleBackColor = true;
            this.button_Weight.Click += new System.EventHandler(this.button_Weight_Click);
            // 
            // comboBox_Weight1
            // 
            this.comboBox_Weight1.FormattingEnabled = true;
            this.comboBox_Weight1.Items.AddRange(new object[] {
            "千克(KG)",
            "克(G)",
            "盎司(OZ)",
            "克拉(CT)",
            "磅(LB)"});
            this.comboBox_Weight1.Location = new System.Drawing.Point(138, 42);
            this.comboBox_Weight1.Name = "comboBox_Weight1";
            this.comboBox_Weight1.Size = new System.Drawing.Size(102, 21);
            this.comboBox_Weight1.TabIndex = 11;
            this.comboBox_Weight1.Text = "千克(KG)";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(23, 43);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_Weight.TabIndex = 10;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox_showTemp);
            this.tabPage5.Controls.Add(this.comboBox_Temp2);
            this.tabPage5.Controls.Add(this.button_Temp);
            this.tabPage5.Controls.Add(this.comboBox_Temp1);
            this.tabPage5.Controls.Add(this.textBox_Temp);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(474, 258);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "温度";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox_showTemp
            // 
            this.textBox_showTemp.Location = new System.Drawing.Point(22, 106);
            this.textBox_showTemp.Name = "textBox_showTemp";
            this.textBox_showTemp.Size = new System.Drawing.Size(377, 20);
            this.textBox_showTemp.TabIndex = 14;
            // 
            // comboBox_Temp2
            // 
            this.comboBox_Temp2.FormattingEnabled = true;
            this.comboBox_Temp2.Items.AddRange(new object[] {
            "华氏度(F)",
            "摄氏度(C)"});
            this.comboBox_Temp2.Location = new System.Drawing.Point(316, 39);
            this.comboBox_Temp2.Name = "comboBox_Temp2";
            this.comboBox_Temp2.Size = new System.Drawing.Size(81, 21);
            this.comboBox_Temp2.TabIndex = 13;
            this.comboBox_Temp2.Text = "华氏度(F)";
            // 
            // button_Temp
            // 
            this.button_Temp.Location = new System.Drawing.Point(229, 39);
            this.button_Temp.Name = "button_Temp";
            this.button_Temp.Size = new System.Drawing.Size(75, 23);
            this.button_Temp.TabIndex = 12;
            this.button_Temp.Text = "Convert";
            this.button_Temp.UseVisualStyleBackColor = true;
            this.button_Temp.Click += new System.EventHandler(this.button_Temp_Click);
            // 
            // comboBox_Temp1
            // 
            this.comboBox_Temp1.FormattingEnabled = true;
            this.comboBox_Temp1.Items.AddRange(new object[] {
            "华氏度(F)",
            "摄氏度(C)"});
            this.comboBox_Temp1.Location = new System.Drawing.Point(138, 42);
            this.comboBox_Temp1.Name = "comboBox_Temp1";
            this.comboBox_Temp1.Size = new System.Drawing.Size(81, 21);
            this.comboBox_Temp1.TabIndex = 11;
            this.comboBox_Temp1.Text = "摄氏度(C)";
            // 
            // textBox_Temp
            // 
            this.textBox_Temp.Location = new System.Drawing.Point(23, 43);
            this.textBox_Temp.Name = "textBox_Temp";
            this.textBox_Temp.Size = new System.Drawing.Size(100, 20);
            this.textBox_Temp.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 321);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_showEnergy;
        private System.Windows.Forms.ComboBox comboBox_Energy2;
        private System.Windows.Forms.Button button_Energy;
        private System.Windows.Forms.ComboBox comboBox_Energy1;
        private System.Windows.Forms.TextBox textBox_Energy;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox_showLength;
        private System.Windows.Forms.ComboBox comboBox_Length2;
        private System.Windows.Forms.Button button_Length;
        private System.Windows.Forms.ComboBox comboBox_Length1;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.TextBox textBox_showArea;
        private System.Windows.Forms.ComboBox comboBox_Area2;
        private System.Windows.Forms.Button button_Area;
        private System.Windows.Forms.ComboBox comboBox_Area1;
        private System.Windows.Forms.TextBox textBox_Area;
        private System.Windows.Forms.TextBox textBox_showWeight;
        private System.Windows.Forms.ComboBox comboBox_Weight2;
        private System.Windows.Forms.Button button_Weight;
        private System.Windows.Forms.ComboBox comboBox_Weight1;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.TextBox textBox_showTemp;
        private System.Windows.Forms.ComboBox comboBox_Temp2;
        private System.Windows.Forms.Button button_Temp;
        private System.Windows.Forms.ComboBox comboBox_Temp1;
        private System.Windows.Forms.TextBox textBox_Temp;
    }
}

