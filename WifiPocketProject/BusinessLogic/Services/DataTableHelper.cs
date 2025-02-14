using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public static class DataTableHelper
    {
        public static DataTable ToDataTable<T>(this List<T> data)
        {
            DataTable table = new DataTable(typeof(T).Name);

            if (data == null || !data.Any())
                return table; // Return empty DataTable if no data

            // Get properties from the type
            PropertyInfo[] properties = typeof(T).GetProperties();

            // Create columns
            foreach (var prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // Add rows
            foreach (T item in data)
            {
                var values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(item, null);
                }
                table.Rows.Add(values);
            }

            return table;
        }
    }
}
