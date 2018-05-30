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

        public HistoricalChild(InformationOfDay i,Child c)
        {
            InitializeComponent();
            infoChild = i;
            child = c;
        }

        private void HistoricalChild_Load(object sender, EventArgs e)
        {
            string[] mealsArr = infoChild.GetMeal().Split('?');

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
