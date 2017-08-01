using System;
using System.Collections.Generic;


namespace Converter
{
    public class BaseClass
    {
        public string firstUnit;
        public string secondUnit;  

        public virtual float ReturnRelation(string unit1, string unit2)
        {
            return 0f;
        }



    }

    public class EnergyRelation:BaseClass
    {
      
        public EnergyRelation(string unit1, string unit2)
        {
            //unit1
            if (unit1.Contains("KJ"))
                firstUnit = "KJ";
            else if (unit1.Contains("Kcal"))
                firstUnit = "Kcal";
            else if (unit1.Contains("Cal"))
                firstUnit = "Cal";

            //unit2
            if (unit2.Contains("KJ"))
                secondUnit = "KJ";
            else if (unit2.Contains("Kcal"))
                secondUnit = "Kcal";
            else if (unit2.Contains("Cal"))
                secondUnit = "Cal";
         
        }   
        public override float ReturnRelation(string unit1, string unit2)
        {
            string relationName = string.Format("{0}2{1}", unit1, unit2);
            float relationValue = 0f;
            switch (relationName)
            {
                //KJ千焦
                case "KJ2Kcal":
                    relationValue = 1 / 4.182f;
                    break;
                case "KJ2KJ":
                    relationValue = 1;
                    break;
                case "KJ2Cal":
                    relationValue = 1 / 4.182f * 1000;
                    break;

                //Kcal千卡
                case "Kcal2KJ":
                    relationValue = 4.182f;
                    break;            
                case "Kcal2Kcal":
                    relationValue = 1;
                    break;
                case "Kcal2Cal":
                    relationValue = 1000;
                    break;

                //Cal 卡
                case "Cal2Cal":
                    relationValue = 1;
                    break;       
                case "Cal2Kcal":
                    relationValue = 0.001f;
                    break;             
                case "Cal2KJ":
                    relationValue = 0.00418f;
                    break;
            }

            relationValue = Convert.ToSingle(relationValue.ToString("N3"));
            return relationValue;
        }
      

       
    }


   public  class LengthRelation:BaseClass
    {
        public LengthRelation(string unit1, string unit2)
        {
            //unit1
            if (unit1.Contains("KM"))
                firstUnit = "KM";
            else if (unit1.Contains("LI"))
                firstUnit = "LI";
            else if (unit1.Contains("CH"))
                firstUnit = "CH";
            else if (unit1.Contains("FT"))
                firstUnit = "FT";
            else if (unit1.Contains("IN"))
                firstUnit = "IN";
            else if (unit1.Contains("YD"))
                firstUnit = "YD";
            else if (unit1.Contains("ZH"))
                firstUnit = "ZH";
            else if (unit1.Contains("NMI"))
                firstUnit = "NMI";
            else if (unit1.Contains("MI"))
                firstUnit = "MI";
            else if (unit1.Contains("M"))
                firstUnit = "M";
          

            //unit2
            if (unit2.Contains("KM"))
                secondUnit = "KM";
            else if (unit2.Contains("LI"))
                secondUnit = "LI";
            else if (unit2.Contains("CH"))
                secondUnit = "CH";
            else if (unit2.Contains("FT"))
                secondUnit = "FT";
            else if (unit2.Contains("IN"))
                secondUnit = "IN";
            else if (unit2.Contains("YD"))
                secondUnit = "YD";
            else if (unit2.Contains("ZH"))
                secondUnit = "ZH";
            else if (unit2.Contains("NMI"))
                secondUnit = "NMI";
            else if (unit2.Contains("MI"))
                secondUnit = "MI";
            else 
                secondUnit = "M";
            
            

        }
        public override float ReturnRelation(string unit1, string unit2)
        {
            string relationName = string.Format("{0}2{1}", unit1, unit2);
            float relationValue = 0f;
            Dictionary<string, float> lengthMap = new Dictionary<string, float>();
            //KM
            lengthMap.Add("KM2M", 1000);
            lengthMap.Add("KM2KM", 1);
            lengthMap.Add("KM2LI", 2);
            lengthMap.Add("KM2MI", 0.6214F);
            lengthMap.Add("KM2FT", 3280.84F);
            lengthMap.Add("KM2IN", 39370.0787F);
            lengthMap.Add("KM2NMI", 0.5399F);
            lengthMap.Add("KM2YD", 1093.6133F);
            lengthMap.Add("KM2CH", 3000);
            lengthMap.Add("KM2ZH", 300);

            //M
            lengthMap.Add("M2M", 1);
            lengthMap.Add("M2KM", 0.001F);
            lengthMap.Add("M2LI", 0.002F);
            lengthMap.Add("M2MI", 0.00062F);
            lengthMap.Add("M2FT", 3.2808F);
            lengthMap.Add("M2IN", 39.3701F);
            lengthMap.Add("M2NMI", 0.00000054F);
            lengthMap.Add("M2YD", 1.0936F);
            lengthMap.Add("M2CH", 3);
            lengthMap.Add("M2ZH", 0.3F);

            //LI
            lengthMap.Add("LI2M", 500);
            lengthMap.Add("LI2KM", 0.5F);
            lengthMap.Add("LI2LI", 1);
            lengthMap.Add("LI2MI", 0.3107F);
            lengthMap.Add("LI2FT", 1640.4199F);
            lengthMap.Add("LI2IN", 19685.0394F);
            lengthMap.Add("LI2NMI", 0.27F);
            lengthMap.Add("LI2YD", 546.8066F);
            lengthMap.Add("LI2CH", 1500);
            lengthMap.Add("LI2ZH", 150);

            //MI
            lengthMap.Add("MI2M", 1690.34F);
            lengthMap.Add("MI2KM", 1.6093F);
            lengthMap.Add("MI2LI", 3.2187F);
            lengthMap.Add("MI2MI", 1);
            lengthMap.Add("MI2FT", 5280F);
            lengthMap.Add("MI2IN", 63360);
            lengthMap.Add("MI2NMI", 0.869F);
            lengthMap.Add("MI2YD", 1760);
            lengthMap.Add("MI2CH", 4828.032F);
            lengthMap.Add("MI2ZH", 482.8032F);

            //FT
            lengthMap.Add("FT2M", 0.3048F);
            lengthMap.Add("FT2KM", 0.0003F);
            lengthMap.Add("FT2LI", 0.0006F);
            lengthMap.Add("FT2MI", 0.0002F);
            lengthMap.Add("FT2FT", 1);
            lengthMap.Add("FT2IN", 12);
            lengthMap.Add("FT2NMI", 0.00016F);
            lengthMap.Add("FT2YD", 0.3333F);
            lengthMap.Add("FT2CH", 0.9144F);
            lengthMap.Add("FT2ZH", 0.0914F);

            //IN
            lengthMap.Add("IN2M", 0.0254F);
            lengthMap.Add("IN2KM", 0.000025F);
            lengthMap.Add("IN2LI", 0.00005F);
            lengthMap.Add("IN2MI", 0.000016F);
            lengthMap.Add("IN2FT", 0.0833F);
            lengthMap.Add("IN2IN", 1);
            lengthMap.Add("IN2NMI", 0.000014F);
            lengthMap.Add("IN2YD", 0.0278F);
            lengthMap.Add("IN2CH", 0.0762F);
            lengthMap.Add("IN2ZH", 0.0076F);

            //NMI
            lengthMap.Add("NMI2M", 1852F);
            lengthMap.Add("NMI2KM", 1.852F);
            lengthMap.Add("NMI2LI", 3.704F);
            lengthMap.Add("NMI2MI", 1.1508F);
            lengthMap.Add("NMI2FT", 6076.1155F);
            lengthMap.Add("NMI2IN", 72913.3858F);
            lengthMap.Add("NMI2NMI", 1);
            lengthMap.Add("NMI2YD", 2025.3718F);
            lengthMap.Add("NMI2CH", 5556);
            lengthMap.Add("NMI2ZH", 555.6F);

            //YD
            lengthMap.Add("YD2M", 0.9144F);
            lengthMap.Add("YD2KM", 0.0009F);
            lengthMap.Add("YD2LI", 0.0018F);
            lengthMap.Add("YD2MI", 0.00057F);
            lengthMap.Add("YD2FT", 3);
            lengthMap.Add("YD2IN", 36);
            lengthMap.Add("YD2NMI", 0.00049F);
            lengthMap.Add("YD2YD", 1);
            lengthMap.Add("YD2CH", 2.7432F);
            lengthMap.Add("YD2ZH", 0.2743F);

            //CH
            lengthMap.Add("CH2M", 0.3333F);
            lengthMap.Add("CH2KM", 0.0003F);
            lengthMap.Add("CH2LI", 0.00067F);
            lengthMap.Add("CH2MI", 0.0002F);
            lengthMap.Add("CH2FT", 1.0936F);
            lengthMap.Add("CH2IN", 13.1234F);
            lengthMap.Add("CH2NMI", 0.00018F);
            lengthMap.Add("CH2YD", 0.3645F);
            lengthMap.Add("CH2CH", 1);
            lengthMap.Add("CH2ZH", 0.1F);

            //ZH
            lengthMap.Add("ZH2M", 3.333F);
            lengthMap.Add("ZH2KM", 0.003F);
            lengthMap.Add("ZH2LI", 0.007F);
            lengthMap.Add("ZH2MI", 0.002F);
            lengthMap.Add("ZH2FT", 10.936F);
            lengthMap.Add("ZH2IN", 131.23F);
            lengthMap.Add("ZH2NMI", 0.0018F);
            lengthMap.Add("ZH2YD", 3.645F);
            lengthMap.Add("ZH2CH", 10);
            lengthMap.Add("ZH2ZH", 1);

            try
            {
                relationValue = lengthMap[relationName];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
           
            return relationValue;
            
        }

    }

    public class AreaRelation:BaseClass
    {
        public AreaRelation(string unit1, string unit2)
        {
            //unit1
            if (unit1.Contains("MU"))
                firstUnit = "MU";
            else if (unit1.Contains("ARE"))
                firstUnit = "ARE";
            else if (unit1.Contains("HA"))
                firstUnit = "HA";
            else if (unit1.Contains("FEN"))
                firstUnit = "FEN";
            else if (unit1.Contains("KMM"))
                firstUnit = "KMM";
            else if (unit1.Contains("MM"))
                firstUnit = "MM";
            else if (unit1.Contains("IN"))
                firstUnit = "IN";
            else if (unit1.Contains("FT"))
                firstUnit = "FT";
            else if (unit1.Contains("ACRE"))
                firstUnit = "ACRE";
            else if (unit1.Contains("QIN"))
                firstUnit = "QIN";

            //unit2
            if (unit2.Contains("MU"))
                secondUnit = "MU";
            else if (unit2.Contains("ARE"))
                secondUnit = "ARE";
            else if (unit2.Contains("HA"))
                secondUnit = "HA";
            else if (unit2.Contains("FEN"))
                secondUnit = "FEN";
            else if (unit2.Contains("KMM"))
                secondUnit = "KMM";
            else if (unit2.Contains("MM"))
                secondUnit = "MM";
            else if (unit2.Contains("SQ.IN"))
                secondUnit = "IN";
            else if (unit2.Contains("SQ.FT"))
                secondUnit = "FT";
            else if (unit2.Contains("ACRE"))
                secondUnit = "ACRE";
            else if (unit2.Contains("QIN"))
                secondUnit = "QIN";

        }
        public override float ReturnRelation(string unit1, string unit2)
        {
            string relationName = string.Format("{0}2{1}", unit1, unit2);
            float relationValue = 0f;
            Dictionary<string, float> areaMap = new Dictionary<string, float>();

            //亩（MU)
            areaMap.Add("MU2MU", 1);
            areaMap.Add("MU2ARE",6.6667f);
            areaMap.Add("MU2FEN",10);
            areaMap.Add("MU2KMM",0.00067f);
            areaMap.Add("MU2MM",666.6667f);
            areaMap.Add("MU2IN",1033335.4f);
            areaMap.Add("MU2FT",7175.94f);
            areaMap.Add("MU2ACRE", 0.1647f);
            areaMap.Add("MU2QIN",0.01f);
            areaMap.Add("MU2HA", 0.0667f);

            //公亩(ARE)
            areaMap.Add("ARE2MU", 0.15f);
            areaMap.Add("ARE2ARE",1);
            areaMap.Add("ARE2HA",0.01f);
            areaMap.Add("ARE2FEN",1.5f);
            areaMap.Add("ARE2KMM",0.0001f);
            areaMap.Add("ARE2MM",100);
            areaMap.Add("ARE2IN",155000.31f);
            areaMap.Add("ARE2FT",1076.391f);
            areaMap.Add("ARE2ACRE",1 );
            areaMap.Add("ARE2QIN",0.0015f);

            //公顷(HA)
            areaMap.Add("HA2MU",15 );
            areaMap.Add("HA2ARE",100);
            areaMap.Add("HA2HA", 1);
            areaMap.Add("HA2FEN",150);
            areaMap.Add("HA2KMM",0.01f);
            areaMap.Add("HA2MM",10000);
            areaMap.Add("HA2IN",15500031);
            areaMap.Add("HA2FT",107639);
            areaMap.Add("HA2ACRE", 2.4711f);
            areaMap.Add("HA2QIN",0.15f);

            //分(FEN)
            areaMap.Add("FEN2MU",0.1f );
            areaMap.Add("FEN2ARE",0.6667f);
            areaMap.Add("FEN2HA",0.0067f);
            areaMap.Add("FEN2FEN",1);
            areaMap.Add("FEN2KMM",0.00007f);
            areaMap.Add("FEN2MM",66.67f);
            areaMap.Add("FEN2IN",103333);
            areaMap.Add("FEN2FT",717.594f);
            areaMap.Add("FEN2ACRE", 0.0165f);
            areaMap.Add("FEN2QIN",0.001f);

            //平方千米(KMM)
            areaMap.Add("KMM2MU",1500 );
            areaMap.Add("KMM2ARE",10000);
            areaMap.Add("KMM2HA",100);
            areaMap.Add("KMM2FEN",15000);
            areaMap.Add("KMM2KMM", 1);
            areaMap.Add("KMM2MM",1000000);
            areaMap.Add("KMM2IN",1550003100);
            areaMap.Add("KMM2FT",10763910);
            areaMap.Add("KMM2ACRE", 247.1054f);
            areaMap.Add("KMM2QIN",15);

            //平方米(MM)
            areaMap.Add("MM2MU", 0.0015f);
            areaMap.Add("MM2ARE",0.01f);
            areaMap.Add("MM2HA",0.0001f);
            areaMap.Add("MM2FEN",0.015f);
            areaMap.Add("MM2KMM",0.000001f);
            areaMap.Add("MM2MM",1);
            areaMap.Add("MM2IN",1550);
            areaMap.Add("MM2FT",10.7639f);
            areaMap.Add("MM2ACRE",0.00024f );
            areaMap.Add("MM2QIN",0.000015f);

            //平方英寸(IN)
            areaMap.Add("IN2MU", 9.6774e-7f);
            areaMap.Add("IN2ARE", 6.4516e-6f);
            areaMap.Add("IN2HA", 6.4516e-8f);
            areaMap.Add("IN2FEN", 9.6774e-6f);
            areaMap.Add("IN2KMM", 6.4516e-10f);
            areaMap.Add("IN2MM", 0.0006452f);
            areaMap.Add("IN2IN", 1);
            areaMap.Add("IN2FT", 0.0069444f);
            areaMap.Add("IN2ACRE", 1.5942e-7f);
            areaMap.Add("IN2QIN", 9.6774e-9f);

            //平方英尺(FT)
            areaMap.Add("FT2MU", 0.0001394f);
            areaMap.Add("FT2ARE", 0.000929f);
            areaMap.Add("FT2HA", 9.2903e-6f);
            areaMap.Add("FT2FEN", 0.0013935f);
            areaMap.Add("FT2KMM", 9.2903e-8f);
            areaMap.Add("FT2MM", 0.092903f);
            areaMap.Add("FT2IN",144);
            areaMap.Add("FT2FT", 1);
            areaMap.Add("FT2ACRE", 0.000023f);
            areaMap.Add("FT2QIN", 1.3935e-6f);

            //英亩(ACRE)
            areaMap.Add("ACRE2MU", 6.07f);
            areaMap.Add("ACRE2ARE", 40.4686f);
            areaMap.Add("ACRE2HA", 0.4047f);
            areaMap.Add("ACRE2FEN", 60.7028f);
            areaMap.Add("ACRE2KMM", 0.00405f);
            areaMap.Add("ACRE2MM", 4046.856f);
            areaMap.Add("ACRE2IN", 6272640);
            areaMap.Add("ACRE2FT", 43560);
            areaMap.Add("ACRE2ACRE",1 );
            areaMap.Add("ACRE2QIN", 0.0607f);

            //顷(QIN)
            areaMap.Add("QIN2MU", 100);
            areaMap.Add("QIN2ARE",666.667f);
            areaMap.Add("QIN2HA",6.667f);
            areaMap.Add("QIN2FEN",1000);
            areaMap.Add("QIN2KMM",0.0667f);
            areaMap.Add("QIN2MM", 66666.67f);
            areaMap.Add("QIN2IN", 103333540);
            areaMap.Add("QIN2FT", 717594);
            areaMap.Add("QIN2ACRE", 16.474f);
            areaMap.Add("QIN2QIN",1);

            try
            {
                relationValue = areaMap[relationName];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }

            return relationValue;
        }
    }


   public class WeightRelation:BaseClass
    {
        public WeightRelation(string unit1, string unit2)
        {
            //unit1
            if (unit1.Contains("KG"))
                firstUnit = "KG";
            else if (unit1.Contains("OZ"))
                firstUnit = "OZ";
            else if (unit1.Contains("CT"))
                firstUnit = "CT";
            else if (unit1.Contains("LB"))
                firstUnit = "LB";
            else
                firstUnit = "G";

            //unit2
            if (unit2.Contains("KG"))
                secondUnit = "KG";
            else if (unit2.Contains("OZ"))
                secondUnit = "OZ";
            else if (unit2.Contains("CT"))
                secondUnit = "CT";
            else if (unit2.Contains("LB"))
                secondUnit = "LB";
            else
                secondUnit = "G";

        }
        public override float ReturnRelation(string unit1, string unit2)
        {
            string relationName = string.Format("{0}2{1}", unit1, unit2);
            float relationValue = 0f;
            
            switch (relationName)
            {
                //KG
                case "KG2KG":
                    relationValue = 1;
                    break;
                case "KG2G":
                    relationValue = 1000;
                    break;
                case "KG2OZ":
                    relationValue = 35.27396F;
                    break;
                case "KG2CT":
                    relationValue = 5000;
                    break;
                case "KG2LB":
                    relationValue = 2.2046F;
                    break;

                //G
                case "G2KG":
                    relationValue = 0.001F;
                    break;
                case "G2G":
                    relationValue = 1;
                    break;
                case "G2OZ":
                    relationValue = 0.03527F;
                    break;
                case "G2CT":
                    relationValue = 5;
                    break;
                case "G2LB":
                    relationValue = 0.0022F;
                    break;

                //OZ
                case "OZ2KG":
                    relationValue = 0.02835F;
                    break;
                case "OZ2G":
                    relationValue = 28.35F;
                    break;
                case "OZ2OZ":
                    relationValue = 1;
                    break;
                case "OZ2CT":
                    relationValue = 141.7476F;
                    break;
                case "OZ2LB":
                    relationValue = 0.0625F;
                    break;

                //CT
                case "CT2KG":
                    relationValue = 0.0002F;
                    break;
                case "CT2G":
                    relationValue = 0.2F;
                    break;
                case "CT2OZ":
                    relationValue = 0.007055F;
                    break;
                case "CT2CT":
                    relationValue = 1;
                    break;
                case "CT2LB":
                    relationValue = 0.00044F;
                    break;

                //LB
                case "LB2KG":
                    relationValue = 0.4536F;
                    break;
                case "LB2G":
                    relationValue = 453.59F;
                    break;
                case "LB2OZ":
                    relationValue = 16;
                    break;
                case "LB2CT":
                    relationValue = 2267.9619F;
                    break;
                case "LB2LB":
                    relationValue = 1;
                    break;
            }

            return relationValue;
        }
    }


   public class TempRelation:BaseClass
    {
        public TempRelation(string unit1, string unit2)
        {
            //unit1
            if (unit1.Contains("F"))
                firstUnit = "F";
            else if (unit1.Contains("C"))
                firstUnit = "C";
           
            //unit2
            if (unit2.Contains("F"))
                secondUnit = "F";
            else if (unit2.Contains("C"))
                secondUnit = "C";         
        }
        public float ReturnValue(string unit1, string unit2,float inputValue)
        {
            string relationName = string.Format("{0}2{1}", unit1, unit2);
            float returnValue = 0f;
            switch (relationName)
            {
                case "F2F":
                    returnValue = inputValue;
                    break;
                case "C2C":
                    returnValue = inputValue;
                    break;
                case "F2C":
                    returnValue = Convert.ToSingle((inputValue-32)/1.8);
                    break;
                case "C2F":
                    returnValue = Convert.ToSingle(inputValue*1.8+32);
                    break;
                
            }

            if (returnValue != 0)
            {
                returnValue = Convert.ToSingle(returnValue.ToString("N2"));
            }
            return returnValue;
        }
        public string ReturnShowstring(string unit1, string unit2, float inputvalue)
        {
            string relationName = string.Format("{0}2{1}", unit1, unit2);
            string returnValue = "";
            switch (relationName)
            {
                case "F2F":
                    returnValue = string.Format("1*{0} = ",inputvalue);
                    break;
                case "C2C":
                    returnValue = string.Format("1*{0} = ", inputvalue);
                    break;
                case "F2C":
                    returnValue = string.Format("({0} - 32)/1.8 = ", inputvalue);
                    break;
                case "C2F":
                    returnValue = string.Format("{0}*1.8 +32 = ",inputvalue);
                    break;

            }
            return returnValue;
        }
    }


}
