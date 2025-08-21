using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Viaje
    {
        public int Transportados { get; }
        public int Asientos { get; }
        public int DemoraenM { get; private set; }
        public int DemoraTotalenM { get; private set; }
        public int Pasajeros { get; private set; }
        public int DemoraTotalenH
        {
            get
            {
                return DemoraTotalenM / 60;
            }
        }
        public int MinDemoraTotal
        {
            get
            {
                return DemoraTotalenM % 60;
            }
        }
        public int HDemora
        {
            get
            {
                return DemoraenM / 60;
            }
        }
                
        public int MinDemora
        {
            get
            {
                return DemoraenM % 60;
            }
        }
        public int CantParadas { get; private set; }
        int hInicio;
        int mInicio;
        int hLlegada;
        int mLlegada;

        public int DuracionViajeenM
        {
            get
            {
                return hLlegada * 60 + mLlegada - (hInicio * 60 + mInicio);
            }
        }
        public int HDuracionViaje {
            get
            {
                return DuracionViajeenM / 60;
            }
        } 
        public int MinDuracionViaje { 
            get
            {
                return DuracionViajeenM % 60;
            }
        } 

        public Viaje(int hInicio, int mInicio, int asientos)
        {
            this.hInicio = hInicio;
            this.mInicio = mInicio;
            this.Asientos = asientos;
        }
        public void RealizarParada(int hLlegadaParada, int mLlegadaParada,int hSalidaParada, int mSalidaParada,int Ascienden,int Descienden)

        {
            DemoraenM = (hSalidaParada * 60 + mSalidaParada) - (hLlegadaParada * 60 + mLlegadaParada);
            CantParadas++;
            Pasajeros += Ascienden + Descienden;
            DemoraTotalenM += DemoraenM;  
        }
        public void FinalizarViaje(int hLlegada, int mLlegada)
        {
            this.hLlegada = hLlegada;
            this.mLlegada = mLlegada;
            
        }

    }
}
