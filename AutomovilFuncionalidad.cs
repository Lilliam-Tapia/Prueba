using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public partial class Automovil
    {

        public Automovil(string marca, string placa, string modelo, string color, double capacidadTanque, double rendimiento)
        {
            this.marca = marca;
            this.placa = placa;
            this.modelo = modelo;
            this.color = color;
            this.capacidadTanque = capacidadTanque;
            this.rendimiento = rendimiento;
        }

        
      
        public void PuedeConducir(int distancia)
        {
            NivelCombustible = 0;

            double combustibleNece = distancia / rendimiento;
            NivelCombustible -= combustibleNece;

            if (combustibleNece <= NivelCombustible)
            {
                Console.WriteLine("Viaje completo.");
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para completar el viaje.");
            }
        }
        public void ReabastecerCombustible(double cantidad)
        { 
            double NiveCa = NivelCombustible + cantidad;
            
            if(NiveCa > capacidadTanque)
            {
                Console.WriteLine("No puede exceder la capacidad del tanque.");
            }
            else
            {
                Console.WriteLine("Combustible en el tanque suficiente.");
            }
        }

        public void Conducir(int distancia)
        {
           PuedeConducir(distancia);
           
        }
    }
}










