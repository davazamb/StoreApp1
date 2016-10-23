using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class DBHelper
    {
        public static Response SaveChanges(StoreApp1Context db)
        {
            try
            {
                db.SaveChanges();
                return new Response { Succeeded = true, };
            }
            catch (Exception ex)
            {
                var response = new Response { Succeeded = false, };
                if (ex.InnerException != null &&
                    ex.InnerException.InnerException != null &&
                    ex.InnerException.InnerException.Message.Contains("_Index"))
                {
                    response.Message = "Hay un registro con el mismo valor";
                }
                else if (ex.InnerException != null &&
                    ex.InnerException.InnerException != null &&
                    ex.InnerException.InnerException.Message.Contains("REFERENCE"))
                {
                    response.Message = "El registro no se puede eliminar porque tiene valores relacionados";
                }
                else
                {
                    response.Message = ex.Message;
                }

                return response;
            }
        }

    }
}
