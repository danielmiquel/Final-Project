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
    public partial class ShowChild : Form
    {
        protected int index;
        protected FoodSelection meal;
        protected ListInformationAllDays list = new ListInformationAllDays();
        protected DateTime time = DateTime.Now;
        protected ListOfChildren listChildren;
        protected ListOfMeals listMeals;
        protected List<InformationOfDay> listOfChild;
        protected string[] meals = new string[3];
        protected Dictionary<string, string> language;

        public ShowChild(int i, ListOfChildren lc, ListOfMeals lm, Dictionary<string, string> d)
        {
            InitializeComponent();
            index = i;
            listChildren = lc;
            listMeals = lm;
            meal = new FoodSelection(lc,lm);
            listOfChild = list.GetInformationOfAChild(index + 1);
            language = d;
        }

        private void ShowChild_Load(object sender, EventArgs e)
        {

            Day birth = listChildren.GetChildOfList(index).GetBirthday();
            Day today = new Day();

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
            btDiet.Text = language["Diet"];


            today.day = time.Day;
            today.month = time.Month;
            today.year = time.Year;
            
            foreach (InformationOfDay j in list.GetInformationOfAChild(index + 1))
            {
                cbDaysInformation.Items.Add(j.GetDayForShow());
            }

            tbBirthday.Text = birth.day + "/" + birth.month + "/" + birth.year;
            tbName.Text = listChildren.GetChildOfList(index).GetName();
            tbSurnames.Text = listChildren.GetChildOfList(index).GetSurname();
            tbSex.Text = listChildren.GetChildOfList(index).GetSex().ToString();
            tbCod.Text = listChildren.GetChildOfList(index).GetCod().ToString();
            tbObservations.Text = listChildren.GetChildOfList(index).GetObservations();
            tbAllergies.Text = listChildren.GetChildOfList(index).GetAllergies();
            tbAge.Text = listChildren.GetChildOfList(index).GetAge().ToString();
            lbTypeAge.Text = listChildren.GetChildOfList(index).GetTypeAge();

            /*
            meals[0] = meal.GetBreakfast();
            meals[1] = meal.GetLunch();
            meals[2] = meal.GetSnack();
            */
            
            tbFoodBreakfast.Text = meal.GetBreakfast();
            tbFoodLunch.Text = meal.GetLunch();
            tbFoodSnack.Text = meal.GetSnack();

            dtpSinceSleepMor.Format = DateTimePickerFormat.Custom;
            dtpSinceSleepMor.CustomFormat = "HH : mm";
            dtpUntilSleepMor.Format = DateTimePickerFormat.Custom;
            dtpUntilSleepMor.CustomFormat = "HH : mm";
            dtpSinceSleepAft.Format = DateTimePickerFormat.Custom;
            dtpSinceSleepAft.CustomFormat = "HH : mm";
            dtpUntilSleepAft.Format = DateTimePickerFormat.Custom;
            dtpUntilSleepAft.CustomFormat = "HH : mm";
            cbDaysInformation.Text = time.Day + "/" + time.Month + "/" + time.Year;

            InformationOfDay information = list.GetInformationOfAChildFromDate(
                today, listChildren.GetChildOfList(index).GetCod());
            
            if (information != null)
            {
                if (information.GetEatAmoutB() == 1)
                    cbEatBreakAll.CheckState = CheckState.Checked;
                else if (information.GetEatAmoutB() == 2)
                    cbEatBreakHalf.CheckState = CheckState.Checked;
                else if (information.GetEatAmoutB() == 3)
                    cbEatBreakLittle.CheckState = CheckState.Checked;

                if (information.GetEatAmoutL() == 1)
                    cbEatLunchAll.CheckState = CheckState.Checked;
                else if (information.GetEatAmoutL() == 2)
                    cbEatLunchHalf.CheckState = CheckState.Checked;
                else if (information.GetEatAmoutL() == 3)
                    cbEatLunchLittle.CheckState = CheckState.Checked;

                if (information.GetEatAmoutS() == 1)
                    cbEatSnackAll.CheckState = CheckState.Checked;
                else if (information.GetEatAmoutS() == 2)
                    cbEatSnackHalf.CheckState = CheckState.Checked;
                else if (information.GetEatAmoutS() == 3)
                    cbEatSnackLittle.CheckState = CheckState.Checked;
                
                switch (information.GetDepositionsMor())
                {
                    case 1:
                        cbDepositionsMorYes.CheckState = CheckState.Checked;
                        break;
                    case 2:
                        cbDepositionsMorNo.CheckState = CheckState.Checked;
                        break;
                    default:
                        break;
                }

                switch (information.GetDepositionsAft())
                {
                    case 1: cbDepositionsAftYes.CheckState = CheckState.Checked;
                        break;
                    case 2: cbDepositionsAftNo.CheckState = CheckState.Checked;
                        break;
                    default:
                        break;
                }

                /*
                if (information.GetDepositionsMor() == 1)
                    cbDepositionsMorYes.CheckState = CheckState.Checked;
                else if (information.GetDepositionsMor() == 2)
                    cbDepositionsMorNo.CheckState = CheckState.Checked;
                if (information.GetDepositionsAft() == 1)
                    cbDepositionsAftYes.CheckState = CheckState.Checked;
                else if (information.GetDepositionsAft() == 2)
                    cbDepositionsAftNo.CheckState = CheckState.Checked;
                */
                tbMessageForHome.Text = information.GetMessageForHome();
                tbMessageForSchool.Text = information.GetMessageForSchool();
                
                /*
                if(information.GetTimeSleepMorSince().hour != 0 && information.GetTimeSleepMorSince().minute != 0)
                {
                    dtpSinceSleepMor.Value= Convert.ToDateTime(information.GetTimeSleepMorSince());
                }

                if (information.GetTimeSleepMorUntil().hour != 0 && information.GetTimeSleepMorUntil().minute != 0)
                {
                    dtpUntilSleepMor.Value = Convert.ToDateTime(information.GetTimeSleepMorUntil());
                }

                if (information.GetTimeSleepAftSince().hour != 0 && information.GetTimeSleepAftSince().minute != 0)
                {
                    dtpSinceSleepAft.Value = Convert.ToDateTime(information.GetTimeSleepAftSince());
                }

                if (information.GetTimeSleepAftUntil().hour != 0 && information.GetTimeSleepAftUntil().minute != 0)
                {
                    dtpUntilSleepAft.Value = Convert.ToDateTime(information.GetTimeSleepAftUntil());
                }
                */

            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Day today = new Day();
            today.day = time.Day;
            today.month = time.Month;
            today.year = time.Year;

            int eatB = cbEatBreakAll.Checked ? 1 : cbEatBreakHalf.Checked ? 2
                : cbEatBreakLittle.Checked ? 3 : 0;
            int eatL = cbEatLunchAll.Checked ? 1 : cbEatLunchHalf.Checked ? 2
                : cbEatLunchLittle.Checked ? 3 : 0;
            int eatS = cbEatSnackAll.Checked ? 1 : cbEatSnackHalf.Checked ? 2
                : cbEatSnackLittle.Checked ? 3 : 0;
            int deposMor = cbDepositionsMorYes.Checked ? 1 : cbDepositionsMorNo.Checked ? 2 : 0;
            int deposAft = cbDepositionsAftYes.Checked ? 1 : cbDepositionsAftNo.Checked ? 2 : 0;
            int sleepMor = cbSleepMorGood.Checked ? 1 : cbSleepMorBad.Checked ? 2 : 0;
            int sleepAft = cbSleepAftGood.Checked ? 1 : cbSleepAftBad.Checked ? 2 : 0;

            InformationOfDay information = new InformationOfDay(
                Convert.ToInt32(tbCod.Text), eatB, eatL, eatS,
                tbMessageForHome.Text, tbMessageForSchool.Text,
                deposMor, deposAft, sleepMor, sleepMor);
            TimeSleep timMor1 = new TimeSleep();
            TimeSleep timMor2 = new TimeSleep();
            TimeSleep timAft1 = new TimeSleep();
            TimeSleep timAft2 = new TimeSleep();
            Day t;

            timMor1.hour = dtpSinceSleepMor.Checked ?
                dtpSinceSleepMor.Value.Hour : 0;
            timMor1.minute = dtpSinceSleepMor.Checked ?
                dtpSinceSleepMor.Value.Minute : 0;
            timMor2.hour = dtpUntilSleepMor.Checked ?
                dtpUntilSleepMor.Value.Hour : 0;
            timMor2.minute = dtpUntilSleepMor.Checked ?
                dtpUntilSleepMor.Value.Minute : 0;
            information.AddTimeSleepMor(timMor1.hour,
                timMor1.minute, timMor2.hour, timMor2.minute);

            timAft1.hour = dtpSinceSleepAft.Checked ?
                dtpSinceSleepAft.Value.Hour : 0;
            timAft1.minute = dtpSinceSleepAft.Checked ?
                dtpSinceSleepAft.Value.Minute : 0;
            timAft2.hour = dtpUntilSleepAft.Checked ?
                dtpSinceSleepAft.Value.Hour : 0;
            timAft2.minute = dtpUntilSleepAft.Checked ?
                dtpSinceSleepAft.Value.Minute : 0;
            information.AddTimeSleepAft(timAft1.hour,
                timAft1.minute, timAft2.hour, timAft2.minute);

            t.day = time.Day;
            t.month = time.Month;
            t.year = time.Year;
            information.SetDay(t);
            information.SetMeal(meal.GetBreakfast() + "?"
                + meal.GetLunch() + "?" + meal.GetSnack());

            InformationOfDay info = list.GetInformationOfAChildFromDate(
                today, listChildren.GetChildOfList(index).GetCod());
            
            if (info == null)
                list.SetInformation(information);
            
            else
                list.SetEditInformation(information);

            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbSleepMorGood_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbSleepMorBad_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btDiet_Click(object sender, EventArgs e)
        {
            DietSpecificForChild fDietAll =
                        new DietSpecificForChild(index,listChildren,listMeals,language);
            fDietAll.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDaysInformation.SelectedIndex > 0)
            {
                
                HistoricalChild h = new HistoricalChild(
                   list.GetInformationOfAChildFromDate(
                       listOfChild[cbDaysInformation.SelectedIndex].GetDay(),
                       index + 1),
                   listChildren.GetChildOfList(index),language);
                h.Show();
            }
        }

        private void lbInfoBeak_Click(object sender, EventArgs e)
        {

        }

        private void cbEatBreakLittle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEatBreakHalf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEatBreakAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEatLunchLittle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEatLunchHalf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEatLunchAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEatSnackAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEatSnackHalf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEatSnackLittle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
