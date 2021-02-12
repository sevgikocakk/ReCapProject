﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(int id);
        void Add(User user);
        void Delete(User user);
        void Update(User user);

    }
}
