using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo_Inventario_con_Listas
{
    class Inventario
    {
        public Producto inicio;
        Producto temp;

        public void Agregar(Producto nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                temp = inicio;
                while (temp.siguiente != null)
                    temp = temp.siguiente;
                temp.siguiente = nuevo;
            }
        }

        public Producto Buscar(int cod)
        {
            Producto x = null;
            Producto b = inicio;
            while (b != null)
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
            while (inicio != null)
            {
                if (inicio.codigo == cod)
                {
                    inicio = inicio.siguiente;
                    break;
                }

                Producto b = inicio;
                if (b.siguiente.codigo == cod)
                {
                    b.siguiente = b.siguiente.siguiente;
                    break;
                }
                else
                    b = b.siguiente;
            }
        }

        public void Insertar(Producto pr, int a)
        {

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
    }
}
