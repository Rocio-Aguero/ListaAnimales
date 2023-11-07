using LISTA.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Lista3
{
    public partial class Form1 : Form
    {
        List<Classlista2> MiLista = new List<Classlista2>();
        public Form1()
        {
            InitializeComponent();

            //para desactivar por el momento boton consulta y eliminar//
            tslConsultar.Enabled = false;
            tslEliminar.Enabled = false;

            // Registrar manejadores de eventos
            btnGuardar.Click += btnGuardar_Click;
            btnCargar.Click += btnCargar_Click;
        }


        private void GuardarDatosEnXML(string archivo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Classlista2>));
                    serializer.Serialize(sw, MiLista);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos en XML: " + ex.Message);
            }
        }

        private void CargarDatosDesdeXML(string archivo)
        {
            try
            {
                if (File.Exists(archivo))
                {
                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Classlista2>));
                        MiLista = (List<Classlista2>)serializer.Deserialize(sr);
                        dgvDatos.DataSource = null;
                        dgvDatos.DataSource = MiLista;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos desde XML: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosDesdeXML("datos.xml");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarDatosEnXML("datos.xml");
        }


        private void tslRegistrar_Click_1(object sender, EventArgs e)
        {
            if (validarnombre() == false)
            { return; }
            if (valdarraza() == false)
            { return; }
            if (valdaeedad() == false)
            { return; }


            //que te de error si ya existe este nombre y la mascota//
            if (existe(txtboxNombre.Text))
            {
                erpError.SetError(txtboxNombre, "esenombre desta mascota ya esta registrada");
                txtboxNombre.Focus();
                return;
            }
            erpError.SetError(txtboxNombre, "");

            //objeto clase lista //
            Classlista2 Mimascota = new Classlista2();
            Mimascota.Nombre = txtboxNombre.Text;
            Mimascota.Raza = cmbRaza.SelectedIndex.ToString();
            Mimascota.Edad = int.Parse(txtboxEdad.Text);
            //hacemos que adicione en mi lista el objeto mi mascota//
            MiLista.Add(Mimascota);
            //esta informacion va a aparecer en el datagriviw//
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            Limpiarcontroles();
            txtboxNombre.Focus();
            //cuando ingrese los datos, se va activar el obj eliminar y consultar//
            tslConsultar.Enabled = true;
            tslEliminar.Enabled = true;



        }
        //metodo existe//
        private bool existe(string Nombre)
        {
            foreach (Classlista2 mimascota in MiLista)
                if (mimascota.Nombre == Nombre)
                {
                    return true;
                }
            return false;
        }

        //validar edad//
        private bool valdaeedad()
        {
            if (string.IsNullOrEmpty(txtboxEdad.Text))
            {
                erpError.SetError(txtboxEdad, "debe ingresar un numero");
                return false;

            }
            else
            {
                erpError.SetError(txtboxEdad, "");
                return true;
            }
        }

        //validar raza//
        private bool valdarraza()
        {
            if (string.IsNullOrEmpty(cmbRaza.Text))
            {
                erpError.SetError(cmbRaza, "debe seleccionar una raza");
                return false;


            }
            else
            {
                erpError.SetError(cmbRaza, "");
                return true;
            }
        }


        // validar nombre //
        private bool validarnombre()
        {
            if (string.IsNullOrEmpty(txtboxNombre.Text))
            {
                erpError.SetError(txtboxNombre, "debe ingresar un nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtboxNombre, "");
                return true;
            }



        }

        //Metodo para limpiar los controles//
        private void Limpiarcontroles()
        {
            txtboxNombre.Clear();
            txtboxEdad.Clear();
            cmbRaza.SelectedIndex = 0;
        }

        //SALIDA//
        private void tlsSALIR_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //CONSULTAS//
        private void tslConsultar_Click_1(object sender, EventArgs e)
        {
            if (validarnombre() == false)
            {
                return;
            }
            Classlista2 mimascota = getmascota(txtboxNombre.Text);
            if (mimascota == null)
            {
                erpError.SetError(txtboxNombre, "mascota no registrada en la lista");
                Limpiarcontroles();
                txtboxNombre.Focus();
                return;
            }
            else
            {
                erpError.SetError(txtboxNombre, "");
                txtboxNombre.Text = mimascota.Nombre;
                cmbRaza.SelectedItem = mimascota.Raza;
                txtboxEdad.Text = mimascota.Edad.ToString();
                //despues de los 3 items escritos arriba , activa el boton eliminar//
                tslEliminar.Enabled = true;

            }
        }
        //consultar mascota//
        private Classlista2 getmascota(string nombre)
        {
            return MiLista.Find(mascota => mascota.Nombre.Contains(nombre));
        }

        //BOTON ELIMINAR//
        private void tslEliminar_Click_1(object sender, EventArgs e)
        {
            //confirmar si quieres o no eliminarlo//
            if (txtboxNombre.Text == "")
            {
                erpError.SetError(txtboxNombre, "consulta mascota para borrar");
                Limpiarcontroles();
                txtboxNombre.Focus();
                tslEliminar.Enabled = false;
                return;
            }
            else
            {
                erpError.SetError(txtboxNombre, "");
                DialogResult respuesta = MessageBox.Show("estas seguro que quieres eliminarlo?", "confirmacion"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.Yes)
                {
                    foreach (Classlista2 mimascota in MiLista)
                    {
                        if (mimascota.Nombre == txtboxNombre.Text)
                        {
                            MiLista.Remove(mimascota);
                            break;
                        }

                        Limpiarcontroles();

                        dgvDatos.DataSource = null;
                        dgvDatos.DataSource = MiLista;


                    }

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatosEnXML("datos.xml");
            MessageBox.Show("Datos guardados en XML.");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosDesdeXML("datos.xml");
            MessageBox.Show("Datos cargados desde XML.");
        }

       
    }
}


