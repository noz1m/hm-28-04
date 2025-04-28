using Npgsql;

var connectionString = "Server=localhost;Database=hm-28-04;Port=5433; User Id=postgres;Password=nozimjanov";

using (var connection = new NpgsqlConnection(connectionString))
{
    connection.Open();
}

// using (var connection = new NpgsqlConnection(connectionString))
// {
//     connection.Open();

//     var cmd = @"create table students
//     (
//         id serial primary key,
//         name varchar(100),
//         surname varchar(100),
//         age int not null
//     )";
//     var command = new NpgsqlCommand(cmd, connection);
//     var result = command.ExecuteNonQuery();
//     if (result == -1)
//     {
//         System.Console.WriteLine("Table created successfully");
//     }
//     else
//     {
//         System.Console.WriteLine("Table not created");
//     }
// }

// System.Console.WriteLine("Enter name:");
// var name = Console.ReadLine();
// System.Console.WriteLine("Enter surname:");
// var surname = Console.ReadLine();
// System.Console.WriteLine("Enter your age:");
// var age = Convert.ToInt32(Console.ReadLine());

// using (var connection = new NpgsqlConnection(connectionString))
// {
//     connection.Open();

//     var cmd = @$"insert into students(name,surname,age) values ('{name}', '{surname}', {age})";
//     var command = new NpgsqlCommand(cmd, connection);
//     var result = command.ExecuteNonQuery();
//     System.Console.WriteLine($"Created {result}");
// }

// using (var connection = new NpgsqlConnection(connectionString))
// {
//     connection.Open();
//     var cmd = $"select * from students";
//     var command = new NpgsqlCommand(cmd, connection);
//     var reader = command.ExecuteReader();

//     if (reader.HasRows)
//     {
//         while (reader.Read())
//         {
//             var id = Convert.ToInt32(reader.GetValue(0));
//             var name = reader.GetValue(1).ToString();
//             var surname = reader.GetValue(2).ToString();
//             var age = Convert.ToInt32(reader.GetValue(3));
//             System.Console.WriteLine($"{id}\t{name}\t{surname}\t{age}");
//         }
//     }
// }

// using (var connection = new NpgsqlConnection(connectionString))
// {
//     connection.Open();

//     var cmd1 = @"update students
//                 set name = 'Alijon'
//                 where name = 'Ali' ";
//     var command1 = new NpgsqlCommand(cmd1, connection);
//     var result1 = command1.ExecuteNonQuery();
//     System.Console.WriteLine($"Updated {result1} records");

//     var cmd2 = @"update students 
//                 set name = 'Nozimjon'
//                 where name = 'Nozim' ";
//     var command2 = new NpgsqlCommand(cmd2, connection);
//     var result2 = command2.ExecuteNonQuery();
//     System.Console.WriteLine($"Updated {result2} records");

//     var cmd3 = @"delete from students
//                  where age = 26";
//     var command3 = new NpgsqlCommand(cmd3, connection);
//     var result3 = command3.ExecuteNonQuery();
//     System.Console.WriteLine($"Deleted {result3} records");
// }  

string newDatabaseName = "neon";

try 
{
    using (var connection = new NpgsqlConnection(connectionString))
    {
        connection.Open();
            using (var command = new NpgsqlCommand($"create database {newDatabaseName}", connection))
        {
            command.ExecuteNonQuery();
            Console.WriteLine($"База данных {newDatabaseName} успешно создана.");
        }
    }
}

catch (Exception ex)
{
    Console.WriteLine($"Ошибка при создании базы данных: {ex.Message}");
}