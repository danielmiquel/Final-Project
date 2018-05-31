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
    public partial class SelecLanguage : Form
    {
        protected Dictionary<string, string> language =
                new Dictionary<string, string>();
        protected ChildList childList;

        public SelecLanguage()
        {
            InitializeComponent();
        }

        private void btEnglish_Click(object sender, EventArgs e)
        {
            language.Add("Info", "Information");
            language.Add("Name", "Name");
            language.Add("Sur", "Surnames");
            language.Add("Age", "Age");
            language.Add("Obs", "Observations");
            language.Add("Aller", "Ajlergies");
            language.Add("Birt", "Birthday");
            language.Add("Depo", "Depositions");
            language.Add("Sex", "Sex");
            language.Add("Cod", "Cod");
            language.Add("MesH", "Message for home");
            language.Add("MesS", "Message for school");
            language.Add("Sleep", "Sleep");
            language.Add("Since", "Since");
            language.Add("Until", "Until");
            language.Add("Morn", "Morning");
            language.Add("Aft", "Afternoon");
            language.Add("Good", "Good");
            language.Add("Bad", "Bad");
            language.Add("All", "All");
            language.Add("Half", "Half");
            language.Add("Little", "Little");
            language.Add("IEBr", "I have eaten Breakfast");
            language.Add("IELu", "I have eaten Lunch");
            language.Add("IESn", "I have eaten Snack");
            language.Add("AddC", "Add Child");
            language.Add("EditC", "Edit Child");
            language.Add("DelC", "Delete Child");
            language.Add("ShowC", "Show Child Information ");
            language.Add("Diet", "Diet");
            language.Add("DietA", "Diet with allergies");
            language.Add("TotC", "Total Children");
            language.Add("TotW", "Total Women");
            language.Add("TotM", "Total Men");
            language.Add("Refr", "Refresh");
            language.Add("WFail", "Warning, fail ocurred");
            language.Add("WFilesWhite", "Warning, the fields: Name, " +
                "Last Name and Sex can not be white");
            language.Add("WInvDate", "Warning, invalid date");
            language.Add("WInvSex", "Warning, invaid sex");
            language.Add("Only1Ch",
                "You only can select one child at the same time");
            language.Add("NotSelc", "You have not selected any children");
            language.Add("Delt?", "Are you sure you want to delete?");
            language.Add("Chan", "Change");
            language.Add("Dish", "Dish");
            language.Add("FoodS", "Foodstuff");
            language.Add("Bre", "Breakfast");
            language.Add("Lunch", "Lunch");
            language.Add("Snack", "Snack");

            childList = new ChildList(language);
            childList.Activate();
            childList.Show();
        }

        private void btCastellano_Click(object sender, EventArgs e)
        {
            language.Add("Info", "Informacion");
            language.Add("Name", "Nombre");
            language.Add("Sur", "Apellidos");
            language.Add("Age", "Edad");
            language.Add("Obs", "Observaciones");
            language.Add("Aller", "Alergias");
            language.Add("Birt", "Dia de nacimiento");
            language.Add("Depo", "Deposiciones");
            language.Add("Sex", "Sexo");
            language.Add("Cod", "Codigo");
            language.Add("MesH", "Mensage para casa");
            language.Add("MesS", "Mensage para la escuela");
            language.Add("Sleep", "Dormir");
            language.Add("Since", "Desde");
            language.Add("Until", "Hasta");
            language.Add("Morn", "Manyana");
            language.Add("Aft", "Tarde");
            language.Add("Good", "Bien");
            language.Add("Bad", "Mal");
            language.Add("All", "Todo");
            language.Add("Half", "Mitad");
            language.Add("Little", "Poco");
            language.Add("IEBr", "He desayunado");
            language.Add("IELu", "He comido");
            language.Add("IESn", "He merendado");
            language.Add("AddC", "Anyadir Ninyo");
            language.Add("EditC", "Editar Ninyo");
            language.Add("DelC", "Borrar Ninyo");
            language.Add("ShowC", "Ver Informacion del Ninyo");
            language.Add("Diet", "Dieta");
            language.Add("DietA", "Dieta con allergias");
            language.Add("TotC", "Alumnos totales");
            language.Add("TotW", "Ninyas totales");
            language.Add("TotM", "Ninyos totales");
            language.Add("Refr", "Actualizar");
            language.Add("WFail", "Alerta, ha ocurrido un " +
                "fallo");
            language.Add("WFilesWhite", "Alerta, los campos: " +
                "Nombre, Apellidos y Sexo" +" no pueden estar vacios");
            language.Add("WInvDate", "Alerta, fecha incorrecta");
            language.Add("WInvSex", "Alerta, sexo incorrecto");
            language.Add("Only1Ch",
                "Solo se puede seleccionar un ninyo al mismo tiempo");
            language.Add("NotSelc","No ha seleccionado ningun ninyo");
            language.Add("Delt?","Estas seguro de que quieres borrar?");
            language.Add("Chan", "Cambiar");
            language.Add("Dish", "Plato");
            language.Add("FoodS", "Ingredientes");
            language.Add("Bre", "Desayuno");
            language.Add("Lunch", "Comida");
            language.Add("Snack", "Merienda");

            childList = new ChildList(language);
            childList.Show();
        }
    }
}
