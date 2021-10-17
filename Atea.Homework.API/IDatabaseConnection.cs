using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atea.Homework.API
{
    public interface IDatabaseConnection
    {
         public Task<Entity> SaveDataToDb(Entity entity);
    }
}
