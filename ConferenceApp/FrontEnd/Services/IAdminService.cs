﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Services
{
    public interface IAdminService
    {
        Task<bool> AllowAdminUserCreationAsync();
    }
}

