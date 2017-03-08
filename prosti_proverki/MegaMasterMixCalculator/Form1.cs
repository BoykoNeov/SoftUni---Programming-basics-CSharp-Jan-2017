using System;
// using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaMasterMixCalculator
{
    public partial class pcrMegaMixCalculator : Form
    {
        public pcrMegaMixCalculator()
        {
            InitializeComponent();
            
        }

        private void pcrMegaMixCalculator_Load(object sender, EventArgs e)
        {
            calculatePCRvalues();
            
        }

        private void numericUpDownPCRreactions_ValueChanged(object sender, EventArgs e)
        {
            calculatePCRvalues();
        }

        private void numericUpDownSingleReactionVolume_ValueChanged(object sender, EventArgs e)
        {
            calculatePCRvalues();
        }

        private void numericUpDownPraimer2inSingleReaction_ValueChanged(object sender, EventArgs e)
        {
            calculatePCRvalues();
        }

        private void numericUpDownPrimer1inSingleReaction_ValueChanged(object sender, EventArgs e)
        {
            calculatePCRvalues();
        }



          void calculatePCRvalues()
        {
           
           megaMixTotalVolume.Text = (numericUpDownPCRreactions.Value * (numericUpDownSingleReactionVolume.Value - numericUpDownDNAinSingleReaction.Value)).ToString();
            masterMixTotalVolume.Text = ((numericUpDownPCRreactions.Value * numericUpDownSingleReactionVolume.Value) / 2m).ToString();
            primer1TotalVolume.Text = (numericUpDownPrimer1inSingleReaction.Value * numericUpDownPCRreactions.Value).ToString();
            primer2TotalVolume.Text = (numericUpDownPraimer2inSingleReaction.Value * numericUpDownPCRreactions.Value).ToString();
            waterTotalVolume.Text = ( (numericUpDownSingleReactionVolume.Value * numericUpDownPCRreactions.Value) - 
                (decimal.Parse(primer1TotalVolume.Text) +
                decimal.Parse(primer2TotalVolume.Text) + decimal.Parse(masterMixTotalVolume.Text) + (numericUpDownDNAinSingleReaction.Value * numericUpDownPCRreactions.Value)) ).ToString();

   //         decimal MegaMixVolumeInEachTube = (decimal.Parse(megaMixTotalVolume.Text) - (numericUpDownPCRreactions.Value * numericUpDownDNAinSingleReaction.Value));

            BottomTextConclusion.Text = String.Format("Във всяка PCR епруветка добавете по {0} микролитра от мегамикса и {1} микролитра матрична ДНК{2}",
                (decimal.Parse(megaMixTotalVolume.Text)  / numericUpDownPCRreactions.Value) , numericUpDownDNAinSingleReaction.Value , "\r\n (*всички обеми са в микролитри)");
         //   BottomTextConclusion.Text = String.Format("Във всяка PCR евруветка добавете по {0} микролитра от мегамикса и {1}", MegaMixVolumeInEachTube, numericUpDownDNAinSingleReaction.Value
         //       + "микролитра матрична ДНК");
             
                
            if (decimal.Parse(waterTotalVolume.Text) < 0)
            {
                megaMixTotalVolume.Text = "Невалидна стойност";
                masterMixTotalVolume.Text = megaMixTotalVolume.Text;
                primer1TotalVolume.Text = megaMixTotalVolume.Text;
                primer2TotalVolume.Text = megaMixTotalVolume.Text;
                waterTotalVolume.Text = megaMixTotalVolume.Text;

                BottomTextConclusion.Text = "Въведени невалидни стойности";
            }



        }

        private void numericUpDownDNAinSingleReaction_ValueChanged(object sender, EventArgs e)
        {
            calculatePCRvalues();
        }
    }
}
