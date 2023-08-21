using qlcfDAL;
using ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace qlcfBAL
{
    class dsBan
    {
        /*
         * Không được xem
         * Không được xóa
         * Không được sửa
         */
        data dab = new data();
        public DataTable showBan()
        {
            string sql = "select banid, tenban from ban";
            DataTable dt = new DataTable();
            dt = dab.getTable(sql);
            return dt;
        }
    }
}
