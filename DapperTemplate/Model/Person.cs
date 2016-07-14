
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperTemplate.Model
{
    [Serializable]
    public partial class Person
    {
        #region Attributes
        /// <summary>
        /// Id(PK)
        /// IsNullable=False
        ///</summary>
        private Int32 id;
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Username
        /// IsNullable=True
        ///</summary>
        private String username;
        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        /// <summary>
        /// Password
        /// IsNullable=True
        ///</summary>
        private String password;
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        /// <summary>
        /// Age
        /// IsNullable=True
        ///</summary>
        private Int32? age;
        public Int32? Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>
        /// RegisterDate
        /// IsNullable=True
        ///</summary>
        private DateTime? registerDate;
        public DateTime? RegisterDate
        {
            get { return registerDate; }
            set { registerDate = value; }
        }
        /// <summary>
        /// Address
        /// IsNullable=True
        ///</summary>
        private String address;
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion
    }
}


