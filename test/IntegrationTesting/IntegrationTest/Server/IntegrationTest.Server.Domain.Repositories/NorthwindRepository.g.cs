﻿//------------------------------------------------------------------------------
// <autogenerated>
//   This file was generated by T4 code generator NorthwindModel.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using IntegrationTest.Common.Domain.Model.Northwind;
using NTier.Common.Domain.Model;
using NTier.Server.Domain.Repositories;

namespace IntegrationTest.Server.Domain.Repositories
{
    public partial class NorthwindRepository : NTier.Server.Domain.Repositories.EntityFramework.Repository, INorthwindRepository
    {
        #region Constructors

        public NorthwindRepository()
            : base("name=NorthwindEntities", "NorthwindEntities")
        {
        }

        public NorthwindRepository(string connectionString, string containerName = "NorthwindEntities")
            : base(connectionString, containerName)
        {
        }

        public NorthwindRepository(EntityConnection connection, string containerName = "NorthwindEntities")
            : base(connection, containerName)
        {
        }

        #endregion Constructors

        #region EntitySets

        public IEntitySet<Category> Categories
        {
            get { return _categories  ?? (_categories = CreateEntitySet<Category>("Categories")); }
        }
        private IEntitySet<Category> _categories;

        public IEntitySet<Employee> Employees
        {
            get { return _employees  ?? (_employees = CreateEntitySet<Employee>("Employees")); }
        }
        private IEntitySet<Employee> _employees;

        public IEntitySet<OrderDetail> OrderDetails
        {
            get { return _orderDetails  ?? (_orderDetails = CreateEntitySet<OrderDetail>("OrderDetails")); }
        }
        private IEntitySet<OrderDetail> _orderDetails;

        public IEntitySet<Order> Orders
        {
            get { return _orders  ?? (_orders = CreateEntitySet<Order>("Orders")); }
        }
        private IEntitySet<Order> _orders;

        public IEntitySet<Product> Products
        {
            get { return _products  ?? (_products = CreateEntitySet<Product>("Products")); }
        }
        private IEntitySet<Product> _products;

        public IEntitySet<Region> Regions
        {
            get { return _regions  ?? (_regions = CreateEntitySet<Region>("Regions")); }
        }
        private IEntitySet<Region> _regions;

        public IEntitySet<Shipper> Shippers
        {
            get { return _shippers  ?? (_shippers = CreateEntitySet<Shipper>("Shippers")); }
        }
        private IEntitySet<Shipper> _shippers;

        public IEntitySet<Supplier> Suppliers
        {
            get { return _suppliers  ?? (_suppliers = CreateEntitySet<Supplier>("Suppliers")); }
        }
        private IEntitySet<Supplier> _suppliers;

        public IEntitySet<Territory> Territories
        {
            get { return _territories  ?? (_territories = CreateEntitySet<Territory>("Territories")); }
        }
        private IEntitySet<Territory> _territories;

        public IEntitySet<DemographicGroup> CustomerDemographics
        {
            get { return _customerDemographics  ?? (_customerDemographics = CreateEntitySet<DemographicGroup>("CustomerDemographics")); }
        }
        private IEntitySet<DemographicGroup> _customerDemographics;

        public IEntitySet<Customer> Customers
        {
            get { return _customers  ?? (_customers = CreateEntitySet<Customer>("Customers")); }
        }
        private IEntitySet<Customer> _customers;

        public IEntitySet<DynamicContentEntity> DynamicContentEntities
        {
            get { return _dynamicContentEntities  ?? (_dynamicContentEntities = CreateEntitySet<DynamicContentEntity>("DynamicContentEntities")); }
        }
        private IEntitySet<DynamicContentEntity> _dynamicContentEntities;

        #endregion EntitySets
    }
}
