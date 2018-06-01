using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class HistoricalChild : Form
    {
        protected InformationOfDay infoChild;
        protected Child child;
        protected Dictionary<string, string> language;

        public HistoricalChild(InformationOfDay i,Child c, Dictionary<string, string> d)
        {
            InitializeComponent();
            infoChild = i;
            child = c;
            language = d;
        }

        private void HistoricalChild_Load(object sender, EventArgs e)
        {
            string[] mealsArr = infoChild.GetMeal().Split('?');

            lbAge.Text = language["Age"];
            lbName.Text = language["Name"];
            lbSurnames.Text = language["Sur"];
            lbSex.Text = language["Sex"];
            lbCod.Text = language["Cod"];
            lbObservations.Text = language["Obs"];
            lbAllergies.Text = language["Aller"];
            lbMessageForSchool.Text = language["MesS"];
            lbMessgeForHome.Text = language["MesH"];
            lbInfoBeak.Text = language["IEBr"];
            lbInfLunch.Text = language["IELu"];
            lbInfSnack.Text = language["IESn"];
            cbEatBreakAll.Text = language["All"];
            cbEatBreakHalf.Text = language["Half"];
            cbEatBreakLittle.Text = language["Little"];
            cbEatLunchAll.Text = language["All"];
            cbEatLunchHalf.Text = language["Half"];
            cbEatLunchLittle.Text = language["Little"];
            cbEatSnackAll.Text = language["All"];
            cbEatSnackHalf.Text = language["Half"];
            cbEatSnackLittle.Text = language["Little"];
            lbDepositions.Text = language["Depo"];
            lbDepositionsMor.Text = language["Morn"];
            lbDepositionsAft.Text = language["Aft"];
            lbSleepMor.Text = language["Morn"];
            lbSleepAft.Text = language["Aft"];
            lbSleep.Text = language["Sleep"];
            cbDepositionsMorYes.Text = language["Y"];
            cbDepositionsAftYes.Text = language["Y"];
            cbSleepMorGood.Text = language["Good"];
            cbSleepMorBad.Text = language["Bad"];
            cbSleepAftGood.Text = language["Good"];
            cbSleepAftBad.Text = language["Bad"];
            lbSinceMor.Text = language["Since"];
            lbSinceAft.Text = language["Since"];
            lbUntilMor.Text = language["Until"];
            lbUntilAft.Text = language["Until"];

            tbSex.Text = child.GetSex().ToString();
            tbAge.Text = child.GetAge().ToString();
            tbName.Text = child.GetName();
            tbSurnames.Text = child.GetSurname();
            tbCod.Text = child.GetCod().ToString();
            tbObservations.Text = child.GetObservations();
            tbAllergies.Text = child.GetAllergies();
            lbTypeAge.Text = child.GetTypeAge();
            tbMessageForHome.Text = infoChild.GetMessageForHome();
            tbMessageForSchool.Text = infoChild.GetMessageForSchool();

            tbFoodBreakfast.Text = mealsArr[0];
            tbFoodLunch.Text = mealsArr[1];
            tbFoodSnack.Text = mealsArr[2];

            tbSinceSleepMor.Text = 
                infoChild.GetTimeSleepMorSince().hour.ToString("00")+ " : " + 
                infoChild.GetTimeSleepMorSince().minute.ToString("00");
            tbUntilSleepMor.Text = 
                infoChild.GetTimeSleepMorUntil().hour.ToString("00")+ " : " + 
                infoChild.GetTimeSleepMorUntil().minute.ToString("00");
            tbSinceSleepAft.Text = 
                infoChild.GetTimeSleepAftSince().hour.ToString("00")+ " : " + 
                infoChild.GetTimeSleepAftSince().minute.ToString("00");
            tbUntilSleepAft.Text = 
                infoChild.GetTimeSleepAftUntil().hour.ToString("00")+ " : " + 
                infoChild.GetTimeSleepAftUntil().minute.ToString("00");

            cbDaysInformation.Text = infoChild.GetDay().day + "/" +
                infoChild.GetDay().month + "/" + infoChild.GetDay().year;

            if (infoChild.GetEatAmoutB() == 1)
                cbEatBreakAll.CheckState = CheckState.Checked;
            else if (infoChild.GetEatAmoutB() == 2)
                cbEatBreakHalf.CheckState = CheckState.Checked;
            else if (infoChild.GetEatAmoutB() == 3)
                cbEatBreakLittle.CheckState = CheckState.Checked;

            if (infoChild.GetEatAmoutL() == 1)
                cbEatLunchAll.CheckState = CheckState.Checked;
            else if (infoChild.GetEatAmoutL() == 2)
                cbEatLunchHalf.CheckState = CheckState.Checked;
            else if (infoChild.GetEatAmoutL() == 3)
                cbEatLunchLittle.CheckState = CheckState.Checked;

            if (infoChild.GetEatAmoutS() == 1)
                cbEatSnackAll.CheckState = CheckState.Checked;
            else if (infoChild.GetEatAmoutS() == 2)
                cbEatSnackHalf.CheckState = CheckState.Checked;
            else if (infoChild.GetEatAmoutS() == 3)
                cbEatSnackLittle.CheckState = CheckState.Checked;

            if (infoChild.GetDepositionsMor() == 1)
                cbDepositionsMorYes.CheckState = CheckState.Checked;
            else if (infoChild.GetDepositionsMor() == 2)
                cbDepositionsMorNo.CheckState = CheckState.Checked;

            if (infoChild.GetDepositionsAft() == 1)
                cbDepositionsAftYes.CheckState = CheckState.Checked;
            else if (infoChild.GetDepositionsAft() == 2)
                cbDepositionsAftNo.CheckState = CheckState.Checked;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
