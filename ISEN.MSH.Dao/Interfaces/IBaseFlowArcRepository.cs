﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Nhibernate.Models.WorkFlow;

namespace ISEN.MSH.Dao.Interfaces
{
    public interface IBaseFlowArcRepository:IRepository<BaseFlowArc>
    {
        IQueryable<BaseFlowArc> LoadAllByPage(out long total, int page, int rows, string order, string sort);
    }
}
