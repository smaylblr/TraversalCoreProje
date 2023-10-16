using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAbboutDal _subAbboutDal;

        public SubAboutManager(ISubAbboutDal subAbboutDal)
        {
            _subAbboutDal = subAbboutDal;
        }

        public void TAdd(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAbboutDal.GetAll();
        }


        public void TUpdate(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
