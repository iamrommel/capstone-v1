using System;
using System.Data.Entity.Migrations;
using System.Linq;
using App.Model;
using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public class AdminAccountManager
    {

        

        public bool Login(string userName, string password)
        {
            //chech the user name and password from dataase
            var admin = GetAdmin(userName, password);


            //if the passowrd (case sensitive) and username exists on the database then he can logi
            if (admin == null)
                return false;
            else
                return true;
        }

        public void ChangePassword(string userName, string oldPassword, string newPassword)
        {
            using (var context = new QuizBeeEntities())
            {
                //get the instance of admin first to verify that the user is valid
                var adminAccount = GetAdmin(userName, oldPassword);


                //if the user does not exist then throw error
                if (adminAccount == null)
                    throw new InvalidUserNameOrPasswordException();


                //if not continue changing the password
                adminAccount.Password = newPassword; //set the new passowrd

                context.AdminAccounts.AddOrUpdate(adminAccount);
                    //this will add if it does not exist or just update if exists
                context.SaveChanges(); //save the changes on database
            }

        }


        /// <summary>
        /// This method get the admin account from database using userName and password
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        private AdminAccount GetAdmin(string userName, string password)
        {
            using (var context = new QuizBeeEntities())
            {
                var result =
                    context.AdminAccounts.FirstOrDefault(m => m.Password == password && m.UserName == userName);

                //if the there is a result, try to compare the password with case sensitivity
                if (result != null)
                {
                    var isEqual = result.Password.Equals(password, StringComparison.Ordinal);

                    //if they password from database and from the user input is not the same with case sensitivity
                    //then return and empty result, else it will just continue on the next line
                    if (!isEqual)
                        return null;

                }

                return result;
            }
        }

    }



    public class InvalidUserNameOrPasswordException : Exception
    {

    }

}