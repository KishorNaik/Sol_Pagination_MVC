using Sol_Pagination_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Pagination_MVC.Data
{
    public class UserData
    {
        public async Task<IEnumerable<UserModel>> GetUserDataAsync()
        {
            try
            {
                return await Task.Run(() => {

                    var userListData = new List<UserModel>()
                    {
                        new UserModel()
                        {
                            UserId=1,
                            FirstName="Kishor",
                            LastName="Naik"
                        },
                        new UserModel()
                        {
                            UserId=2,
                            FirstName="Vipul",
                            LastName="Singh"
                        },
                        new UserModel()
                        {
                            UserId=3,
                            FirstName="Bhushan",
                            LastName="Pawar"
                        },
                        new UserModel()
                        {
                            UserId=4,
                            FirstName="Navnath",
                            LastName="Memane"
                        },
                        new UserModel()
                        {
                            UserId=5,
                            FirstName="Sudesh",
                            LastName="Dhawade"
                        },
                        new UserModel()
                        {
                            UserId=6,
                            FirstName="Vinod",
                            LastName="Pawar"
                        },
                        new UserModel()
                        {
                            UserId=7,
                            FirstName="Navjyotsingh",
                            LastName="Thakur"
                        },
                        new UserModel()
                        {
                            UserId=8,
                            FirstName="Namrata",
                            LastName="Koregaonkar"
                        },
                        new UserModel()
                        {
                            UserId=9,
                            FirstName="Ashwin",
                            LastName="Singh"
                        },
                        new UserModel()
                        {
                            UserId=10,
                            FirstName="Archana",
                            LastName="Patil"
                        },
                    };

                    return userListData;

                });
            }
            finally
            { }
        }
    }
}
