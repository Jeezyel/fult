using System;
using System.Collections.Generic;

namespace futTentativaDois.Migrations
{
    public class MigrationBuilder
    {
        private readonly List<string> _operations = new List<string>();

        public void CreateTable(string name, Action<TableBuilder> buildAction, object columns, Action<object> constraints)
        {
            _operations.Add($"CreateTable: {name}");
            var tableBuilder = new TableBuilder(name);
            buildAction(tableBuilder);
        }

        public void DropTable(string name)
        {
            _operations.Add($"DropTable: {name}");
        }

        public void ShowOperations()
        {
            foreach (var op in _operations)
            {
                Console.WriteLine(op);
            }
        }
    }

    public class TableBuilder
    {
        public string TableName { get; }

        public TableBuilder(string tableName)
        {
            TableName = tableName;
        }

        public void Column<T>(string name, bool nullable = true)
        {
            Console.WriteLine($"Add Column: {name}, Type: {typeof(T).Name}, Nullable: {nullable}");
        }
    }
}