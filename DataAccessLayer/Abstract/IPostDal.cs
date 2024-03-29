﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPostDal: IGenericDal<Post>
    {
        List<Post> GetListWithSectionLearner();
        List<Post> GetListWithSectionLearnerSectionID(int id);
        List<Post> GetListWithSectionByLearner(int id);
    }
}
