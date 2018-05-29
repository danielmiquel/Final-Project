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
        protected FoodSelection meal = new FoodSelection();
        protected ListInformationAllDays list = new ListInformationAllDays();
        protected DateTime time = DateTime.Now;

        public ShowChild(int i)
        {
            
            InitializeComponent();
            index = i;

        }

        private void ShowChild_Load(object sender, EventArgs e)
        {
            ListOfChildren listChildren = new ListOfChildren();
            
            foreach(InformationOfDay j in list.GetInformationOfAChild(index))
            {
                comboBox1.Items.Add(j.GetDayForShow());
            }

            tbName.Text = listChildren.GetChildOfList(index).GetName();
            tbSurnames.Text = listChildren.GetChildOfList(index).GetSurname();
            tbSex.Text = listChildren.GetChildOfList(index).GetSex().ToString();
            tbCod.Text = listChildren.GetChildOfList(index).GetCod().ToString();
            tbObservations.Text = listChildren.GetChildOfList(index).GetObservations();
            tbAllergies.Text = listChildren.GetChildOfList(index).GetAllergies();
            tbAge.Text = listChildren.GetChildOfList(index).GetAge().ToString();
            lbTypeAge.Text = listChildren.GetChildOfList(index).GetTypeAge();

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
            comboBox1.Text = time.Day + "/" + time.Month + "/" + time.Year;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            ListInformationAllDays list = new ListInformationAllDays();

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

            timMor1.hour = dtpSinceSleepMor.Value.Hour;
            timMor1.minute = dtpSinceSleepMor.Value.Minute;
            timMor2.hour = dtpUntilSleepMor.Value.Hour;
            timMor2.minute = dtpUntilSleepMor.Value.Minute;
            information.AddTimeSleepMor(timMor1.hour, timMor1.minute, timMor2.hour, timMor2.minute);

            timAft1.hour = dtpSinceSleepAft.Value.Hour;
            timAft1.minute = dtpSinceSleepAft.Value.Minute;
            timAft2.hour = dtpUntilSleepAft.Value.Hour;
            timAft2.minute = dtpUntilSleepAft.Value.Minute;
            information.AddTimeSleepAft(timAft1.hour, timAft1.minute, timAft2.hour, timAft2.minute);

            t.day = time.Day;
            t.month = time.Month;
            t.year = time.Year;
            information.SetDay(t);
            information.SetMeal(meal.GetBreakfast() + "," 
                + meal.GetLunch() + "," + meal.GetSnack());
            list.SetInformation(information);
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
                        new DietSpecificForChild(index);
            fDietAll.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 1)
            {
                HistoricalChild h = new HistoricalChild();
                h.Show();
            }
        }

        private void lbInfoBeak_Click(object sender, EventArgs e)
        {

        }
    }
}
