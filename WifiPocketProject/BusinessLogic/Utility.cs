﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static BusinessLogic.Model.StaticModel.DashboardModel;

namespace BusinessLogic
{
    public class Utility
    {
        public DataTable ListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }



        public DataTable ListToDataTable(List<string> list)
        {
            DataTable dt = new DataTable();
            List<GridViewDbModel> _list = new List<GridViewDbModel>();
            GridViewDbModel model = new GridViewDbModel();
            List<object> llist  = null;
            // Add columns to DataTable
            dt.Columns.Add("Parameter", typeof(string));
            dt.Columns.Add("Battery-1", typeof(string));
            dt.Columns.Add("Battery-2", typeof(string));
            dt.Columns.Add("Battery-3", typeof(string));
            dt.Columns.Add("Battery-4", typeof(string));
            dt.Columns.Add("Battery-5", typeof(string));

            // Add rows from the list
            foreach (string item in list)
            {
                DataRow row = dt.NewRow();
                row["Parameter"] = item;
                // Other columns are left blank for each row
                dt.Rows.Add(item);
                model.Parameter = item;
                _list.Add(model);
            }
            MainLogicClass.usp_Insert(_list, out string msg);
            return dt;
        }
    }
}
