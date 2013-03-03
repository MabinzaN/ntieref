﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductManager.WPF.Applications.Controllers
{
    public interface IEntityController
    {
        bool HasChanges { get; }


        void Initialize();

        bool Save();

        void Shutdown();
    }
}
