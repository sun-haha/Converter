using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Energy_Click(object sender, EventArgs e)
        {
            string inputValue;
            string firstUnit;
            string secondUnit;
            float floatValue;
            float converterValue;
            float resultValue;
            string resultString;
      
            try
            {
                inputValue = textBox_Energy.Text;
                firstUnit = comboBox_Energy1.Text;
                secondUnit = comboBox_Energy2.Text;
                floatValue = Convert.ToSingle(inputValue);
                if (string.IsNullOrEmpty(firstUnit) || string.IsNullOrEmpty(secondUnit))
                {
                    MessageBox.Show("请先选择计量单位");
                    return;
                }

            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(formatEx.Message+" Please input a Valid Number in the first textbox!");
                return;
            }
            catch (Exception otherEx)
            {
                MessageBox.Show(otherEx.Message);
                return;
            }

            EnergyRelation energyTab = new EnergyRelation(firstUnit,secondUnit);   
            converterValue = energyTab.ReturnRelation(energyTab.firstUnit, energyTab.secondUnit);
            if (converterValue == 0f)
            {
                MessageBox.Show("Something is wrong, can't find converting relations");
                return;
            }
            resultValue = floatValue * converterValue;
            resultString = resultValue.ToString("N3");
            if (Regex.IsMatch(resultString.Split('.')[1], "000"))
                resultString = resultString.Split('.')[0];
            else if (Regex.IsMatch(resultString.Split('.')[1], "[1-9]00"))
                resultString = resultValue.ToString("N1");
            else if (Regex.IsMatch(resultString.Split('.')[1], "[0-9][1-9]0"))
                resultString = resultValue.ToString("N2");
 
            textBox_showEnergy.Text = string.Format("{0}{1} * {2} = {3}{4}",inputValue,firstUnit,converterValue,resultString,secondUnit);
        }

        private void button_Length_Click(object sender, EventArgs e)
        {
            string inputValue;
            string firstUnit;
            string secondUnit;
            float floatValue;
            float converterValue;
            float resultValue;
            string resultString;
            try
            {
                inputValue = textBox_Length.Text;
                firstUnit = comboBox_Length1.Text;
                secondUnit = comboBox_Length2.Text;
                floatValue = Convert.ToSingle(inputValue);
                if (string.IsNullOrEmpty(firstUnit) || string.IsNullOrEmpty(secondUnit))
                {
                    MessageBox.Show("请先选择计量单位");
                    return;
                }

            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(formatEx.Message + " Please input a Valid Number in the first textbox!");
                return;
            }
            catch (Exception otherEx)
            {
                MessageBox.Show(otherEx.Message);
                return;
            }

            LengthRelation lengthTab = new LengthRelation(firstUnit, secondUnit);
            converterValue = lengthTab.ReturnRelation(lengthTab.firstUnit, lengthTab.secondUnit);
            if (converterValue == 0)
            {
                MessageBox.Show("Something is wrong, can't find converting relations");
                return;
            }
            resultValue = floatValue * converterValue;
            resultString = resultValue.ToString("N4");
            if (Regex.IsMatch(resultString.Split('.')[1], "0000"))
                resultString = resultString.Split('.')[0];
            else if (Regex.IsMatch(resultString.Split('.')[1], "[1-9]000"))
                resultString = resultValue.ToString("N1");
            else if (Regex.IsMatch(resultString.Split('.')[1], "[0-9][1-9]00"))
                resultString = resultValue.ToString("N2");
            else if (Regex.IsMatch(resultString.Split('.')[1], "[0-9][0-9][1-9]0"))
                resultString = resultValue.ToString("N3");

            textBox_showLength.Text = string.Format("{0}{1} * {2} = {3}{4}", inputValue, firstUnit, converterValue, resultString, secondUnit);
        }

        private void button_Area_Click(object sender, EventArgs e)
        {
            string inputValue;
            string firstUnit;
            string secondUnit;
            float floatValue;
            float converterValue;
            float resultValue;
            string resultString;
            try
            {
                inputValue = textBox_Area.Text;
                firstUnit = comboBox_Area1.Text;
                secondUnit = comboBox_Area2.Text;
                floatValue = Convert.ToSingle(inputValue);
                if (string.IsNullOrEmpty(firstUnit) || string.IsNullOrEmpty(secondUnit))
                {
                    MessageBox.Show("请先选择计量单位");
                    return;
                }

            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(formatEx.Message + " Please input a Valid Number in the first textbox!");
                return;
            }
            catch (Exception otherEx)
            {
                MessageBox.Show(otherEx.Message);
                return;
            }

            AreaRelation areaTab = new AreaRelation(firstUnit, secondUnit);
            converterValue = areaTab.ReturnRelation(areaTab.firstUnit, areaTab.secondUnit);
            if (converterValue == 0)
            {
                MessageBox.Show("Something is wrong, can't find converting relations");
                return;
            }
            resultValue = floatValue * converterValue;
            resultString = resultValue.ToString("N4");
            if (Regex.IsMatch(resultString.Split('.')[1], "0000"))
                resultString = resultString.Split('.')[0];
            else if (Regex.IsMatch(resultString.Split('.')[1], "[1-9]000"))
                resultString = resultValue.ToString("N1");
            else if (Regex.IsMatch(resultString.Split('.')[1], "[0-9][1-9]00"))
                resultString = resultValue.ToString("N2");
            else if (Regex.IsMatch(resultString.Split('.')[1], "[0-9][0-9][1-9]0"))
                resultString = resultValue.ToString("N3");

            textBox_showArea.Text = string.Format("{0}{1} * {2} = {3}{4}", inputValue, firstUnit, converterValue, resultString, secondUnit);
        }

        private void button_Weight_Click(object sender, EventArgs e)
        {
            string inputValue;
            string firstUnit;
            string secondUnit;
            float floatValue;
            float converterValue;
            float resultValue;
            string resultString;
            try
            {
                inputValue = textBox_Weight.Text;
                firstUnit = comboBox_Weight1.Text;
                secondUnit = comboBox_Weight2.Text;
                floatValue = Convert.ToSingle(inputValue);
                if (string.IsNullOrEmpty(firstUnit) || string.IsNullOrEmpty(secondUnit))
                {
                    MessageBox.Show("请先选择计量单位");
                    return;
                }

            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(formatEx.Message + " Please input a Valid Number in the first textbox!");
                return;
            }
            catch (Exception otherEx)
            {
                MessageBox.Show(otherEx.Message);
                return;
            }

            WeightRelation WeightTab = new WeightRelation(firstUnit, secondUnit);
            converterValue = WeightTab.ReturnRelation(WeightTab.firstUnit, WeightTab.secondUnit);
            if (converterValue == 0)
            {
                MessageBox.Show("Something is wrong, can't find converting relations");
                return;
            }
            resultValue = floatValue * converterValue;
            resultString = resultValue.ToString("N4");

            if (Regex.IsMatch(resultString.Split('.')[1], "0000"))
                resultString = resultString.Split('.')[0];
            else if (Regex.IsMatch(resultString.Split('.')[1], "[1-9]000"))
                resultString = resultValue.ToString("N1");
            else if (Regex.IsMatch(resultString.Split('.')[1], "[0-9][1-9]00"))
                resultString = resultValue.ToString("N2");
            else if (Regex.IsMatch(resultString.Split('.')[1], "[0-9][0-9][1-9]0"))
                resultString = resultValue.ToString("N3");

            textBox_showWeight.Text = string.Format("{0}{1} * {2} = {3}{4}", inputValue, firstUnit, converterValue, resultString, secondUnit);
        }

        private void button_Temp_Click(object sender, EventArgs e)
        {
            string inputValue;
            string firstUnit;
            string secondUnit;
            string showString;
            float floatValue;
            float resultValue;
            try
            {
                inputValue = textBox_Temp.Text;
                firstUnit = comboBox_Temp1.Text;
                secondUnit = comboBox_Temp2.Text;
                floatValue = Convert.ToSingle(inputValue);
                if (string.IsNullOrEmpty(firstUnit) || string.IsNullOrEmpty(secondUnit))
                {
                    MessageBox.Show("请先选择计量单位");
                    return;
                }

            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(formatEx.Message + " Please input a Valid Number in the first textbox!");
                return;
            }
            catch (Exception otherEx)
            {
                MessageBox.Show(otherEx.Message);
                return;
            }

            TempRelation TempTab = new TempRelation(firstUnit, secondUnit);
            resultValue = TempTab.ReturnValue(TempTab.firstUnit, TempTab.secondUnit,floatValue);
            showString = TempTab.ReturnShowstring(TempTab.firstUnit, TempTab.secondUnit, floatValue);
            if (resultValue == 0)
            {
                MessageBox.Show("Something is wrong, can't find converting relations");
                return;
            }
            
            textBox_showTemp.Text = string.Format("{0}{1}{2}", showString, resultValue.ToString(), secondUnit);
        }
    
    }
}
    

