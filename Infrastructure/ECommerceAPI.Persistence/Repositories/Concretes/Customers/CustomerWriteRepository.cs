﻿using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Application.Repositories.Customers;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.Concretes.Customers
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}