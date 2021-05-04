using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbcompta
{
    class UserController
    {
        List<User> Users;
        Database Db;
        public UserController()
        {
            Db = new Database();
        }

        public List<User> getUsers()
        {
            try
            {
                Db.Mysql.Open();

                MySqlCommand cmd = Db.Mysql.CreateCommand();

                cmd.CommandText = "SELECT * FROM utilisateur";
                MySqlDataReader reader = cmd.ExecuteReader();
                Users = new List<User>();

                while (reader.Read())
                {
                    User u = new User(reader["id"].ToString(), reader["nom"].ToString(), 
                        reader["prenom"].ToString(), reader["login"].ToString(), 
                        reader["mdp"].ToString(), reader["adresse"].ToString(), 
                        reader["cp"].ToString(), reader["ville"].ToString(), 
                        reader["dateEmbauche"].ToString(), reader["role"].ToString());
                    Users.Add(u);                                       
                }
                Db.Mysql.Close();
                return Users;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Users;
            }            
        }

        public void addUsers(string id, string name, string firstname, string login, string password, string address, string zip, string city, string dateEmployment, string role)
        {
            try
            {
                Db.Mysql.Open();

                MySqlCommand cmd = Db.Mysql.CreateCommand();

                cmd.CommandText = "INSERT INTO utilisateur(id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche, role) VALUES ('"+id+"','"+name+"', '"+firstname+ "', '"+login+ "', '"+password+ "','"+address+ "','"+zip+ "', '"+city+ "','"+dateEmployment+ "', '"+role+"')";
             
                cmd.ExecuteNonQuery();
                
                Db.Mysql.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e);  
                
            }
        }
    }
}
