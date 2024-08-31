using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourceDemo
{
    public partial class EjemplosConexiones : Form
    {
        public EjemplosConexiones()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.customersBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void EjemplosConexiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var index = customersBindingSource.Find("customerID", toolStripTextBox1);
                if (index > -1)
                {

                    customersBindingSource.Position = index;
                    return;
                }
                else
                {
                    MessageBox.Show("Elemento no encontrado");
                }
            }
        }
    }
}


//Guias 1 hasta la 5 para este proyecto.