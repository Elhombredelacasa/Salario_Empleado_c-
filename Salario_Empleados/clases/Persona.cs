using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Salario_Empleados.clases
{
    internal class Persona
    {
        private string nombre;
        private string cedula;
        private string sexo;
        private string cargo;
        private string ventas;
        private int horaslavoradas;
        private double valorcomisiones = 0;
        private double beneficios = 0;
        private double subsidiodetransporte = 0;
        private double valorhorasextras = 0;
        private double seguridadsocial = 0;
        private double valortotaldevengado = 0;
        private DateTime fechaingresoempleado;
        private readonly Dictionary<string, int> valorHora = new Dictionary<string, int>()
        {{ "Administrativo",30000 },
         { "Vendedor",15000},
         {"Mecánico", 20000 },
         {"Servicios varios",5000 }};
        public Persona(string nombre, string cedula, string sexo, int horaslavoradas, string cargo, DateTime fecha, string ventas)
        {
            
            this.nombre = nombre;
            this.Cedula = cedula;
            this.Sexo = sexo;
            this.horaslavoradas = horaslavoradas;
            this.cargo = cargo;
            fechaingresoempleado = fecha;
            this.ventas = ventas;
        }

        public string Nombre { get => nombre;}
        public double Beneficios { get => beneficios;}
        public double Valorcomisiones { get => valorcomisiones;}
        public double Subsidiodetransporte { get => subsidiodetransporte;}
        public double Valorhorasextras { get => valorhorasextras;}
        public double Seguridadsocial { get => seguridadsocial;}
        public double Valortotaldevengado { get => valortotaldevengado;}
        public string Cedula { get => cedula; set => cedula = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Fechaingresoempleado { get => fechaingresoempleado; set => fechaingresoempleado = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public string SueldoBase()
        {
            double sueldo;
            double subsueldo;
            int horasextras = horaslavoradas - 48;
            switch (cargo)
            {
                case "Administrativo":
                    sueldo = 48 * valorHora[cargo];
                    seguridadsocial = sueldo * 0.08;
                    if (fechaingresoempleado.AddYears(5).AddDays(1) < DateTime.Now)beneficios = sueldo * 0.02;
                    subsueldo = (sueldo-seguridadsocial) + beneficios;
                    valortotaldevengado = subsueldo;
                    return sueldo.ToString("#,#", CultureInfo.InvariantCulture);
                case "Vendedor":
                    sueldo = 48 * valorHora[cargo];
                    seguridadsocial = sueldo * 0.08;
                    valorcomisiones = Convert.ToDouble(ventas) * 0.04;
                    if (fechaingresoempleado.AddYears(5).AddDays(1) < DateTime.Now)beneficios = sueldo * 0.02;
                    subsueldo = (sueldo - seguridadsocial) + beneficios + valorcomisiones;
                    valortotaldevengado = subsueldo;
                    return sueldo.ToString("#,#", CultureInfo.InvariantCulture);
                default:
                    sueldo = (48 * valorHora[cargo]);
                    seguridadsocial = sueldo * 0.08;
                    valorhorasextras = (valorHora[cargo] * 1.50) * horasextras;
                    if (fechaingresoempleado.AddYears(5).AddDays(1) < DateTime.Now)beneficios = sueldo * 0.02;
                    if (cargo == "Servicios varios")subsidiodetransporte = 45000;
                    subsueldo = (sueldo - seguridadsocial)+ beneficios + subsidiodetransporte + valorhorasextras;
                    valortotaldevengado = subsueldo;
                    return sueldo.ToString("#,#", CultureInfo.InvariantCulture);
            }
        }
 
    }
}
