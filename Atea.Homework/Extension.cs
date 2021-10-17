using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atea.Homework
{
    public static class Extension
    {
        public static Entity AddValues(this Common p, Input input)
        {
            Entity entity = new Entity();
            try
            {
                
                entity.firstArgument = Convert.ToString(input.firstArgument);
                entity.secondArgument = Convert.ToString(input.secondArgument);
                switch (input.type.ToLower())
                {
                    case "int":
                        entity.sum = (Convert.ToInt32(entity.firstArgument) + Convert.ToInt32(entity.secondArgument)).ToString();
                        break;

                    case "decimal":
                        entity.sum = (Convert.ToDecimal(entity.firstArgument) + Convert.ToDecimal(entity.secondArgument)).ToString();
                        break;

                    case "char":
                    case "string":
                        entity.sum = entity.firstArgument + entity.secondArgument;
                        break;

                    default:
                        break;

                }
                
            }
            catch (Exception ex)
            {
                return null;
            }
            return entity;
        }

    }
}
