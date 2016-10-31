﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.template.Infra.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}
