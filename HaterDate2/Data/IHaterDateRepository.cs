using HaterDate2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaterDate2.Data
{
    public interface IHaterDateRepository
    {
        IQueryable<Hate> GetAllQuestions();
        Profile GetProfileById(string userId);
        ICollection<Hate> GetUserHates(string userId);
    }
}
