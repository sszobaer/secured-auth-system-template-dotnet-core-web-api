using DAL.Entities.Context;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DataAccessFactory
    {
        AuthContext db;
        public DataAccessFactory(AuthContext db)
        {
            this.db = db;
        }

        public IRole RoleData() 
        {
            return new RoleRepo(db);
        }
    }
}
