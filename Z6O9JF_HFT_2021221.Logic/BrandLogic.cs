﻿using System;
using System.Collections.Generic;
using Z6O9JF_HFT_2021221.Repository;
using Z6O9JF_HFT_2021221.Models;

namespace Z6O9JF_HFT_2021221.Logic
{
    public class BrandLogic
    {
        IBrandRepository myRepository;
        public BrandLogic(IBrandRepository entity)
        {
            this.myRepository = entity;
        }        
        public IEnumerable<Brand> GetAll()
        {
            return myRepository.GetAll();
        }   
        public void Create(Brand entity)
        {
            if (entity.BrandId is <1)
            {
                throw new ArgumentException("Incorrect BrandId");
            }
            else if (entity.Name is null || entity.Name.Length<3)
            {
                throw new ArgumentException("Incorrect Name");
            }
            else if (entity.Location is null || entity.Location.Length<2)
            {
                throw new ArgumentException("Incorrect Location");
            }
            else
            {
                myRepository.Create(entity);
            }
        }
        public Brand Read(int id)
        {
            return myRepository.Read(id);
        }
        public void Update(Brand entity)
        {
            myRepository.Update(entity);
        }
        public void Delete(int id)
        {
            myRepository.Delete(id);
        }
    }
}
