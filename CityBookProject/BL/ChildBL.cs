using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
     public class ChildBL
    {

        public static void AddChild(Entities.ChildEntity child)
        {
            DAL.ChildDAL.AddChild(child);
        }
    }
}
