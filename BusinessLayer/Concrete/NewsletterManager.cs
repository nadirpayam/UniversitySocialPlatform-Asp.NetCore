using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        INewsletterDal _newsletter;

        public NewsletterManager(INewsletterDal newsletter)
        {
            _newsletter = newsletter;
        }

        public void NewsletterAdd(NewsLetter s)
        {
            _newsletter.Insert(s);
        }
    }
}
