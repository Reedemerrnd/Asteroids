using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Models
{
    public interface IFullMoveModel : IRotateModel, IMoveModel
    {
    }
}
