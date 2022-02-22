using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Horarios.Classes;
using System.IO;
using Microsoft.Win32;

namespace Horarios
{

    public partial class frmConvertirHorario : Form
    {


        public string plantillaOriginal = "";
        public string rutaDestino = "";
        public DataTable tablaDatos = new DataTable();
        public DataView tablaOrdenada = new DataView();
        public frmConvertirHorario()
        {
            InitializeComponent();
        }

        private void btnGenerarHorarios_Click(object sender, EventArgs e)
        {

            if (fbdDestino.ShowDialog() == DialogResult.OK)
            {
                btnGenerarHorarios.Enabled = false;
                btnGenerarHorarios.Text = "Procesando...";
                this.Cursor = Cursors.WaitCursor;
                rutaDestino = fbdDestino.SelectedPath;
                HojaCalculo hojaCalculo = new HojaCalculo();
                hojaCalculo.porcentajeHoraSincrona  = Convert.ToDouble(txtPorcentaje.Text)/100  ;
                DataTable dt = new DataTable();
                dt = hojaCalculo.generarHojasCalculo(ref rutaDestino, ref tablaDatos, dtpInicio.Text, dtpFin.Text, chkBlackboard.Checked);
                dgvHorarios.DataSource = dt;
                this.Cursor = Cursors.Default;
                btnGenerarHorarios.Enabled = true;
                btnGenerarHorarios.Text = "Generar Horarios";
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Senati\HorariosGG_v2");
                key.SetValue("PorcentajeSincrono", txtPorcentaje.Text);
                key.SetValue("HoraPedagogica", txtHP.Text);
                key.SetValue("Bloque", txtBloque.Text);
                key.SetValue("InicioCiclo", dtpInicio.Text);
                key.SetValue("FinCiclo", dtpFin.Text);
               
                if (MessageBox.Show("Se generaron " + dt.Rows.Count + " archivos en la ruta: " + rutaDestino + "\n\n¿Desea abrir la carpeta donde se encuentran los archivos?", "Y listo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("Explorer.exe",rutaDestino );
                }
            }
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {

            if(txtCaracterSeparador.Text == "")
            {
                MessageBox.Show("Debe de ingresar un caracter separador de listas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto Fin;
            }
            if  (txtSeparadorCampos.Text == "")
            {
                MessageBox.Show("Debe de ingresar un separador de campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                goto Fin;
            }
            if (ofdHorario.ShowDialog() == DialogResult.OK)
            {
                lblArchivo.Text = ofdHorario.FileName;
                plantillaOriginal = ofdHorario.FileName;
                //Abrir archivo excel
                //HojaCalculo hojaCalculo = new HojaCalculo();
                //hojaCalculo.abrirPlantillaHorario(plantillaOriginal);
                CargarDatosCSV(plantillaOriginal, Convert.ToChar(txtCaracterSeparador.Text),  txtSeparadorCampos.Text);
            }
        Fin:;
        }

        private void frmConvertirHorario_Load(object sender, EventArgs e)
        {
            try { 
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Senati\HorariosGG_v2");
                if(key!=null)
                { 
                    if(key.GetValue("PorcentajeSincrono") != null) { 
                        txtPorcentaje.Text = key.GetValue("PorcentajeSincrono").ToString();
                        txtHP.Text = key.GetValue("HoraPedagogica").ToString();
                        txtBloque.Text = key.GetValue("Bloque").ToString();
                        dtpInicio.Text = key.GetValue("InicioCiclo").ToString();
                        dtpFin.Text = key.GetValue("FinCiclo").ToString();
                    }
                }
                if (txtPorcentaje.Text == "")
                {
                    txtPorcentaje.Text = "60";
                    txtHP.Text = "45";

                }
                trackPorcentaje.Value = Convert.ToInt32(txtPorcentaje.Text);
                trackHP.Value = Convert.ToInt32(txtHP.Text);
                
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }


        

        private void CargarDatosCSV(string ficheroCSV, char separador, string separadorCampos)
        {
            try
            {
                dgvDatos.DataSource = null;
                dgvDatos.Rows.Clear();
                dgvHorarios.DataSource = null;
                dgvHorarios.Rows.Clear();

                tablaDatos.Clear();
                tablaDatos = new DataTable();
                string[] lineas = File.ReadAllLines(ficheroCSV, Encoding.Latin1);

                if (lineas.Length > 0)
                {
                    string[] etiquetaTitulosFinal;
                    //Leyendo cabeceras
                    string primelaLinea = lineas[0];
                    string[] etiquetaTitulos = primelaLinea.Split(separador);
                    List<string> lista = new List<string>();
                    foreach (string campoActual in etiquetaTitulos)
                    {
                        string valor = campoActual;
                        // Quitamos el posible carácter de inicio y fin de valor
                        if (separadorCampos != "")
                        {
                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }

                        /*Convertir a Tipo Fecha las Columnas de Fecha Inicio y Fin, para un ordenamiento de columnas por fecha*/
                        if (valor == "INICIO" || valor == "FIN")
                        {
                            tablaDatos.Columns.Add(new DataColumn(valor, System.Type.GetType("System.DateTime")));
                        }
                        else
                        {
                            tablaDatos.Columns.Add(new DataColumn(valor));
                        }

                        lista.Add(valor);
                    }
                    etiquetaTitulosFinal = lista.ToArray();

                    //Leyendo Datos
                    int inicioFila = 1;

                    for (int i = inicioFila; i < lineas.Length; i++)
                    {
                        string[] filasDatos = lineas[i].Split(separador);
                        /*Filtramos la data deacuerdo al prefijo del bloque******/
                        if (filasDatos[5].Contains(txtBloque.Text) == false || filasDatos[16] == "")
                        {
                            continue;
                        }
                        /***************************/
                        DataRow dataGridS = tablaDatos.NewRow();
                        int columnIndex = 0;
                        foreach (string campoActual in etiquetaTitulosFinal)
                        {
                            string valor = filasDatos[columnIndex++];

                            // Quitamos el posible carácter de inicio y fin de valor
                            if (separadorCampos != "")
                            {
                                valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                                valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                            }
                            dataGridS[campoActual] = valor;

                        }
                        tablaDatos.Rows.Add(dataGridS);
                    }
                }
                if (tablaDatos.Rows.Count > 0)
                {

                    tablaDatos.DefaultView.Sort = "INSTRUCTOR ASC, INICIO ASC";
                    dgvDatos.DataSource = tablaDatos;

                    tablaOrdenada = new DataView(tablaDatos);
                    tablaOrdenada.Sort = "INSTRUCTOR ASC, INICIO ASC";
                    tablaDatos = tablaOrdenada.ToTable();
                    btnGenerarHorarios.Enabled = true;
                    lblDetalles.Text = tablaDatos.Rows.Count + " Registros encontrados.";
                    dtpInicio.Enabled = true;
                    dtpFin.Enabled = true;
                }
                else
                {
                    btnGenerarHorarios.Enabled = false;
                    lblDetalles.Text = "0  Registros encontrados.";
                    dtpInicio.Enabled = false;
                    dtpFin.Enabled = false;

                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message + "\nCorrija error e intente de nuevo." ,"Error al ejecutar",MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void chkBlackboard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtPorcentaje.Text =(string)trackPorcentaje.Value.ToString();
        }

        private void btnEscogerInstructores_Click(object sender, EventArgs e)
        {
            frmSeleccionarInstructores frm = new frmSeleccionarInstructores();
            frm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void trackHP_Scroll(object sender, EventArgs e)
        {
            txtHP.Text = (string)trackHP.Value.ToString();
        }
    }
}
