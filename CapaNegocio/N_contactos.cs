using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class N_contactos
    {
        D_contacto obj = new D_contacto();

        public DataTable N_listado()
        {
            return obj.D_listado();
        }
        public DataTable N_buscar(string barra)
        {
            return obj.D_buscar(barra);
        }
        public  void N_insertar(string nombre, string apellido, string dc, string g, string estado, string tel, string correo, string fecha)
        {
            obj.D_Insertar(nombre, apellido, dc, g, estado, tel, correo, fecha);
        }
        public void N_modificar(string nombre, string apellido, string dc, string g, string estado, string tel, string correo, string fecha, string c)
        {
            obj.D_Modificar(nombre, apellido, dc, g, estado, tel, correo, fecha, c);
        }
        public bool N_validar(string tele)
        {
            bool sd= obj.D_validar(tele);
            return sd;
        }
        public void N_eliminar(string tel)
        {
            obj.D_Eliminar(tel);
        }
    }
}
