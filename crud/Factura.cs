using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Factura : Form
    {
        public Factura()
       
        {
            MostrarMediopago();
            InitializeComponent();
        }
        private static Factura instancia = null;
        public static Factura factura_AD_unico()
        {

            if (instancia == null)
            {
                instancia = new Factura();

                return instancia;
            }
            return instancia;
        }

        private conMediopago Mediopago = new conMediopago();
        private string idMediopago = null;
        private bool Editar = false;



        private void MostrarMediopago()
        {
            conMediopago objeto = new conMediopago();
            dataGridView_Factura.DataSource = objeto.MostrarMRod();

        }


       
        private void limpiarForm()
        {
            COS_factura.Clear();
        }
        private void Adicionar_Click_1(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    Mediopago.InsertarMRod(MEP_factura.Text, COS_factura.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarMediopago();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
         
        }
    }
}
