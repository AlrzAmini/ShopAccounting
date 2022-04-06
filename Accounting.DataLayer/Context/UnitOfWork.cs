﻿using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer
{
    public class UnitOfWork : IDisposable
    {

        ShopAccountingDBEntities db = new ShopAccountingDBEntities();

        private GenericRepository<Accounting> _accountingRepository;
        public GenericRepository<Accounting> AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<Accounting>(db) ;
                }
                return _accountingRepository;
            }
        }

        private GenericRepository<Login> _loginRepository;
        public GenericRepository<Login> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }

        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }

                return _customerRepository;
            }
        }

        private IGoodsRepository _goodsRepository;

        public IGoodsRepository GoodsRepository
        {
            get
            {
                if (_goodsRepository == null)
                {
                    _goodsRepository = new GoodsRepository(db);
                }

                return _goodsRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}