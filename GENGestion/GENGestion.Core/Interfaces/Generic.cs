using System;
using System.Collections.Generic;
using System.Text;

namespace GENGestion.Core.Interfaces
{
    public interface IGeneric<T>
    {
        T GetById(int id);
    }
}
