using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP02MVC.Models
{
    public class SugeridorReceta
    {
        public string nombre { get; set; }
        public DateTime fechanacimiento { get; set; }
        public int tipo { get; set; }

        public double presupuesto { get; set; }

        public int cantComensales { get; set; }

        public SugeridorReceta()
        {

        }
        public SugeridorReceta(string nombre, DateTime fechanacimiento, int tipo, double presupuesto, int cantComensales)
        {
            this.nombre = nombre;
            this.fechanacimiento = fechanacimiento;
            this.tipo = tipo;
            this.presupuesto = presupuesto;
            this.cantComensales = cantComensales;
        }
        public int CalcularEdad()
        {
            if (fechanacimiento.Month > DateTime.Today.Month)
            {
                return DateTime.Today.Year - fechanacimiento.Year;
            }
            else { return DateTime.Today.Year - fechanacimiento.Year - 1; }
        }

        public string DeterminarPlato()
        {
            if (tipo == 1)
            {

                if (presupuesto < 3000)
                {
                    return "Fideos con manteca";
                }
                else if (presupuesto >= 3000 && presupuesto <= 7000)
                {
                    return "Arroz con verduras salteadas";
                }
                else
                {
                    return "Pollo al horno con guarnición";
                }


            }
            else
            {
                if (presupuesto < 3000)
                {
                    return "Ensalada simple";
                }
                else if (presupuesto >= 3000 && presupuesto <= 7000)
                {
                    return "Ensalada completa con proteína";
                }
                else
                {
                    return "Tabla de fiambres y quesos";
                }
            }


        }
        public int CalcularTiempo()
        {
            if (tipo == 1)
            {
                if (cantComensales >= 1 && cantComensales <= 3)
                {
                    return 20;
                }
                else if (cantComensales >= 4 || cantComensales <= 7)
                {
                    return 40;
                }
                else
                {
                    return 80;
                }
            }
            else
            {
                if (cantComensales >= 1 && cantComensales <= 3)
                {
                    return 10;
                }
                else if (cantComensales >= 4 || cantComensales <= 7)
                {
                    return 20;
                }
                else
                {
                    return 40;
                }
            }
        }
        public string DeterminarDificultad()
        {

            if (presupuesto < 3000)
            {
                if (cantComensales >= 1 && cantComensales <= 3)
                {
                    return "Principiante";
                }
                else if (cantComensales >= 4 && cantComensales <= 7)
                {
                    return "Intermedio";
                }
                else
                {
                    return "Avanzado";
                }
            }
            else if (presupuesto >= 3000 && presupuesto <= 7000)
            {
                if (cantComensales >= 1 && cantComensales <= 7)
                {
                    return "Intermedio";
                }
                else
                {
                    return "Avanzado";
                }
            }
            else
            {
                if (cantComensales >= 1 && cantComensales <= 7)
                {
                    return "Intermedio";
                }
                else
                {
                    return "Avanzado";
                }
            }
        }
    }
}