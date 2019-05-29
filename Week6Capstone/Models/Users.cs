using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week6Capstone.Models
{
    public class Users
    {
        public static List<User> users = new List<User>();

        public static bool IsUser(string otherUse, out int index)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserName.ToUpper() == otherUse.ToUpper())
                {
                    index = i;
                    return true;
                }
                else
                {
                    continue;
                }
            }
            index = 0;
            return false;
        }

        public static bool IsPass(string otherPass, int index)
        {
            if (Users.users[index].Password == otherPass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}