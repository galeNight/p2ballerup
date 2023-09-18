using System.Data;
using System.Data.SqlClient;

namespace Api.classes
{
    public class Sql
    {
        public void sqlconnection()
        {
            //to connect to my sql database via a strign
            string connection = "Data Source=192.168.23.220,1433;Initial Catalog=fødelsdatabase;Persist Security Info=True;User ID=JM;Password=Passw0rd";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                //open a connection
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    //using the connictio to manipulate the database
                    cmd.Connection = conn;
                    //cmd.CommandText = "insert into Person (Firstname, Lastname) values('john','doe')";
                    //cmd.CommandText = "update Person set Dateofbirth = '01-01-01' where PersonID = 1";
                    //cmd.ExecuteNonQuery();
                    cmd.CommandText = "select * from Person";

                    //show the sql database and show them via datatype string/int
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // while loop that show my table person and is data
                        while (reader.Read())
                        {
                            //show uotput the data from the table from person
                            //0 is PersonID,1 is Firstname,2 is Lastname,3 is Dateofbirth
                            //4 is Created,5 is Edited from sql database table Person," " er for at få et mellemrum
                            Console.Write(reader.GetInt32(0) + " ");
                            Console.Write(reader.GetString(1) + " ");
                            Console.Write(reader.GetString(2) + " ");
                            Console.Write(reader.GetString(3) + " ");
                            Console.Write(reader.GetDateTime(4) + " ");
                            Console.WriteLine(reader.GetDateTime(5) + " ");
                        }
                    }
                }
            }
        }
    }
}
