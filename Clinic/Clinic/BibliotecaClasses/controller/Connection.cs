using MySql.Data.MySqlClient;

namespace BibliotecaClasses.controller {
    public class Connection {
        private MySqlConnection conn;

        public void connect() {
            string url = "server=localhost; database=clinic; uid=root; password='' ";
            conn = new MySqlConnection(url);
            conn.Open();
        }
        public void disconnect() {
            conn.Dispose();
            conn.Close();
        }

        public void update(string sql) {
            connect();
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            cmd.ExecuteNonQuery();
            disconnect();
        }
    }
}
