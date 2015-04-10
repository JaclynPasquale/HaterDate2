using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaterDate2.Data
{
    public class HaterDateRepository : IHaterDateRepository
    {
        HaterDateContext _ctx;

        public HaterDateRepository(HaterDateContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Models.Hate> GetAllQuestions()
        {
            throw new NotImplementedException();
        }

        public Models.Profile GetProfileById(string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Models.Hate> GetUserHates(string userId)
        {
            throw new NotImplementedException();
        }
    }
}