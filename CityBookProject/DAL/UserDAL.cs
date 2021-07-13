using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UserDAL
    {
        public static void AddUser(Entities.UserEntity user)
        {
            try
            {
                using (UserDBContext ctx = new UserDBContext())
                {

                    foreach (var child in user.Children)
                    {
                        ctx.Child.Add(child);
                    }

                    ctx.User.Add(user);
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
