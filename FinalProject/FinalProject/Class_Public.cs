using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Class_Public
    {
        public enum State
        {
            Show,
            Add,
            Update
        }
        public static State state;
        public static DataTable User;
        public static DataTable dataTableOfPropretesOfUser;
        public static string NumberOfUser;
        public static string[] Propreties;
    }
}
