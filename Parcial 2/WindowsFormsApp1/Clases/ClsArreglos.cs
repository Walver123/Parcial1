using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class ClsArreglos
    {
        private int [] Arreglotemporal;
        private int[] Datos;
        
        private int TamanoArreglo = 0;

        public int GetTamanoArreglo()
        {
            return Datos.Length;
        }

        

        public ClsArreglos(int[] ArregloParametro)
        {
            Datos = ArregloParametro;
            TamanoArreglo = Datos.Length;
        }

        public int[] MetodoBurbuja()
        {
            Arreglotemporal = Datos;
            for (i = 0; i < TamanoArreglo - 1; i++ )
            {
                for(j=i+1; j<TamanoArreglo; j++)
                {
                    if(Arreglotemporal[i]> Arreglotemporal[j])
                    {
                        Datotemporal = Arreglotemporal[i];
                        Arreglotemporal[i] = Arreglotemporal[j];
                        Arreglotemporal[j] = Datotemporal;
                    }
                }
            }
            return Arreglotemporal;
        }

   
        private string[] ArregloTemporalNombre;
        private string[] DatosN;
        private string DatosTemporalNombre;
        private int i, j, Datotemporal;

        public ClsArreglos (string[] arreglos)
        {
            DatosN = arreglos;
            TamanoArreglo = DatosN.Length; // cantidad de datos del archivo
        }

        public string[] BurbujaOrdenNombres() //Para hacer el ordenamiento de los nombres haciendo el llamado
        {
            ArregloTemporalNombre = DatosN;

            for (i = 0; i<TamanoArreglo -1; i++)
            {
                for (j = i +1; j < TamanoArreglo; j++ )
                {
                    if (ArregloTemporalNombre[i].CompareTo(ArregloTemporalNombre[j])>0) //Comparar los arreglos por orden de letra A a Z
                    {

                        DatosTemporalNombre = ArregloTemporalNombre[i];
                        ArregloTemporalNombre[i] = ArregloTemporalNombre[j];
                        ArregloTemporalNombre[j] = DatosTemporalNombre;

                    }
                }
            }

            return ArregloTemporalNombre; //regresar funcion hasta que esten ordenados los datos
        }
    }
}







