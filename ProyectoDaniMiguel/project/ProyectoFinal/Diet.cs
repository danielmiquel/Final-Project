﻿using System;
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
    public partial class Diet : Form
    {
        public Diet()
        {
            InitializeComponent();
        }

        private void Diet_Load(object sender, EventArgs e)
        {
            ListOfMeals listMeals = new ListOfMeals();

            foreach (string i in listMeals.ListForShow(""))
            {
                lbDiet.Items.Add(i);
            }
        }
        
    }
}
