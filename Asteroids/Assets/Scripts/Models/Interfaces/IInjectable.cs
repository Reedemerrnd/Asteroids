using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Models
{
    public interface IInjectable<T> where T : class
    {
        public void Inject(T dependency);
    }
}
