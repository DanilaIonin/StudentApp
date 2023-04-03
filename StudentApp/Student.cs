using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StudentApp
{
    [SQLite.Table("Students")]
    public class Student
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("_id")]
        public int Id { get; set; }
        public string Group { get; set; }
        public string FIO { get; set; }
    }
}
