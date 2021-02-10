using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager :IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine("Lütfen marka adını 2 karakterden fazla giriniz.");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka listeden çıkarıldı.");
        }

        public Brand Get(int id)
        {
            return _brandDal.Get(b=>b.Id == id);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("Marka adı güncellendi.");
        }
    }
}
