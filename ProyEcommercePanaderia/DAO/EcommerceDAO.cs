using ProyEcommercePanaderia.Models;

namespace ProyEcommercePanaderia.DAO
{
    public class EcommerceDAO
    {
        private string cad_cn;
        public EcommerceDAO(IConfiguration cfg)
        {
            cad_cn = cfg.GetConnectionString("cn1");
        }

        public List<Productos> GetProductos()
        { 
            var lista = new List<Productos>();
            //
            var dr = 
                SqlHelper.ExecuteReader(cad_cn, "PA_LISTAR_PRODUCTOS_CC");
            //
            while (dr.Read()) {
                lista.Add(
                    new Productos()
                    {
                         cod_prod = dr.GetString(0),
                         nom_prod = dr.GetString(1),
                         pre_prod = dr.GetDecimal(3),
                         stk_prod = dr.GetInt32(4)
                    });            
            }
            dr.Close();
            //
            return lista;
        }

        public Productos BuscarProducto(string codigo)
        {
            var buscado = GetProductos()
                            .Find(p => p.cod_prod.Equals(codigo));

            return buscado;
        }

        public List<Clientes> GetClientes()
        { 
            var lista = new List<Clientes>();
            //
            var dr = 
                SqlHelper.ExecuteReader(cad_cn, "PA_LISTAR_CLIENTES_CC");
            //
            while (dr.Read()) {
                lista.Add(new Clientes() { 
                    cod_cli = dr.GetString(0),
                    nom_cli = dr.GetString(1)
                });
            }
            dr.Close();
            //
            return lista;
        }

        // falta el grabar

    }
}




