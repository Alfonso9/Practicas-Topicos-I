﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection.Modelo
{
    interface IRepositorio<E>
    {
       bool Add(E e);
       bool Delete(E e);
       List<E> GetAll();
    }
}
