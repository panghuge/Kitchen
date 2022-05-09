using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBhelper
    {
        //创建连接字符串
        public static string connstring = "Data Source=172.20.38.159;Initial Catalog=Food;User ID=sa;Password=123;MultipleActiveResultSets=true;";
        //创建连接对象
        public static SqlConnection conn = null;
        //初始化连接对象
        public static void Initconnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connstring);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }

        //增删改方法
        public static bool ExecuteNonQuery(string sql)
        {
            Initconnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
        //执行聚合函数
        public static object ExecuteScalar(string sql)
        {
            Initconnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }
        //查询
        public static SqlDataReader reader(string sql)
        {
            Initconnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //数据集
        public static DataSet GetDataSet(string sql)
        {
            Initconnection();
            DataSet ds = new DataSet();
            SqlDataAdapter dsp = new SqlDataAdapter(sql, conn);
            dsp.Fill(ds, "ds");
            conn.Close();
            return ds;
        }
        //DataTable表格显示
        public static DataTable table(string sql)
        {
            Initconnection();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(dt);
            conn.Close();
            return dt;
            //return GetDataSet(sql).Tables[0];

        }
    }
}
