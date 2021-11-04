using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BOLTRA_UES.DAL
{
    public class MarcaTabla:BDComun
    {
        string instruccion;
        public DataTable VistaTabla()
        {
            instruccion = "Select * from empresas";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, establecerConxion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;

        }

    }
}
