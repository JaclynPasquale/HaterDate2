using HaterDate2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
using System.Net.Http;
using System.Web.Http;

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

        public bool AddHate(Hate newHate)
        {
            //check for modelstate validity 
            try
            {
                _ctx.Hates.Add(newHate);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}