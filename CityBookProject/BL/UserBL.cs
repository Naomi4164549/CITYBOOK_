using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class UserBL
    {
        public static void AddUser(Entities.UserEntity user)
        {
            DAL.UserDAL.AddUser(user);
        }
    }
}
