using System;
using System.Collections.Generic;
using students.database;
using students.models;

namespace students.dao
{
    public class CarreraDao
    {
        public static List<Carrera> GetAll()
        {
            return MySQLConnection.ExecuteQueryStatement<Carrera>("SELECT * FROM Carreras;");
        }

        public static void Insert(Carrera materia)
        {
            try
            {
                var statement =
                    $@"INSERT INTO Carreras (IdCarrera, Descripcion) 
                        VALUES (
                            '{materia.IdCarrera}', 
                            '{materia.Descripcion}'
                        );";
                MySQLConnection.ExecuteStatement(statement);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public static void Update(Carrera materia)
        {
            try
            {
                var statement =
                    $@"UPDATE Carreras
                        SET
                            Descripcion = '{materia.Descripcion}'
                        WHERE IdCarrera = '{materia.IdCarrera}';";
                MySQLConnection.ExecuteStatement(statement);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Delete(String idCarrera)
        {
            try
            {
                var statement =
                    $@"DELETE from Carreras WHERE IdCarrera = '{idCarrera}';";
                MySQLConnection.ExecuteStatement(statement);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}