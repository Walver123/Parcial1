using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        private string[] ArregloNotas;

        
        public Form1() 
        {
            InitializeComponent();
        }
        // ventana de evento para hacer ordenar los nombre 
        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int contadorNombre = 0;

            string[] nombresArreglo = new string[ArregloNotas.Length -1]; // hara nuevo string para leer el archivo
            string[] nombresArregloS = new string[ArregloNotas.Length - 1];
            foreach( string linea in ArregloNotas)
            {
                if (contadorNombre != 0)// si contador es diferente de 0 continuará ordenandolos
                {
                    string[] datosNombre = linea.Split(';'); // Da saltos en ; para ver que vamos a ordenar
                    nombresArreglo[contadorNombre - 1] = datosNombre[1]; //Si nombresArreglos sigue valiendo mas que contador le restará 1 para ordenarlo
                    nombresArregloS[contadorNombre - 1] = datosNombre[5];
                }

                contadorNombre++; 
            }

            ClsArreglos arregloNombres = new ClsArreglos(nombresArreglo);//para popder usar las funciones que esten en esa clase
            string[] resultados = arregloNombres.BurbujaOrdenNombres();//llama el metodo burbuja para ordenar nombres
           
            ClsArreglos arregloNombresS = new ClsArreglos(nombresArregloS);
            string[] resultado1 = arregloNombresS.BurbujaOrdenNombres();


            for (int indiceNombre = 0 ; indiceNombre < resultados.Length; indiceNombre ++ )//irá de primera a ultima linea para ordenar los nombres
            {
                listBoxOrden.Items.Add($"Nombre: {resultados[indiceNombre]} Sección: {resultado1[indiceNombre]} ");
            }

   
        }
        //no modificar
        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog(); //abrir el archivo plano

            ofd.Title = "Selecciona el archivo plano";
            ofd.InitialDirectory = @"C:\Users\Arana\Desktop\Examen Parcial 2\Parcial 2\WindowsFormsApp1\";//direccion donde esta nuestro archivo
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";//extencion del archivo a abrir
            if (ofd.ShowDialog() == DialogResult.OK) //Opcion a escoger del usuario
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxResultado.Text = resultado; // donde se mostrará nuestro archivo plano

            }
        }

        public int promedio2D(string[,] matriz, int columna)
        {
            int acumulador2d = 0;
            int promedio2D;
            int totalFilas = matriz.GetLength(0);
            //total columnas
            //int totalColumnas = matriz.GetLength(1);

            for (int fila=1; fila< matriz.GetLength(0); fila++)
            {
                acumulador2d = acumulador2d + Convert.ToInt32(matriz[fila, columna]);
            }
            promedio2D = (acumulador2d / (matriz.GetLength(0) -1))-1;
            return promedio2D;
            
        }

        public int promedio2D2(string[,] matriz, int columna)
        {
            int acumulador2d2 = 0;
            int promedio2D2;
            int totalFilas = matriz.GetLength(0);
            //total columnas
            int totalColumnas = matriz.GetLength(1);

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador2d2 = acumulador2d2 + Convert.ToInt32(matriz[fila, columna]);

            }

            promedio2D2 = (acumulador2d2 / (matriz.GetLength(0) - 1)) - 2;
            return promedio2D2;

        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            //variables para sacar promedio
            int contador = 0;
            int promedio, promedio1, promedio2;
            int acumulador, acumulador1, acumulador2;
            acumulador = 0;
            acumulador1 = 0;
            acumulador2 = 0;

                        

            string[,] ArregloDosDimenciones = new string[ArregloNotas.Length,6];

            
            //variables para sacar maximo y minimo de cada parcial
            int[] ordenParcialNota3 = new int[ArregloNotas.Length -1];
            int[] ordenParcialNota2 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota1 = new int[ArregloNotas.Length - 1];

            foreach (string Linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = Linea.Split(';');// da saltos de ; para agarrar datos necesarios
                    
                    
                    listBoxResultado.Items.Add($"{datos[1]}");
                    //convertir a dato entero columa de parciales
                   
                        acumulador = acumulador + Convert.ToInt32(datos[2]);
                        acumulador1 = acumulador1 + Convert.ToInt32(datos[3]);
                        acumulador2 = acumulador2 + Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 3
                        ordenParcialNota3[contador - 1] = Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 2
                        ordenParcialNota2[contador - 1] = Convert.ToInt32(datos[3]);

                        //para ordenar notas parcial 1
                        ordenParcialNota1[contador - 1] = Convert.ToInt32(datos[2]);
                    

                    //Mostrar el arreglo de 2D
                    ArregloDosDimenciones[contador, 0] = datos[0];
                    ArregloDosDimenciones[contador, 1] = datos[1];
                    ArregloDosDimenciones[contador, 2] = datos[2];
                    ArregloDosDimenciones[contador, 3] = datos[3];
                    ArregloDosDimenciones[contador, 4] = datos[4];
                    ArregloDosDimenciones[contador, 5] = datos[5];


                }
               
                contador++;
            }

            //nota mas alta y baja parcial 3
            ClsArreglos fncArreglosN3 = new ClsArreglos(ordenParcialNota3);
            ordenParcialNota3 = fncArreglosN3.MetodoBurbuja();
            int MinN3 = ordenParcialNota3[0];
            int MaxN3 = ordenParcialNota3[ordenParcialNota3.Length - 1];

            //nota mas alta y baja parcial 2
            ClsArreglos fncArreglosNota2 = new ClsArreglos(ordenParcialNota2);
            ordenParcialNota2 = fncArreglosNota2.MetodoBurbuja();
            int MinN2 = ordenParcialNota2[0];
            int MaxN2 = ordenParcialNota2[ordenParcialNota2.Length - 1];

            //nota mas alta y baja parcial 1
            ClsArreglos fncArreglosNota1 = new ClsArreglos(ordenParcialNota1);
            ordenParcialNota1 = fncArreglosNota1.MetodoBurbuja();
            int MinN1 = ordenParcialNota1[0];
             int MaxN1 = ordenParcialNota1[ordenParcialNota1.Length -1];

            ClsArreglos fncN2d1 = new ClsArreglos(ordenParcialNota1);
            ordenParcialNota1 = fncN2d1.MetodoBurbuja();
            promedio = acumulador / ArregloDosDimenciones.Length - 1;
            int promedioMatriz = promedio2D(ArregloDosDimenciones, 2);
            int MinN12d = ordenParcialNota1[0]; 
            int MaxN12d = ordenParcialNota1[ordenParcialNota1.Length - 1];

            ClsArreglos fncN2d2 = new ClsArreglos(ordenParcialNota2);
            ordenParcialNota2 = fncN2d2.MetodoBurbuja();
            promedio = acumulador / ArregloDosDimenciones.Length - 1;
            int promedioMatriz2 = promedio2D2(ArregloDosDimenciones, 3);
            int MinN22d = ordenParcialNota2[0];
            int MaxN22d = ordenParcialNota2[ordenParcialNota2.Length - 1];

            ClsArreglos fncN2d3 = new ClsArreglos(ordenParcialNota3);
            ordenParcialNota3 = fncN2d3.MetodoBurbuja();
            promedio = acumulador / ArregloDosDimenciones.Length - 1;
            int promedioMatriz3 = promedio2D2(ArregloDosDimenciones, 4);
            int MinN32d = ordenParcialNota3[0];
            int MaxN32d = ordenParcialNota3[ordenParcialNota3.Length - 1];
           
            MessageBox.Show($"promedio de 2D P1: {promedioMatriz}.\nMaximoNota: {MaxN12d}.\nMinimoNota:{MinN12d}.\npromedio de 2D P2: {promedioMatriz2}.\nMaximoNota2: {MaxN22d}.\nMinimoNota2:{MinN22d}.\npromedio de 2D P3: {promedioMatriz3}.\nMaximoNota3: {MaxN32d}.\nMinimoNota3:{MinN32d}.");
            
            int Acumulador2D1 = 0;
            int Prom2d1;
            Prom2d1 = Acumulador2D1 / (ArregloDosDimenciones.GetLength(0) - 1);
            int Acumulador2D2 = 0;
            int Prom2d2;
            Prom2d2 = Acumulador2D2 / (ArregloDosDimenciones.GetLength(0) - 1);
            int Acumulador2D3 = 0;
            int Prom2d3;
            Prom2d3 = Acumulador2D3 / (ArregloDosDimenciones.GetLength(0) - 1);
            promedio = acumulador / ArregloNotas.Length - 1;
            promedio1 = acumulador1 / ArregloNotas.Length - 1;
            promedio2 = acumulador2 / ArregloNotas.Length - 1;

            
            int promedo3N = ((acumulador + acumulador1 + acumulador2) / (ArregloNotas.Length - 1));
            MessageBox.Show($"Promedio general 3 Pariales: {promedo3N}");
            //mostrar mensaje cono los promedios de los parciales
            MessageBox.Show($"promedio Parcial1: {promedio}.\nMaximoNota: {MaxN1}.\nMinimoNota:{MinN1}.\nPromedio Parcial2: {promedio1}.\nMaximoNota: {MaxN2}.\nMinimoNota:{MinN2}\nPromedio Parcial3: {promedio2}.\nMaximoNota: {MaxN3}.\nMinimoNota:{MinN3}.");

        }

















        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int promedio, promedio1, promedio2;
            int acumulador, acumulador1, acumulador2;
            acumulador = 0;
            acumulador1 = 0;
            acumulador2 = 0;


            //variables para sacar maximo y minimo de cada parcial
            int[] ordenParcialNota3 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota2 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota1 = new int[ArregloNotas.Length - 1];

            foreach (string Linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = Linea.Split(';');// da saltos de ; para agarrar datos necesarios


                    listBoxResultado.Items.Add($"{datos[1]}");
                   // convertir a dato entero columa de parciales
                    if (datos[5] == "A")
                    {
                        acumulador = acumulador + Convert.ToInt32(datos[2]);
                        acumulador1 = acumulador1 + Convert.ToInt32(datos[3]);
                        acumulador2 = acumulador2 + Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 3
                        ordenParcialNota3[contador - 1] = Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 2
                        ordenParcialNota2[contador - 1] = Convert.ToInt32(datos[3]);

                        //para ordenar notas parcial 1
                        ordenParcialNota1[contador - 1] = Convert.ToInt32(datos[2]);


                    }

                }

                contador++;
            }

            //nota mas alta y baja parcial 3
            ClsArreglos fncArreglosN3 = new ClsArreglos(ordenParcialNota3);
            ordenParcialNota3 = fncArreglosN3.MetodoBurbuja();
            //nota mas alta y baja parcial 2
            ClsArreglos fncArreglosNota2 = new ClsArreglos(ordenParcialNota2);
            ordenParcialNota2 = fncArreglosNota2.MetodoBurbuja();
            //nota mas alta y baja parcial 1
            ClsArreglos fncArreglosNota1 = new ClsArreglos(ordenParcialNota1);
            ordenParcialNota1 = fncArreglosNota1.MetodoBurbuja();
           

            promedio = acumulador / ArregloNotas.Length - 1;
            promedio1 = acumulador1 / ArregloNotas.Length - 1;
            promedio2 = acumulador2 / ArregloNotas.Length - 1;

            int valor = promedio1 + promedio2 + promedio;
            //mostrar mensaje cono los promedios de los parciales
            MessageBox.Show($"promedio Sección A: {valor}.");
           
        }

        private void buttonSeccionB_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int promedio, promedio1, promedio2;
            int acumulador, acumulador1, acumulador2;
            acumulador = 0;
            acumulador1 = 0;
            acumulador2 = 0;


            //variables para sacar maximo y minimo de cada parcial
            int[] ordenParcialNota3 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota2 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota1 = new int[ArregloNotas.Length - 1];

            foreach (string Linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = Linea.Split(';');// da saltos de ; para agarrar datos necesarios


                    listBoxResultado.Items.Add($"{datos[1]}");
                    // convertir a dato entero columa de parciales
                    if (datos[5] == "B")
                    {
                        acumulador = acumulador + Convert.ToInt32(datos[2]);
                        acumulador1 = acumulador1 + Convert.ToInt32(datos[3]);
                        acumulador2 = acumulador2 + Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 3
                        ordenParcialNota3[contador - 1] = Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 2
                        ordenParcialNota2[contador - 1] = Convert.ToInt32(datos[3]);

                        //para ordenar notas parcial 1
                        ordenParcialNota1[contador - 1] = Convert.ToInt32(datos[2]);


                    }

                }

                contador++;
            }

            //nota mas alta y baja parcial 3
            ClsArreglos fncArreglosN3 = new ClsArreglos(ordenParcialNota3);
            ordenParcialNota3 = fncArreglosN3.MetodoBurbuja();
            //nota mas alta y baja parcial 2
            ClsArreglos fncArreglosNota2 = new ClsArreglos(ordenParcialNota2);
            ordenParcialNota2 = fncArreglosNota2.MetodoBurbuja();
            //nota mas alta y baja parcial 1
            ClsArreglos fncArreglosNota1 = new ClsArreglos(ordenParcialNota1);
            ordenParcialNota1 = fncArreglosNota1.MetodoBurbuja();


            promedio = acumulador / ArregloNotas.Length - 1;
            promedio1 = acumulador1 / ArregloNotas.Length - 1;
            promedio2 = acumulador2 / ArregloNotas.Length - 1;

            int valor = promedio1 + promedio2 + promedio;
            //mostrar mensaje cono los promedios de los parciales
            MessageBox.Show($"promedio Sección B: {valor}.");

        }

        private void buttonSeccionC_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int promedio, promedio1, promedio2;
            int acumulador, acumulador1, acumulador2;
            acumulador = 0;
            acumulador1 = 0;
            acumulador2 = 0;


            //variables para sacar maximo y minimo de cada parcial
            int[] ordenParcialNota3 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota2 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota1 = new int[ArregloNotas.Length - 1];

            foreach (string Linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = Linea.Split(';');// da saltos de ; para agarrar datos necesarios


                    listBoxResultado.Items.Add($"{datos[1]}");
                    // convertir a dato entero columa de parciales
                    if (datos[5] == "C")
                    {
                        acumulador = acumulador + Convert.ToInt32(datos[2]);
                        acumulador1 = acumulador1 + Convert.ToInt32(datos[3]);
                        acumulador2 = acumulador2 + Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 3
                        ordenParcialNota3[contador - 1] = Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 2
                        ordenParcialNota2[contador - 1] = Convert.ToInt32(datos[3]);

                        //para ordenar notas parcial 1
                        ordenParcialNota1[contador - 1] = Convert.ToInt32(datos[2]);


                    }

                }

                contador++;
            }

            //nota mas alta y baja parcial 3
            ClsArreglos fncArreglosN3 = new ClsArreglos(ordenParcialNota3);
            ordenParcialNota3 = fncArreglosN3.MetodoBurbuja();
            //nota mas alta y baja parcial 2
            ClsArreglos fncArreglosNota2 = new ClsArreglos(ordenParcialNota2);
            ordenParcialNota2 = fncArreglosNota2.MetodoBurbuja();
            //nota mas alta y baja parcial 1
            ClsArreglos fncArreglosNota1 = new ClsArreglos(ordenParcialNota1);
            ordenParcialNota1 = fncArreglosNota1.MetodoBurbuja();


            promedio = acumulador / ArregloNotas.Length - 1;
            promedio1 = acumulador1 / ArregloNotas.Length - 1;
            promedio2 = acumulador2 / ArregloNotas.Length - 1;

            int valor = promedio1 + promedio2 + promedio;
            //mostrar mensaje cono los promedios de los parciales
            MessageBox.Show($"promedio Sección C: {valor}.");


        }

        private void buttonSeccionD_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int promedio, promedio1, promedio2;
            int acumulador, acumulador1, acumulador2;
            acumulador = 0;
            acumulador1 = 0;
            acumulador2 = 0;


            //variables para sacar maximo y minimo de cada parcial
            int[] ordenParcialNota3 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota2 = new int[ArregloNotas.Length - 1];
            int[] ordenParcialNota1 = new int[ArregloNotas.Length - 1];

            foreach (string Linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = Linea.Split(';');// da saltos de ; para agarrar datos necesarios


                    listBoxResultado.Items.Add($"{datos[1]}");
                    // convertir a dato entero columa de parciales
                    if (datos[5] == "D")
                    {
                        acumulador = acumulador + Convert.ToInt32(datos[2]);
                        acumulador1 = acumulador1 + Convert.ToInt32(datos[3]);
                        acumulador2 = acumulador2 + Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 3
                        ordenParcialNota3[contador - 1] = Convert.ToInt32(datos[4]);

                        //para ordenar notas parcial 2
                        ordenParcialNota2[contador - 1] = Convert.ToInt32(datos[3]);

                        //para ordenar notas parcial 1
                        ordenParcialNota1[contador - 1] = Convert.ToInt32(datos[2]);


                    }

                }

                contador++;
            }

            //nota mas alta y baja parcial 3
            ClsArreglos fncArreglosN3 = new ClsArreglos(ordenParcialNota3);
            ordenParcialNota3 = fncArreglosN3.MetodoBurbuja();
            //nota mas alta y baja parcial 2
            ClsArreglos fncArreglosNota2 = new ClsArreglos(ordenParcialNota2);
            ordenParcialNota2 = fncArreglosNota2.MetodoBurbuja();
            //nota mas alta y baja parcial 1
            ClsArreglos fncArreglosNota1 = new ClsArreglos(ordenParcialNota1);
            ordenParcialNota1 = fncArreglosNota1.MetodoBurbuja();


            promedio = acumulador / ArregloNotas.Length - 1;
            promedio1 = acumulador1 / ArregloNotas.Length - 1;
            promedio2 = acumulador2 / ArregloNotas.Length - 1;

            int valor = promedio1 + promedio2 + promedio;
            //mostrar mensaje cono los promedios de los parciales
            MessageBox.Show($"promedio Sección D: {valor}.");


        }
    }
    
}