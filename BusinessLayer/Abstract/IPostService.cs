﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPostService: IGenericService<Post>
    {
        List<Post> GetListWithSectionLearner();
        List<Post> GetPostListByLearner(int id);
        List<Post> GetPostById(int id);
        List<Post> GetListWithSectionLearnerSectionID(int id);
    }
}
