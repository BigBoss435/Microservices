﻿namespace ECommerce.API.Customers.Profiles
{
    public class CustomerProfile : AutoMapper.Profile
    {
        public CustomerProfile() 
        {
            CreateMap<Db.Customer, Models.Customer>();
        }
    }
}
