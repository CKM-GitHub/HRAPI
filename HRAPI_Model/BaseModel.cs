using System.Data.SqlClient;

namespace HRAPI_Model
{
    public class BaseModel
    {
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public SqlParameter[] Sqlprms { get; set; }
    }
}
