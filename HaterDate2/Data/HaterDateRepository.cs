using HaterDate2.Models;
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

        public IQueryable<Hate> GetAllQuestions()
        {
            return _ctx.Hates;
        }

        public Profile GetProfileById(string userId)
        {
           return  _ctx.Profiles.Where(x => x.ApplicationUserId == userId).Single();
        }

        public ICollection<Hate> GetUserHates(string userId)
        {
            return GetProfileById(userId).Hates;
        }
    }
}