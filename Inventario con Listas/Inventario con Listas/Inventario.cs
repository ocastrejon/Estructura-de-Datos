using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_con_Listas
{
    class Inventario
    {
        private Producto[] pro = new Producto[15];
        private int _con;
        public int con { get { return _con; } }

        public Inventario()
        {
            _con = 0;
        }

        public string Agregar(Producto pr)
        {
            if (con < 15)
            {
                if (Buscar(pr.codigo) == null)
                {
                    pro[con] = pr;
                    _con++;
                    return "Guardado";
                }
                else
                {
                    return "Código ya existente";
                }
            }
            return "Lleno";
        }

        public Producto Buscar(int cod)
        {
            Producto x = null;
            for (short i = 0; i < con; i++)
            {
                if (cod == pro[i].codigo)
                {
                    x = pro[i];
                }
            }
            return x;
        }

        public void Borrar(int cod)
        {
            int i = 0;
            for (i = 0; i < _con; i++)
            {
                if (pro[i].codigo == cod)
                {
                    pro[i] = null;
                    break;
                }
            }
            for (i = i + 1; i < _con; i++)
                pro[i - 1] = pro[i];
            pro[_con - 1] = null;
            _con--;
        }

        public string Reporte()
        {
            string x = "";
            for (int i = 0; i < _con; i++)
                x += (i + 1) + ".- " + pro[i].ToString();
            return x;
        }

        public string Insertar(Producto pr, int pos)
        {
            if (con < 15)
            {
                if (Buscar(pr.codigo) == null)
                {
                    Producto p2;
                    p2 = pro[_con - 1];
                    for (int i = _con - 1; i > pos; i--)
                        pro[i] = pro[i - 1];
                    pro[_con] = p2;
                    pro[pos] = pr;
                    _con++;
                    return "Agregado Existosamente.";
                }
                else
                {
                    return "Código ya existente";
                }
            }
            return "Lleno";
        }
    }
}
