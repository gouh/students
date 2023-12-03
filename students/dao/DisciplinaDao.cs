using System;
using System.Collections.Generic;
using students.database;
using students.models;

namespace students.dao
{
    public class DisciplinaDao
    {
        public static List<Disciplina> GetAll()
        {
            return MySQLConnection.ExecuteQueryStatement<Disciplina>("SELECT * FROM Disciplinas;");
        }

        public static void Insert(Disciplina disciplina)
        {
            try
            {
                var statement =
                    $@"INSERT INTO Disciplinas (IdDisciplina, Descripcion) 
                        VALUES (
                            '{disciplina.IdDisciplina}', 
                            '{disciplina.Descripcion}'
                        );";
                MySQLConnection.ExecuteStatement(statement);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Update(Disciplina disciplina)
        {
            try
            {
                var statement =
                    $@"UPDATE Disciplinas
                        SET
                            Descripcion = '{disciplina.Descripcion}'
                        WHERE IdDisciplina = '{disciplina.IdDisciplina}';";
                MySQLConnection.ExecuteStatement(statement);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public static void Delete(String idDisciplina)
        {
            try
            {
                var statement =
                    $@"DELETE from Disciplinas WHERE IdDisciplina = '{idDisciplina}';";
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