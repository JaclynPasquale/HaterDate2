using HaterDate2.Data;
using HaterDate2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HaterDate2.Controllers
{
    public class HatesController : ApiController
    {
        IHaterDateRepository _repo;
        public HatesController(IHaterDateRepository repo)
        {
            _repo = repo;
        }

        public IQueryable<Hate> Get()
        {
            return _repo.GetAllQuestions();
        }
    }
}
