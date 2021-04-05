using Salario_Empleados.clases;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Salario_Empleados
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            visivilidad(false);
            btnRegistros.Visible = false;
            if (File.Exists(ruta)) btnRegistros.Visible = true;
        }
        string marcadeaguanombre = "Ingresa tu nombre";
        string marcadeaguaidenficicacion = "Ingresa tu cédula";
        string marcadeaguaventas = "Total en ventas";
        string ruta = @"C:\Users\Danis\Documents\Abbey_Company\DesarrollosC#\Salario_Empleados\Salario_Empleados\datos\Datos_Empleados.txt";
        string[] cargos = new string[] { "Administrativo", "Vendedor", "Mecánico", "Servicios varios" };
        string genero;
        bool Calcular = false;
        bool Guardar = false;
        bool nuevo = false;
        string[] todalainfodeusuario;
        void accionregistros(bool estado)
        {
            pnRegistros.Visible = estado;
            visivilidad(!estado);
            imgcargo.Visible = !estado;
            empleado.Visible = !estado;
        }
        void lector()
        {
            string[] lineas = File.ReadAllLines(ruta);
            foreach (var item in lineas)
            {
                ListViewItem elementos = new ListViewItem(item.ToString().Split(','));
                
                listaRegistros.Items.Add(elementos); 
            }
        }
        void AccionGuardar(string[] datos)
        {
            string datocompleto = "";
            for (int i = 0; i <= datos.Length-1; i++)
            {
                if(i == datos.Length - 1)
                {
                    datocompleto += $"{datos[i]}";
                }
                else
                {
                    datocompleto += $"{datos[i]},";
                }
            }
            File.AppendAllText(ruta, $"{datocompleto}\n");
        }
        void visivilidad(bool estado)
        {
            btnGuardar.Visible = estado;
            infoSueldoBase.Visible = estado;
            impSaldoBase.Visible = estado;
            infoValorcomisiones.Visible = estado;
            impcomisiones.Text = "";
            InfoValorBeneficios.Visible = estado;
            impValorbeneficios.Visible = estado;
            infoSubsidiodetransporte.Visible = estado;
            impSubsidiodetransporte.Visible = estado;
            infoHorasExtras.Visible = estado;
            impHorasExtras.Visible = estado;
            infoSeguridadsocial.Visible = estado;
            impSeguridadsocial.Visible = estado;
            infoValortotaldevengado.Visible = estado;
            impValortotaldevengado.Visible = estado;
        }
        bool solotexto(string texto)
        {
            /*Esta funcion se encarga de determinar si un string contiene el siguiente tipo de caracteres
             "qwertyuiopñlkjhgfdsazxcvbnmQWERTYUIOPÑLKJHGFDSAZXCVBNMáéíóúëöäüïÍÏ" Esto lo hago para asegurarme
             de que los datos ingresados solo sean letras y no numeros*/
            bool repuesta = true;
            foreach (var cp in texto.Replace(" ", "").ToLower()) if (!((byte)cp > 96 & (byte)cp < 123 | (byte)cp < 247 & (byte)cp > 223 | (byte)cp < 253 & (byte)cp > 248)) repuesta = false;
            return repuesta;
        }

        //Para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //TODO Funcion para evaluar si el valor ingresado es númerico
        bool solonumeros(string texto)
        {
            /*Esta funcion se encarga de definir si el texto ingresado es un entero o no*/
            int numero;
            bool respuesta = false;
            if (int.TryParse(texto.Replace(" ", "").Replace(".", "").Replace(",", ""), out numero)) respuesta = true;
            return respuesta;
        }
        bool solonumero(string texto)
        {
            /*Esta funcion se encarga de definir si el texto ingresado es un entero o no*/
            double numero;
            bool respuesta = false;
            if (double.TryParse(texto.Replace(" ", "").Replace(".", "").Replace(",", ""), out numero)) respuesta = true;
            return respuesta;
        }
        void habilidator(bool estado)
        {
            lineaNombre.BackColor = Color.FromArgb(242, 242, 242);
            lineaIdentificacion.BackColor = Color.FromArgb(242, 242, 242);
            lineaValor.BackColor = Color.FromArgb(242, 242, 242);
            labelGenero.BackColor = Color.White;
            grupoEfectividad.Enabled = estado;
            grupoInfoempresarial.Enabled = estado;
            grupoInfoPersonal.Enabled = estado;
        }
        void carga()
        {
            //pnRegistros.Visible = false;
            fechaingresoempleado.MaxDate = DateTime.Now;
            txtNombre.Text = marcadeaguanombre;
            txtNombre.ForeColor = Color.Gray;
            txtIdentidficacion.Text = marcadeaguaidenficicacion;
            txtIdentidficacion.ForeColor = Color.Gray;
            txtventastotal.Text = marcadeaguaventas;
            txtventastotal.ForeColor = Color.Gray;
            listcomboboxcargosempleados.DataSource = cargos;
            horastrabajadasporsemana.Text = medidonumerohoras.Value.ToString();
            listcomboboxcargosempleados.SelectedIndex = 1;
            barraSuperior.Select();
        }
        //TODO Funciones genericas
        private void General_Load(object sender, System.EventArgs e)
        {
            carga();
        }
        //TODO Funciones de el input de nombre
        private void txtNombre_Leave(object sender, System.EventArgs e)
        {
            lineaNombre.BackColor = Color.Gray;
            if (txtNombre.Text == "") txtNombre.Text = marcadeaguanombre;
        }

        private void txtNombre_Enter(object sender, System.EventArgs e)
        {
            lineaNombre.BackColor = Color.Green;
            if (txtNombre.Text == marcadeaguanombre || txtNombre.Text == "") txtNombre.Text = "";
        }
        //TODO Funciones del input de Identificación
        private void txtIdentidficacion_Leave(object sender, System.EventArgs e)
        {
            lineaIdentificacion.BackColor = Color.Gray;
            if (txtIdentidficacion.Text == "") txtIdentidficacion.Text = marcadeaguaidenficicacion;
        }

        private void txtIdentidficacion_Enter(object sender, System.EventArgs e)
        {
            lineaIdentificacion.BackColor = Color.Green;
            if (txtIdentidficacion.Text == marcadeaguaidenficicacion || txtIdentidficacion.Text == "") txtIdentidficacion.Text = "";
        }
        //TODO Funciones de la barra de horas
        private void medidonumerohoras_Scroll(object sender, System.EventArgs e)
        {
            horastrabajadasporsemana.Text = medidonumerohoras.Value.ToString();
        }
        //TODO Funciones del input de vendedor
        private void ventastotal_Leave(object sender, System.EventArgs e)
        {
            lineaValor.BackColor = Color.Gray;
            if (txtventastotal.Text == "") txtventastotal.Text = marcadeaguaventas;
        }

        private void txtventastotal_Enter(object sender, System.EventArgs e)
        {
            lineaValor.BackColor = Color.Green;
            if (txtventastotal.Text == marcadeaguaventas || txtventastotal.Text == "") txtventastotal.Text = "";
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            if (!solotexto(txtNombre.Text) || txtNombre.Text == marcadeaguanombre || !solonumeros(txtIdentidficacion.Text) || txtIdentidficacion.Text == marcadeaguaidenficicacion || (!solonumero(txtventastotal.Text) && txtventastotal.Visible == true || (txtventastotal.Text == marcadeaguaventas && txtventastotal.Visible == true)) || !radioFemenino.Checked && !radioMasculino.Checked)
            {
                if (!solotexto(txtNombre.Text) || txtNombre.Text == marcadeaguanombre)
                {
                    msnError.Visible = true;
                    lineaNombre.BackColor = Color.Red;

                }
                if (!solonumeros(txtIdentidficacion.Text) || txtIdentidficacion.Text == marcadeaguaidenficicacion)
                {
                    msnError.Visible = true;
                    lineaIdentificacion.BackColor = Color.Red;
                }
                if (!solonumero(txtventastotal.Text))
                {
                    msnError.Visible = true;
                    lineaValor.BackColor = Color.Red;
                }
                if (!radioFemenino.Checked || !radioMasculino.Checked)
                {
                    if (!radioFemenino.Checked && !radioMasculino.Checked)
                        labelGenero.BackColor = Color.Red;
                    else labelGenero.BackColor = Color.White;
                }

            }
            else
            {
                if (Calcular == false)
                {
                    Guardar = true;
                    Calcular = true;
                    imgcargo.Visible = true;
                    pnRegistros.Visible = false;
                    visivilidad(true);
                    genero = (radioFemenino.Checked) ? "Femenino" : "Masculino";
                    Persona Empleado = new Persona(txtNombre.Text, txtIdentidficacion.Text, genero, medidonumerohoras.Value, Convert.ToString(listcomboboxcargosempleados.SelectedItem), fechaingresoempleado.Value, txtventastotal.Text);
                    empleado.Text = Empleado.Nombre;
                    impSaldoBase.Text = Empleado.SueldoBase();
                    impcomisiones.Text = (Empleado.Valorcomisiones == 0) ? "0" : Empleado.Valorcomisiones.ToString("#,#", CultureInfo.InvariantCulture);
                    impValorbeneficios.Text = (Empleado.Beneficios == 0) ? "0" : Empleado.Beneficios.ToString("#,#", CultureInfo.InvariantCulture);
                    impSubsidiodetransporte.Text = (Empleado.Subsidiodetransporte == 0) ? "0" : Empleado.Subsidiodetransporte.ToString("#,#", CultureInfo.InvariantCulture);
                    impHorasExtras.Text = (Empleado.Valorhorasextras == 0) ? "0" : Empleado.Valorhorasextras.ToString("#,#", CultureInfo.InvariantCulture);
                    impSeguridadsocial.Text = (Empleado.Seguridadsocial == 0) ? "0" : "- " + Empleado.Seguridadsocial.ToString("#,#", CultureInfo.InvariantCulture);
                    impValortotaldevengado.Text = (Empleado.Valortotaldevengado == 0) ? "0" : Empleado.Valortotaldevengado.ToString("#,#", CultureInfo.InvariantCulture);
                    msnError.Visible = false;
                    todalainfodeusuario = new string[] { Empleado.Nombre, Empleado.Cedula, Empleado.Sexo, Empleado.Fechaingresoempleado.ToString().Split(' ')[0], Empleado.Cargo };
                    habilidator(false);
                    btnGuardar.Visible = true;
                    nuevo = false;
                    if (File.Exists(ruta)) btnRegistros.Visible = true;
                }
            }
        }

        private void listcomboboxcargosempleados_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            if (listcomboboxcargosempleados.SelectedItem.ToString() == "Vendedor")
            {
                txtventastotal.Visible = true;
                lineaValor.Visible = true;
                imgDinero.Visible = true;
            }
            else
            {
                txtventastotal.Visible = false;
                lineaValor.Visible = false;
                imgDinero.Visible = false;
            }
            switch (listcomboboxcargosempleados.SelectedItem.ToString())
            {
                case "Administrativo":
                    infoValorcomisiones.Text = "-----------------------------------------";
                    impcomisiones.Visible = false;
                    imgcargo.Image = Salario_Empleados.Properties.Resources.admin;
                    break;
                case "Vendedor":
                    impcomisiones.Visible = true;
                    infoValorcomisiones.Text = "Valor de comisiones :        $";
                    imgcargo.Image = Salario_Empleados.Properties.Resources.admin2;
                    txtventastotal.Visible = true;
                    break;
                case "Mecánico":
                    infoValorcomisiones.Text = "-----------------------------------------";
                    impcomisiones.Visible = false;
                    imgcargo.Image = Salario_Empleados.Properties.Resources.admin3;
                    break;
                case "Servicios varios":
                    infoValorcomisiones.Text = "-----------------------------------------";
                    impcomisiones.Visible = false;
                    imgcargo.Image = Salario_Empleados.Properties.Resources.admin3;
                    break;
                default:
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            visivilidad(false);
            habilidator(true);
            Calcular = false;
            btnGuardar.Visible = false;
            msnError.Visible = false;
            carga();
            Guardar = false;
        }

        private void barraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar)
            {
                Guardar = false;
                btnGuardar.Visible = false;
                AccionGuardar(todalainfodeusuario);
                btnRegistros.Visible = true;
            }
        }

        private void btncerrarRegistros_Click(object sender, EventArgs e)
        {
            accionregistros(false);
            if (Guardar == false)
            {
                btnGuardar.Visible = false;
                visivilidad(false);
            }
            btnRegistros.Visible = true;
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
                barraInferior.Select();
                btnRegistros.Visible = false;
                imgcargo.Visible = false;
                empleado.Visible = false;
                listaRegistros.Items.Clear();
                lector();
                pnRegistros.Visible = true;
                visivilidad(false);
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            creditos credito = new creditos();
            credito.Show();
        }

        private void barraMedia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barraInferior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnRegistros_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
