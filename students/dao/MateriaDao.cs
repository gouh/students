using System;
using System.Collections.Generic;
using students.database;
using students.models;

namespace students.dao
{
    public class MateriaDao
    {
        public static List<Materia> GetAll()
        {
            return MySQLConnection.ExecuteQueryStatement<Materia>("SELECT * FROM Materias;");
        }

        public static void Insert(Materia materia)
        {
            try
            {
                var statement =
                    $@"INSERT INTO Materias (IdMateria, Nombre, HT, HP, IdCarrera, IdDisciplina) 
                        VALUES (
                            '{materia.IdMateria}', 
                            '{materia.Nombre}', 
                            '{materia.Ht}', 
                            '{materia.Hp}', 
                            '{materia.IdCarrera}',
                            '{materia.IdDisciplina}'
                        );";
                MySQLConnection.ExecuteStatement(statement);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Update(Materia materia)
        {
            try
            {
                var statement =
                    $@"UPDATE Materias 
                       SET
                            Nombre = '{materia.Nombre}', 
                            HT = '{materia.Ht}', 
                            HP = '{materia.Hp}', 
                            IdCarrera = '{materia.IdCarrera}',
                            IdDisciplina = '{materia.IdDisciplina}'
                       WHERE IdMateria = '{materia.IdMateria}';";
                MySQLConnection.ExecuteStatement(statement);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Delete(string idMateria)
        {
            try
            {
                var statement =
                    $@"DELETE from Materias WHERE IdMateria = '{idMateria}';";
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