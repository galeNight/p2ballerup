using System.Data;
using System.Data.SqlClient;
using Api.classes;

namespace Api.classes
{
    public class Sql
    {
        public void AddSqlPerson(Person person)
        {
            // Initialize the SqlConnection with the correct connection string
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.23.220,1433;Initial Catalog=fødelsdatabase;Persist Security Info=True;User ID=JM;Password=Passw0rd"))
            {
                conn.Open(); // Open the connection

                // Create and configure the SqlCommand
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn; // Set the connection for the command
                    cmd.CommandText = "INSERT INTO Person (Firstname, Lastname, Dateofbirth) VALUES (@Fname, @Lname, @Bday)";
                    cmd.Parameters.AddWithValue("@Fname", person.Fname);
                    cmd.Parameters.AddWithValue("@Lname", person.Lname);
                    cmd.Parameters.AddWithValue("@Bday", person.Bday.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery(); // Execute the query
                }
            }
        }
        public List<Person> GetBirthdayList()
        {
            List<Person> Bdays = new List<Person>();

            // Initialize the SqlConnection with the correct connection string
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.23.220,1433;Initial Catalog=fødelsdatabase;Persist Security Info=True;User ID=JM;Password=Passw0rd"))
            {
                conn.Open(); // Open the connection

                // Create and configure the SqlCommand
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn; // Set the connection for the command
                    cmd.CommandText = "select * from Person"; // Select from Person from SQL database

                    SqlDataReader reader = cmd.ExecuteReader(); // Execute the query

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            try { person.Id = reader.GetInt32(0); } catch { person.Id = 0; }
                            try { person.Fname = reader.GetString(1); } catch { person.Fname = "null"; }
                            try { person.Lname = reader.GetString(2); } catch { person.Lname = "null"; }
                            person.Bday = DateOnly.FromDateTime(reader.GetDateTime(3));

                            Bdays.Add(person);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close(); // Close the reader
                }
            }
            return Bdays;
        }


        public void selectsqlPerson()
        {
            List<Person> Bdays = new List<Person>();

            // Initialize the SqlConnection with the correct connection string
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.23.220,1433;Initial Catalog=fødelsdatabase;Persist Security Info=True;User ID=JM;Password=Passw0rd"))
            {
                conn.Open(); // Open the connection

                // Create and configure the SqlCommand
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn; // Set the connection for the command
                    cmd.CommandText = "select * from Person"; // Select from Person from SQL database

                    SqlDataReader reader = cmd.ExecuteReader(); // Execute the query

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            try { person.Id = reader.GetInt32(0); } catch { person.Id = 0; }
                            try { person.Fname = reader.GetString(1); } catch { person.Fname = "null"; }
                            try { person.Lname = reader.GetString(2); } catch { person.Lname = "null"; }
                            person.Bday = DateOnly.FromDateTime(reader.GetDateTime(3));

                            Bdays.Add(person);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close(); // Close the reader
                }
            }
        }
    }
}