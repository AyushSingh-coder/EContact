using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace EContact.econtactClasses
{
    class contactClass
    {
        //Getter Setter properties
        //Acts as data carrier in our application
        public int ContactID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNo { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }

        //Create a static method to connect to our DB
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from database (1st Operation)
        public DataTable Select()
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * from tbl_contact";
                //Creating command using SQL and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL Data Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex) { }
            #pragma warning restore CS0168 // Variable is declared but never used
            finally
            {
                conn.Close(); 
            } 
            return dt;
        }

        //Inserting data into DB.(2nd Operation)
        public bool Insert(contactClass c)
        {
            //Creating default return type and setting its value to false.
            bool isSuccess = false;
            //Step 1: Connect DB.
            SqlConnection conn= new SqlConnection(myconnstrng);
#pragma warning disable CS0168 // Variable is declared but never used
            try 
            {
                //Step 2: Writing SQL Query.
                string sql = "INSERT into tbl_contact (FirstName, LastName, ContactNo, Address, Gender) VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender)";
                //Creating SQL command using SQL and conn.
                SqlCommand cmd= new SqlCommand(sql, conn);
                //Creating parameter to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                //Connection open here.
                conn.Open();
                int rows=cmd.ExecuteNonQuery();
                //If the query runs successfully then rows>0 else rows=0
                if (rows > 0)
                {
                    isSuccess= true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex) { }
            #pragma warning restore CS0168 // Variable ex is declared but never used
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to Update data in DB from our application(3rd Operation)
        public bool Update(contactClass c) 
        {
            //Creating default return type and setting its value to false.
            bool isSuccess = false;
            //Step 1: Connect DB.
            SqlConnection conn = new SqlConnection(myconnstrng);
            #pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                //Step 2:Writing SQL Query.
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE ContactID=@ContactId";
                //Creating SQL Command using cmd and sql.
                SqlCommand cmd= new SqlCommand(sql, conn);
                //Creating parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                //Open DB connection.
                conn.Open();

                int rows=cmd.ExecuteNonQuery();
                //If the query runs successfully then rows>0 else rows=0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex) { }
            #pragma warning restore CS0168 // Variable ex is declared but never used
            finally
            {
                //Close Connection.
                conn.Close();
            }
            return isSuccess;
        }
        //Method to delete a data from DB using application.
        public bool Delete(contactClass c) 
        {
            //Create a default return type and set its value to false.
            bool isSuccess = false;

            //Step 1:Creating SQL connection with DB.
            SqlConnection conn= new SqlConnection(myconnstrng);

            #pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                //Step 2: Creating SQL Query to delete a row from DB.
                string sql = "DELETE FROM tbl_contact WHERE ContactId=@ContactID";
                //Creating SQL Command.
                SqlCommand cmd= new SqlCommand(sql, conn);
                //Passing the parameter value using Parameter.
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //Open Connection
                conn.Open ();

                //Create an integer vlue to check if the query runs successfully or not.
                
                int rows= cmd.ExecuteNonQuery();
                //If query runs successfully then rows>0 else rows=0.
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex) { }
            #pragma warning restore CS0168 // Variable is declared but never used
            finally
            {
                //Close Connection.
                conn.Close(); 
            }
            return isSuccess;
        }

    }
}
