using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;
using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;


namespace Villa.Business.Concrete
{
    public class SubHeaderManager:GenericManager<SubHeader>, ISubHeaderService
    {
        public SubHeaderManager(IGenericDal<SubHeader> genericDal) : base(genericDal)
        {
        }
    }
    
    }

