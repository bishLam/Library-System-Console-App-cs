﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.UserDataSetTableAdapters;

namespace Model
{
    /*
     * works with user data object recieved from dataset which is autogenerated
     * 
     */
    public class UserDAO
    {
        /*
         * return User data type objects
         */

        public User UserLogin(string username, String password)
        {

            // connect to the data set which generates code for user name and password

            //making the object of auto generated class containing user information

            TabUserTableAdapter tabUserTableAdapter = new TabUserTableAdapter();
            UserDataSet.TabUserDataTable tabUserDataTable = tabUserTableAdapter.getUserInfo(username, password);

            int numberOfData = tabUserDataTable.Count;

            if (tabUserDataTable != null) 
            {


                if (numberOfData > 0)
                {
                    DataRow dataRow = tabUserDataTable.Rows[0];
                    //valid username & password
                    User user = new User();
                    user.UserName = dataRow["UserName"].ToString();
                    user.Password = dataRow["Password"].ToString();
                    user.UserLevel = Convert.ToInt32(dataRow["UserLevel"].ToString());

                    return user;
                }

                else { 
                    // number of data is 0 or less which means no information
                    return null;
                }

            }

            else
            {
                //data is null 
                return null;
            }
        }
    }
}
