using System;
using System.Data.SqlClient;
using ServiceStack.Text;

namespace Lesson3Databases {
    class Program {
        static void Main(string[] args) {
            using (var repository = new Repository()) {
                repository.AddCard(new Card {
                    Title = "A new card",
                    Type = "Creature"
                });
                
                var cards = repository.GetAllCards();
                Console.WriteLine(cards.Dump());

                Console.ReadLine();
            }
        }

        static void DoThingsTheStupidWay() {
            using (var connection = new SqlConnection()) {
                connection.ConnectionString = @"server=.\sql14;database=ManaOverflow;Integrated Security=true;";

                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from Card";

                connection.Open();

                Console.WriteLine("Cards:");
                Console.WriteLine("Id, Title, Type, Power, Toughness, Body");

                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        var id = reader.GetInt32(reader.GetOrdinal("Id"));
                        var title = reader.GetString(reader.GetOrdinal("Title"));
                        var type = reader.GetString(reader.GetOrdinal("Type"));

                        var power = reader.GetValue(reader.GetOrdinal("Power")) != DBNull.Value
                            ? (int?)reader.GetValue(reader.GetOrdinal("Power"))
                            : (int?)null;

                        var toughness = reader.GetValue(reader.GetOrdinal("Toughness")) != DBNull.Value
                            ? (int?)reader.GetValue(reader.GetOrdinal("Toughness"))
                            : (int?)null;

                        var body = reader.GetValue(reader.GetOrdinal("Body")) != DBNull.Value
                            ? (string)reader.GetValue(reader.GetOrdinal("Body"))
                            : null;

                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", id, title, type, power, toughness, body);
                    }
                }

                connection.Close();

                Console.Read();
            }            
        }
    }
}
