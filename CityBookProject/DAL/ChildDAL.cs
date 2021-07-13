using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ChildDAL
    {
        public static void AddChild(Entities.ChildEntity child)
        {

            try
            {
                using (UserDBContext ctx = new UserDBContext())
                {
                    ctx.Child.Add(child);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
