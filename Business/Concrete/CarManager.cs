﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetByBrandId(brandId);
        }

        public List<Car> GetByModelYear()
        {
            return _carDal.GetByModelYear();
        }

        public Car GetByMostCheap()
        {
            return _carDal.GetMostCheap();
        }

        public Car GetByMostExpensive()
        {
            return _carDal.GetMostExpensive();
        }

        public List<Car> GetByPrice()
        {
            return _carDal.GetByPrice();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
