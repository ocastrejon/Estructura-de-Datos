using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Ordenado_con_Listas_Enlazadas
{
    class Inventario
    {
        //Agregar get y set a propiedades
        public Producto inicio { get; set; }
        Producto temp;

        //Agregar que imprima la lista invertida

        public void Agregar(Producto nuevo)
        {
            //Falta que se guarden por orden x
            if (inicio == null)
                inicio = nuevo;
            else if(nuevo.codigo < inicio.codigo)
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
                //temp = inicio;
                //while (temp.siguiente != null)
                //    temp = temp.siguiente;
                //temp.siguiente = nuevo;
            }
            else
            {
                temp = inicio;
                while (temp.siguiente != null && temp.siguiente.codigo < nuevo.codigo)
                    temp = temp.siguiente;
                nuevo.siguiente = temp.siguiente;
                temp.siguiente = nuevo;
            }
        }

        //Para buscar y borrar acomodar el codigo para que no compare todos los elementos
        public Producto Buscar(int cod)
        {
            Producto x = null;
            Producto b = inicio;

            //if (b != null)
                while (b != null && b.codigo <= cod)
                {
                    if (b.codigo == cod)
                    {
                        x = b;
                        break;
                    }
                    else
                        b = b.siguiente;
                }
            return x;
        }

        public void Borrar(int cod)
        {
                Producto b = inicio;

            //if(b != null)
            while (b != null && b.codigo <= cod)
            {
                if (inicio.codigo == cod)
                {
                    inicio = inicio.siguiente;
                    break;
                }

                if (b.siguiente.codigo == cod)
                {
                    b.siguiente = b.siguiente.siguiente;
                    break;
                }
                else
                    b = b.siguiente;
            }
        }

        public string Reporte()
        {
            string datos = "";
            Producto t = inicio;
            while (t != null)
            {
                datos += t.ToString();
                t = t.siguiente;
            }
            return datos;
        }

        public string ReporteInvertido()
        {
            string datos = "Reporte Vacio";
            Producto temp = inicio;
            if (temp == null)
                return datos;
            else
                return ReporteInvertido(temp);
        }

        private string ReporteInvertido(Producto temp)
        {
            if (temp.siguiente == null)
                return temp.ToString();
            else
            {
                return ReporteInvertido(temp.siguiente) + temp.ToString();
            }
        }
    }
}
