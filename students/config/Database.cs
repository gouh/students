using students.database;

namespace students.config
{
    public class Database
    {
        
        public static void CreateTableCareers()
        {
            MySQLConnection.ExecuteStatement(
                @"CREATE TABLE IF NOT EXISTS Carreras 
                    (IdCarrera varchar(3) PRIMARY KEY, Descripcion TEXT);"
            );
        }
        
        public static void CreateTableDisciplines()
        {
            MySQLConnection.ExecuteStatement(
                @"CREATE TABLE IF NOT EXISTS Disciplinas 
                    (IdDisciplina varchar(3) PRIMARY KEY, Descripcion TEXT);"
            );
        }
        
        public static void CreateTableCourse()
        {
            MySQLConnection.ExecuteStatement(
                @"CREATE TABLE IF NOT EXISTS Materias 
                (
                    IdMateria varchar(3) PRIMARY KEY, 
                    Nombre varchar(30) not null,
                    HT int not null, 
                    HP int not null, 
                    IdCarrera varchar(3) not null,
                    IdDisciplina varchar(3) not null,
                    FOREIGN KEY (IdCarrera) REFERENCES Carreras (IdCarrera),
                    FOREIGN KEY (IdDisciplina) REFERENCES Disciplinas (IdDisciplina)
                );"
            );
        }
    }
}