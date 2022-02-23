using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MundoAcuario.Datos;

namespace MundoAcuario.Presentacion
{
    public partial class InsertMarino : Form
    {
        public InsertMarino()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            pMarino marino = new pMarino();
            marino.fecha = DateTime.Now;
            marino.calcio = int.Parse(txtca.Text);
            marino.alcalinidad = int.Parse(txtal.Text);
            marino.salinidad = int.Parse(txtsal.Text);
            marino.temperatura = decimal.Parse(txttemp.Text);
            marino.ph = decimal.Parse(txtph.Text);
            marino.magnesio = int.Parse(txtmg.Text);
            marino.fosfato = decimal.Parse(txtfosf.Text);
            marino.amoniaco = decimal.Parse(txtamo.Text);
            marino.potasio = int.Parse(txtpota.Text);
            marino.silicio = decimal.Parse(txtsili.Text);
            marino.nitritos = decimal.Parse(txtnitri.Text);
            marino.nitratos = decimal.Parse(txtnitrat.Text);
            marino.estroncio = int.Parse(txtstron.Text);
            marino.boro = decimal.Parse(txtboro.Text);
            marino.hierro = decimal.Parse(txthierro.Text);



            using (acuarioEntities db = new acuarioEntities())
            {

                db.pMarino.Add(marino);
                db.SaveChanges();
                limpiar();
            }
        }

        private void limpiar()
        {
            txtca.Text = "";
            txtal.Text = "";
            txtsal.Text = "";
            txttemp.Text = "";
            txtph.Text = "";
            txtmg.Text = "";
            txtfosf.Text = "";
            txtamo.Text = "";
            txtpota.Text = "";
            txtsili.Text = "";
            txtnitri.Text = "";
            txtnitrat.Text = "";
            txtstron.Text = "";
            txtboro.Text = "";
            txthierro.Text = "";
        }
    }
}
