using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DataSourceControls
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Student()
        { }

        public DataSet GetStudents()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Students");

            dt.Columns.Add("StudentId", typeof(System.Int32));
            dt.Columns.Add("StudentName", typeof(System.String));
            dt.Columns.Add("StudentCity", typeof(System.String));

            dt.Rows.Add(new object[] { 1, "Mira", "Pune" });
            dt.Rows.Add(new object[] { 2, "Amy", "Chennai" });
            dt.Rows.Add(new object[] { 2, "Aron", "Delhi" });
            dt.Rows.Add(new object[] { 4, "Steve", "Bangalore" });
            dt.Rows.Add(new object[] { 5, "Patrick", "Cochin" });


            ds.Tables.Add(dt);

            return ds;


        }
    }
}