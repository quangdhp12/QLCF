using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using qlcfDAL;

namespace qlcfBAL
{
    public class thucDon
    {
        data da = new data();
        //Quản lý Thực đơn
        public DataTable showThucDon()
        {
            string sql = "select douongid, tendouong, dongia from thucdon";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //them thuc don
        public void themThucDon(string mdu, string tdu, string dg)
        {
            string sql = "insert thucdon values('"+mdu+"',N'"+tdu+"','"+dg+"')";
            da.excuteNonQuery(sql);
        }
        //sua thuc don
        public void suaThucDon(string mdu1, string tdu, string dg, string mdu)
        {
            string sql = "update thucdon set douongid=N'"+tdu+"', tendouong=N'"+dg+"', dongia=N'"+mdu+"' where douongid=N'"+mdu1+"'";
            da.excuteNonQuery(sql);
        }
        //xoa thuc don
        public void xoaThucDon(string mdu)
        {
            string sql = "delete thucdon where douongid=N'" + mdu + "'";
            da.excuteNonQuery(sql);
        }
        //tim kiem
        public DataTable timThucDon(string tk)
        {
            string sql = "select douongid, tendouong, dongia from thucdon where douongid like N'%" + tk + "%' or tendouong like N'%" + tk + "' or dongia like N'" + tk + "'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        /*
         * /////Quản lý bàn
         */
        public DataTable showBan()
        {
            string sql = "select banid, tenban from ban";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //them ban
        public void themBan(string mb, string tb)
        {
            string sql = "insert ban values('" + mb + "',N'" + tb + "')";
            da.excuteNonQuery(sql);
        }
        //sua bàn
        public void suaBan(string mb, string tb, string mb1)
        {
            string sql = "update ban set banid='" + mb + "', tenban=N'" + tb + "' where banid='" + mb1 + "'";
            da.excuteNonQuery(sql);
        }
        //xoa ban
        public void xoaBan(string mb)
        {
            string sql = "delete ban where banid='" + mb + "'";
            da.excuteNonQuery(sql);
        }
        //form hóa đơn
        public DataTable showHoaDon()
        {
            string sql = "select goiid, tenban, tendouong, soluong, soluong*dongia as thanhtien from goimon a, ban b, thucdon c where a.banid=b.banid and a.douongid=c.douongid";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable timHoaDon(string tk)
        {
            string sql = "select goiid, tenban, tendouong, soluong, soluong*dongia as thanhtien from goimon a, ban b, thucdon c where a.banid=b.banid and a.douongid=c.douongid and goiid like N'%" + tk + "%'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //ban 1
        public DataTable showBan1()
        {
            string sql = "select goiid,tendouong,soluong,dongia from thucdon a, goimon b where a.douongid = b.douongid and banid = 'B01'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan1(string mhd, string du, string sl)
        {
            string sql = "insert into goimon(goiid,banid,douongid,soluong) values('" + mhd + "','B01','" + du + "','"+sl+"')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan1(string mhd)
        {
            string sql = "delete goimon where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan1(string mhd, string du, string sl)
        {
            string sql = "update goimon set douongid='" + du + "', soluong='"+sl+"' where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan1()
        {
            string sql = "delete goimon where banid='B01'";
            da.excuteNonQuery(sql);
        }
        //bàn 2
        public DataTable showBan2()
        {
            string sql = "select goiid,tendouong,soluong,dongia from thucdon a, goimon b where a.douongid = b.douongid and banid = 'B02'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan2(string mhd, string du, string sl)
        {
            string sql = "insert into goimon(goiid,banid,douongid,soluong) values('" + mhd + "','B02','" + du + "','" + sl + "')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan2(string mhd)
        {
            string sql = "delete goimon where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan2(string mhd, string du, string sl)
        {
            string sql = "update goimon set douongid='" + du + "', soluong='" + sl + "' where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan2()
        {
            string sql = "delete goimon where banid='B02'";
            da.excuteNonQuery(sql);
        }
        //bàn 3
        public DataTable showBan3()
        {
            string sql = "select goiid,tendouong,soluong,dongia from thucdon a, goimon b where a.douongid = b.douongid and banid = 'B03'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan3(string mhd, string du, string sl)
        {
            string sql = "insert into goimon(goiid,banid,douongid,soluong) values('" + mhd + "','B03','" + du + "','" + sl + "')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan3(string mhd)
        {
            string sql = "delete goimon where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan3(string mhd, string du, string sl)
        {
            string sql = "update goimon set douongid='" + du + "', soluong='" + sl + "' where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan3()
        {
            string sql = "delete goimon where banid='B03'";
            da.excuteNonQuery(sql);
        }
        //bàn 4
        public DataTable showBan4()
        {
            string sql = "select goiid,tendouong,soluong,dongia from thucdon a, goimon b where a.douongid = b.douongid and banid = 'B04'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan4(string mhd, string du, string sl)
        {
            string sql = "insert into goimon(goiid,banid,douongid,soluong) values('" + mhd + "','B04','" + du + "','" + sl + "')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan4(string mhd)
        {
            string sql = "delete goimon where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan4(string mhd, string du, string sl)
        {
            string sql = "update goimon set douongid='" + du + "', soluong='" + sl + "' where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan4()
        {
            string sql = "delete goimon where banid='B04'";
            da.excuteNonQuery(sql);
        }
        //bàn 5
        public DataTable showBan5()
        {
            string sql = "select goiid,tendouong,soluong,dongia from thucdon a, goimon b where a.douongid = b.douongid and banid = 'B05'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan5(string mhd, string du, string sl)
        {
            string sql = "insert into goimon(goiid,banid,douongid,soluong) values('" + mhd + "','B05','" + du + "','" + sl + "')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan5(string mhd)
        {
            string sql = "delete goimon where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan5(string mhd, string du, string sl)
        {
            string sql = "update goimon set douongid='" + du + "', soluong='" + sl + "' where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan5()
        {
            string sql = "delete goimon where banid='B05'";
            da.excuteNonQuery(sql);
        }
        //bàn 6
        public DataTable showBan6()
        {
            string sql = "select goiid,tendouong,soluong,dongia from thucdon a, goimon b where a.douongid = b.douongid and banid = 'B06'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan6(string mhd, string du, string sl)
        {
            string sql = "insert into goimon(goiid,banid,douongid,soluong) values('" + mhd + "','B06','" + du + "','" + sl + "')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan6(string mhd)
        {
            string sql = "delete goimon where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan6(string mhd, string du, string sl)
        {
            string sql = "update goimon set douongid='" + du + "', soluong='" + sl + "' where goiid='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan6()
        {
            string sql = "delete goimon where banid='B06'";
            da.excuteNonQuery(sql);
        }
    }
}
