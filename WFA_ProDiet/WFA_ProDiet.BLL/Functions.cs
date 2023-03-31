using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.BLL
{
    public static class Functions
    {
        public static ProDietDBContext _context = new ProDietDBContext();

        public static ProDietDBContext GetContext() { return _context; }

        public static List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
        public static bool AddUser(this User user)
        {
            if (user != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool UpdateUser(this User user)
        {
            if (user != null)
            {
                _context.Users.Attach(user);
                // _context.Entry(user).State=EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool RemoveUser(this User user)
        {
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
          public static bool RemoveRangeUser(ICollection<User> users)
        {
            if (users != null)
            {
                _context.Users.RemoveRange(users);
                _context.SaveChanges();
                return true;
            }
            return false;

        }

        public static User GetUserByID(int userID)
        {
            return _context.Users.Find(userID);
        }
        public static List<User> SearchUser(Func<User, bool> predicate)
        {
            List<User> findedUsers = new List<User>();
            foreach (User user in _context.Users)
            {
                if (predicate(user))
                {
                    findedUsers.Add(user);
                }
            }

            return findedUsers;
        }





    }
}
