using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_con_Listas
{
    class Inventario
    {
        Producto inicio;
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

        public void Insertar(Producto pr, int pos)
        {


            //if (con < 15)
            //{
            //    if (Buscar(pr.codigo) == null)
            //    {
            //        Producto p2;
            //        p2 = pro[_con - 1];
            //        for (int i = _con - 1; i > pos; i--)
            //            pro[i] = pro[i - 1];
            //        pro[_con] = p2;
            //        pro[pos] = pr;
            //        _con++;
            //        return "Agregado Existosamente.";
            //    }
            //    else
            //    {
            //        return "Código ya existente";
            //    }
            //}
            //return "Lleno";
        }
    }
}
