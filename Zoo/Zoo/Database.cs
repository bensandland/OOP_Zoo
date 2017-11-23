/*
 * Prepped for later use.
 * Oprettet af Jonathan fra SKP som har overgivet projektet til Benjamin & Kristian.
 * Efter overtagelse er det blevet rettet til så det er lidt mere brugbart dog er der en masse bool shit i det.
 * Nuget: MySQL.Data package installed.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Zoo
{
    class Database
    {
        private string[] LoginArr;
        public string connString;
        public static MySqlConnection conn = null;
        private Regex rGX = new Regex("[?]+");
        internal Nullable<int> tmp;

        internal Database(string[] Login)
        {

            LoginArr = Login;
            resetDB(Login);
        }

        internal Database()
        {
            
        }

        public async Task resetDB(string[] Login = null)
        {
            if (LoginArr.Length <= 0)
                return;

            if(Login != null)
                LoginArr = Login;
            connString = "username=" + LoginArr[3] + ";" +
                         "password=" + LoginArr[5] + ";" +
                         "datasource=" + LoginArr[1] + ";" +
                         "port=" + LoginArr[9] + ";" +
                         "database=" + LoginArr[7] + ";";
            conn = new MySqlConnection(connString);

            try
            {
                await conn.OpenAsync();
            }
            catch (Exception)
            {

            }
            return;
        }

        public bool isOnline()
        {
            try
            {
                if (conn.Ping())
                {
                    return true;
                }
            } catch (Exception)
            {

            }
            return false;
        }

        public bool isConnected()
        {
            try
            {
                if (conn.State.ToString() == "Open")
                {
                    return true;
                }
            } catch (Exception)
            {
                return false;
            }

            return false;
        }

        private async void Connect()
        {
            try
            {
                await conn.OpenAsync();
            }
            catch (Exception)
            {
                conn = null;
            }
        }

        private bool Close()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
                return true;
            }
            return false;
        }

        #region Queries
        internal Nullable<int> insert(string sql, List<string> sqlParams)
        {
            if (rGX.Matches(sql).Count != sqlParams.Count)
            {
                return null;
            }
            int c = 0;
            string replacedString = rGX.Replace(sql, m => "?var_" + (c++).ToString());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = replacedString;
            cmd.Prepare();


            for (int i = 0; i < sqlParams.Count; i++)
            {
                cmd.Parameters.AddWithValue("?var_" + i, sqlParams[i]);
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return null;
            }
            return Convert.ToInt32(cmd.LastInsertedId);
        }

        internal List<IDictionary<string, string>> select(string sql, List<string> sqlParams)
        {
            if (rGX.Matches(sql).Count != sqlParams.Count)
            {
                return null;
            }
            int c = 0;
            string replacedString = rGX.Replace(sql, m => "?var_" + (c++).ToString());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = replacedString;
            cmd.Prepare();


            //for (int i = 0; i < sqlParams.Count; i++)
            uint sqlParamCounter = 0;
            /*
            foreach (string sqlParam in sqlParams)
            {
                sqlParamCounter++;
                cmd.Parameters.AddWithValue("?var_" + sqlParamCounter, sqlParam);
            }
            */
            sqlParams.ForEach(param => cmd.Parameters.AddWithValue("?var_" + sqlParamCounter, param));
            MySqlDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                return null;
            }
            List<IDictionary<string, string>> MDMA = new List<IDictionary<string, string>>();

            while (reader.Read())
            {
                IDictionary<string, string> ict = new Dictionary<string, string>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    // Converting result to UTF 8
                    byte[] bytes = Encoding.Default.GetBytes(reader.GetString(i));
                    ict[reader.GetName(i)] = Encoding.UTF8.GetString(bytes);
                }
                //#SPAS
                MDMA.Add(ict);

            }
            reader.Close();
            return MDMA;
        }
#endregion Queries
    }
}