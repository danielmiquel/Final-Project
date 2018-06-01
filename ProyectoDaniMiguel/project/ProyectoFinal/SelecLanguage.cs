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
    public partial class SelectLenguage : Form
    {
        public Dictionary<string, string> language;

        public SelectLenguage()
        {
            InitializeComponent();
        }

        private void btEnglish_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> l =
                new Dictionary<string, string>();

            l.Add("Info", "Information");
            l.Add("Name", "Name");
            l.Add("Sur", "Surnames");
            l.Add("Age", "Age");
            l.Add("Obs", "Observations");
            l.Add("Aller", "Allergies");
            l.Add("Birt", "Birthday");
            l.Add("Depo", "Depositions");
            l.Add("Sex", "Sex");
            l.Add("Cod", "Cod");
            l.Add("MesH", "Message for home");
            l.Add("MesS", "Message for school");
            l.Add("Sleep", "Sleep");
            l.Add("Since", "Since");
            l.Add("Until", "Until");
            l.Add("Morn", "Morning");
            l.Add("Aft", "Afternoon");
            l.Add("Good", "Good");
            l.Add("Bad", "Bad");
            l.Add("All", "All");
            l.Add("Half", "Half");
            l.Add("Little", "Little");
            l.Add("IEBr", "I have eaten Breakfast");
            l.Add("IELu", "I have eaten Lunch");
            l.Add("IESn", "I have eaten Snack");
            l.Add("AddC", "Add Child");
            l.Add("EditC", "Edit Child");
            l.Add("DelC", "Delete Child");
            l.Add("ShowC", "Show Child Information ");
            l.Add("Diet", "Diet");
            l.Add("DietA", "Diet with allergies");
            l.Add("TotC", "Total Children");
            l.Add("TotW", "Total Women");
            l.Add("TotM", "Total Men");
            l.Add("Refr", "Refresh");
            l.Add("WFail", "Warning, fail ocurred");
            l.Add("WFilesWhite", "Warning, the fields: Name, " +
                "Last Name and Sex can not be white");
            l.Add("WInvDate", "Warning, invalid date");
            l.Add("WInvSex", "Warning, invaid sex");
            l.Add("Only1Ch",
                "You only can select one child at the same time");
            l.Add("NotSelc", "You have not selected any children");
            l.Add("Delt?", "Are you sure you want to delete?");
            l.Add("Chan", "Change");
            l.Add("Dish", "Dish");
            l.Add("FoodS", "Foodstuff");
            l.Add("Bre", "Breakfast");
            l.Add("Lunch", "Lunch");
            l.Add("Snack", "Snack");
            l.Add("Eru", "Delete");
            l.Add("W", "Warning");
            l.Add("Print1", "To Print Day");
            l.Add("PrintAll", "To Print Days");
            l.Add("Y", "Yes");
            l.Add("None", "Not information");
            l.Add("Suc", "Successfully saved");

            language = l;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCastellano_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> l =
                new Dictionary<string, string>();

            l.Add("Info", "Informacion");
            l.Add("Name", "Nombre");
            l.Add("Sur", "Apellidos");
            l.Add("Age", "Edad");
            l.Add("Obs", "Observaciones");
            l.Add("Aller", "Alergias");
            l.Add("Birt", "Dia de nacimiento");
            l.Add("Depo", "Deposiciones");
            l.Add("Sex", "Sexo");
            l.Add("Cod", "Codigo");
            l.Add("MesH", "Mensage para casa");
            l.Add("MesS", "Mensage para la escuela");
            l.Add("Sleep", "Dormir");
            l.Add("Since", "Desde");
            l.Add("Until", "Hasta");
            l.Add("Morn", "Mañana");
            l.Add("Aft", "Tarde");
            l.Add("Good", "Bien");
            l.Add("Bad", "Mal");
            l.Add("All", "Todo");
            l.Add("Half", "Mitad");
            l.Add("Little", "Poco");
            l.Add("IEBr", "He desayunado");
            l.Add("IELu", "He comido");
            l.Add("IESn", "He merendado");
            l.Add("AddC", "Añadir Niño");
            l.Add("EditC", "Editar Niño");
            l.Add("DelC", "Borrar Niño");
            l.Add("ShowC", "Ver Informacion del Niño");
            l.Add("Diet", "Dieta");
            l.Add("DietA", "Dieta con allergias");
            l.Add("TotC", "Alumnos totales");
            l.Add("TotW", "Niñas totales");
            l.Add("TotM", "Niños totales");
            l.Add("Refr", "Actualizar");
            l.Add("WFail", "Alerta, ha ocurrido un fallo");
            l.Add("WFilesWhite", "Alerta, los campos: " +
                "Nombre, Apellidos y Sexo no pueden estar vacios");
            l.Add("WInvDate", "Alerta, fecha incorrecta");
            l.Add("WInvSex", "Alerta, sexo incorrecto");
            l.Add("Only1Ch",
                "Solo se puede seleccionar un niño al mismo tiempo");
            l.Add("NotSelc","No ha seleccionado ningun niño");
            l.Add("Delt?","Estas seguro de que quieres borrar?");
            l.Add("Chan", "Cambiar");
            l.Add("Dish", "Plato");
            l.Add("FoodS", "Ingredientes");
            l.Add("Bre", "Desayuno");
            l.Add("Lunch", "Comida");
            l.Add("Snack", "Merienda");
            l.Add("Eru", "Borrar");
            l.Add("W", "Alerta");
            l.Add("Y", "Si");
            l.Add("Print1", "Imprimir Dia");
            l.Add("PrintAll", "Imprimir Dias");
            l.Add("None", "Sin información");
            l.Add("Suc", "Guardado con exito");

            language = l;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SelectLenguage_Load(object sender, EventArgs e)
        {

        }
    }
}
