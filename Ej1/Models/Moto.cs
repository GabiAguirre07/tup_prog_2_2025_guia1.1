using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Moto
    {
        public string Marca { get; }
        public int Modelo { get; }  
        public double ValorFabricacion { get; }
        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }
        public double CalcularDepreciacionLineal(int anioACalcular,int VidaUtil)
        {
            double anioDeUso = anioACalcular - Modelo;
            double valor = ValorFabricacion - (ValorFabricacion * (anioDeUso / VidaUtil));
            return Math.Max(0, valor);


        }
        public double CalcularDepreciacionAnual(int anioACalcular, double TasaDepreciacion)
        {
            return ValorFabricacion * Math.Pow((1 - TasaDepreciacion), (anioACalcular - Modelo));
        }
        public string VerDescripcion()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Valor de Fabricación: {ValorFabricacion:F2}";
        }
    }
}
