using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExt;
using DapperTemplate.Dao;
using DapperTemplate.Model;

namespace DapperTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_User();
            Test_Person();
        }

        private static void Test_Person()
        {
            var model = new Person
            {
                Username = "username01",
                Password = "123456",
                Age = 1
            };
            var personDao=new PersonDao();
            var isOkDelete = personDao.DeleteById(1);
            var id = personDao.Add(model);
            var isOkUpadte = personDao.UpdateById(new Person() {Username = "update"}, id);
            var model01 = personDao.FindById(id);
            var whereModel = new Person {Id = id};
            var model02 = personDao.FindList(whereModel, "id=@id", 1);
            //---
            #region where--比较推荐的写法--可以提高程序的可读性
            var where = new WhereEntity<Person>()
            {
                Model = new Person() { Id = id },
                Sql = "id=@id",
                OrderBy="id"
            };
            //
            var model03 = personDao.FindListByPage(where.Model, where.Sql, where.OrderBy, 0, 10);
            var count = personDao.Count(where.Model, where.Sql);
            #endregion


        }

        private static void Test_User()
        {
            var model = new User
            {
                Username = "xs",
                IsFirstTimeLogin = true,
                AccessFailedCount = 1,
                CreationDate = DateTime.Now,
                IsActive = true
            };
            var userDao = new UserDao();
            var isOkDelete=userDao.DeleteById(2);
            var userId = userDao.Add(model);
            var isOkUpdate= userDao.UpdateById(new User() {Username = "update"}, userId);
            var model01 = userDao.FindById(userId);
            var model02 = userDao.FindList(new User() {UserId = userId}, " userId=@userid", 1);
            var model03 = userDao.FindListByPage(new User() {UserId = userId}, " userId=@userid", " userId", 0, 10);
            var count = userDao.Count(new User() {Username = "update"}, " Username=@Username");
        }
    }
}
