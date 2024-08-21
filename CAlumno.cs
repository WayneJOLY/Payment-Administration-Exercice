using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_payment_Administration
{
    public class CAlumno
    {
        private string nombre,apellido;
        private float beca;
        private uint legajo;
        public static float cuota;

        public CAlumno(string nombre, string apellido, float beca, uint legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.beca = beca;
            this.legajo = legajo;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public void setBeca(float beca) {  this.beca = beca; }
        public void setLegajo(uint legajo) { this.legajo = legajo;}


        public string getNombre() { return this.nombre; }
        public string getApellido() {  return this.apellido; }
        public float getBeca() { return this.beca; }
        public uint getLegajo() {  return this.legajo; }


        public float DarImporteMensual()
        {
            return cuota -(cuota * (beca / 100));
        }

        public override string ToString()
        {
            string datos = "";
            datos += "\n Nombre :" + this.nombre + "\nApellido :" + this.apellido.ToUpper() + "\nLegajo :" +this.legajo.ToString() +"\nIMPORTE MENSUAL :" + DarImporteMensual();

            return datos;
        }

    }
}
