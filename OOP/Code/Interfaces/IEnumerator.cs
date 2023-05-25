using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    public interface IEnumerator<T> : IEnumerator
    {
        new T Current { get; }
    }
}
