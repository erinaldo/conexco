using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace Conexco.Utils
{
    public static class Helper
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> collection)
        {
            DataTable dt = new DataTable("DataTable");
            Type t = typeof(T);
            PropertyInfo[] pia = t.GetProperties();

            List<PropertyInfo> baseTypesProperties = new List<PropertyInfo>();

            foreach (var p in pia)
            {
                if (!p.PropertyType.IsGenericType || !p.PropertyType.GetGenericArguments()[0].FullName.Contains("Conexco"))
                {
                    baseTypesProperties.Add(p);
                }
            }

            //Inspect the properties and create the columns in the DataTable 
            foreach (PropertyInfo pi in baseTypesProperties)
            {
                Type ColumnType = pi.PropertyType;
                if ((ColumnType.IsGenericType))
                {
                    ColumnType = ColumnType.GetGenericArguments()[0];
                }
                dt.Columns.Add(pi.Name, ColumnType);
            }

            //Populate the data table 
            foreach (T item in collection)
            {
                DataRow dr = dt.NewRow();
                dr.BeginEdit();
                foreach (PropertyInfo pi in baseTypesProperties)
                {
                    if (pi.GetValue(item, null) != null)
                    {
                        dr[pi.Name] = pi.GetValue(item, null);
                    }
                }
                dr.EndEdit();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        //public DataTable ToDataTable<T>(IEnumerable<T> collection)
        //{
        //    DataTable dt = new DataTable("DataTable");
        //    Type t = typeof(T);
        //    PropertyInfo[] pia = t.GetProperties();

        //    List<PropertyInfo> baseTypesProperties = new List<PropertyInfo>();

        //    foreach (var p in pia)
        //    {
        //        if (!p.PropertyType.IsGenericType || !p.PropertyType.GetGenericArguments()[0].FullName.Contains("Conexco"))
        //        {
        //            baseTypesProperties.Add(p);
        //        }
        //    }

        //    //Inspect the properties and create the columns in the DataTable 
        //    foreach (PropertyInfo pi in baseTypesProperties)
        //    {
        //        Type ColumnType = pi.PropertyType;
        //        if ((ColumnType.IsGenericType))
        //        {
        //            ColumnType = ColumnType.GetGenericArguments()[0];
        //        }
        //        dt.Columns.Add(pi.Name, ColumnType);
        //    }

        //    //Populate the data table 
        //    foreach (T item in collection)
        //    {
        //        DataRow dr = dt.NewRow();
        //        dr.BeginEdit();
        //        foreach (PropertyInfo pi in baseTypesProperties)
        //        {
        //            if (pi.GetValue(item, null) != null)
        //            {
        //                dr[pi.Name] = pi.GetValue(item, null);
        //            }
        //        }
        //        dr.EndEdit();
        //        dt.Rows.Add(dr);
        //    }
        //    return dt;
        //}
    }
}
