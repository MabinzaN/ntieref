﻿//------------------------------------------------------------------------------
// <auto-generated>
//   This file was generated by T4 code generator Northwind.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using NTier.Common.Domain.Model;

namespace IntegrationTest.Common.Domain.Model.Northwind
{
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(Customer))]
    [KnownType(typeof(Employee))]
    [KnownType(typeof(Order_Detail))]
    [KnownType(typeof(Shipper))]
    public partial class Order : Entity, INotifyPropertyChanged, INotifyPropertyChanging, IDataErrorInfo
    {
        #region Constructor and Initialization

        // partial method for initialization
        partial void Initialize();

        public Order()
        {
            Initialize();
        }

        #endregion Constructor and Initialization

        #region Simple Properties

        [DataMember]
        [Key]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [ServerGeneration(ServerGenerationTypes.Insert)]
        [SimpleProperty]
        public global::System.Int32 OrderID
        {
            get { return _orderID; }
            set
            {
                if (_orderID != value)
                {
                    if (!IsDeserializing && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'OrderID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    OrderIDChanging(value);
                    OnPropertyChanging("OrderID", value);
                    var previousValue = _orderID;
                    _orderID = value;
                    OnPropertyChanged("OrderID", previousValue, value);
                    OrderIDChanged(previousValue);
                }
            }
        }
        private global::System.Int32 _orderID;

        partial void OrderIDChanging(global::System.Int32 newValue);
        partial void OrderIDChanged(global::System.Int32 previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [ForeignKeyProperty]
        [SimpleProperty]
        public global::System.String CustomerID
        {
            get { return _customerID; }
            set
            {
                if (_customerID != value)
                {
                    CustomerIDChanging(value);
                    OnPropertyChanging("CustomerID", value);
                    if (!IsDeserializing)
                    {
                        if (Customer != null && Customer.CustomerID != value)
                        {
                            Customer = null;
                        }
                    }
                    var previousValue = _customerID;
                    _customerID = value;
                    OnPropertyChanged("CustomerID", previousValue, value);
                    CustomerIDChanged(previousValue);
                }
            }
        }
        private global::System.String _customerID;

        partial void CustomerIDChanging(global::System.String newValue);
        partial void CustomerIDChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [ForeignKeyProperty]
        [SimpleProperty]
        public Nullable<global::System.Int32> EmployeeID
        {
            get { return _employeeID; }
            set
            {
                if (_employeeID != value)
                {
                    EmployeeIDChanging(value);
                    OnPropertyChanging("EmployeeID", value);
                    if (!IsDeserializing)
                    {
                        if (Employee != null && Employee.EmployeeID != value)
                        {
                            Employee = null;
                        }
                    }
                    var previousValue = _employeeID;
                    _employeeID = value;
                    OnPropertyChanged("EmployeeID", previousValue, value);
                    EmployeeIDChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.Int32> _employeeID;

        partial void EmployeeIDChanging(Nullable<global::System.Int32> newValue);
        partial void EmployeeIDChanged(Nullable<global::System.Int32> previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public Nullable<global::System.DateTime> OrderDate
        {
            get { return _orderDate; }
            set
            {
                if (_orderDate != value)
                {
                    OrderDateChanging(value);
                    OnPropertyChanging("OrderDate", value);
                    var previousValue = _orderDate;
                    _orderDate = value;
                    OnPropertyChanged("OrderDate", previousValue, value);
                    OrderDateChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.DateTime> _orderDate;

        partial void OrderDateChanging(Nullable<global::System.DateTime> newValue);
        partial void OrderDateChanged(Nullable<global::System.DateTime> previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public Nullable<global::System.DateTime> RequiredDate
        {
            get { return _requiredDate; }
            set
            {
                if (_requiredDate != value)
                {
                    RequiredDateChanging(value);
                    OnPropertyChanging("RequiredDate", value);
                    var previousValue = _requiredDate;
                    _requiredDate = value;
                    OnPropertyChanged("RequiredDate", previousValue, value);
                    RequiredDateChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.DateTime> _requiredDate;

        partial void RequiredDateChanging(Nullable<global::System.DateTime> newValue);
        partial void RequiredDateChanged(Nullable<global::System.DateTime> previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public Nullable<global::System.DateTime> ShippedDate
        {
            get { return _shippedDate; }
            set
            {
                if (_shippedDate != value)
                {
                    ShippedDateChanging(value);
                    OnPropertyChanging("ShippedDate", value);
                    var previousValue = _shippedDate;
                    _shippedDate = value;
                    OnPropertyChanged("ShippedDate", previousValue, value);
                    ShippedDateChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.DateTime> _shippedDate;

        partial void ShippedDateChanging(Nullable<global::System.DateTime> newValue);
        partial void ShippedDateChanged(Nullable<global::System.DateTime> previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [ForeignKeyProperty]
        [SimpleProperty]
        public Nullable<global::System.Int32> ShipVia
        {
            get { return _shipVia; }
            set
            {
                if (_shipVia != value)
                {
                    ShipViaChanging(value);
                    OnPropertyChanging("ShipVia", value);
                    if (!IsDeserializing)
                    {
                        if (Shipper != null && Shipper.ShipperID != value)
                        {
                            Shipper = null;
                        }
                    }
                    var previousValue = _shipVia;
                    _shipVia = value;
                    OnPropertyChanged("ShipVia", previousValue, value);
                    ShipViaChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.Int32> _shipVia;

        partial void ShipViaChanging(Nullable<global::System.Int32> newValue);
        partial void ShipViaChanged(Nullable<global::System.Int32> previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public Nullable<global::System.Decimal> Freight
        {
            get { return _freight; }
            set
            {
                if (_freight != value)
                {
                    FreightChanging(value);
                    OnPropertyChanging("Freight", value);
                    var previousValue = _freight;
                    _freight = value;
                    OnPropertyChanged("Freight", previousValue, value);
                    FreightChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.Decimal> _freight;

        partial void FreightChanging(Nullable<global::System.Decimal> newValue);
        partial void FreightChanged(Nullable<global::System.Decimal> previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String ShipName
        {
            get { return _shipName; }
            set
            {
                if (_shipName != value)
                {
                    ShipNameChanging(value);
                    OnPropertyChanging("ShipName", value);
                    var previousValue = _shipName;
                    _shipName = value;
                    OnPropertyChanged("ShipName", previousValue, value);
                    ShipNameChanged(previousValue);
                }
            }
        }
        private global::System.String _shipName;

        partial void ShipNameChanging(global::System.String newValue);
        partial void ShipNameChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String ShipAddress
        {
            get { return _shipAddress; }
            set
            {
                if (_shipAddress != value)
                {
                    ShipAddressChanging(value);
                    OnPropertyChanging("ShipAddress", value);
                    var previousValue = _shipAddress;
                    _shipAddress = value;
                    OnPropertyChanged("ShipAddress", previousValue, value);
                    ShipAddressChanged(previousValue);
                }
            }
        }
        private global::System.String _shipAddress;

        partial void ShipAddressChanging(global::System.String newValue);
        partial void ShipAddressChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String ShipCity
        {
            get { return _shipCity; }
            set
            {
                if (_shipCity != value)
                {
                    ShipCityChanging(value);
                    OnPropertyChanging("ShipCity", value);
                    var previousValue = _shipCity;
                    _shipCity = value;
                    OnPropertyChanged("ShipCity", previousValue, value);
                    ShipCityChanged(previousValue);
                }
            }
        }
        private global::System.String _shipCity;

        partial void ShipCityChanging(global::System.String newValue);
        partial void ShipCityChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String ShipRegion
        {
            get { return _shipRegion; }
            set
            {
                if (_shipRegion != value)
                {
                    ShipRegionChanging(value);
                    OnPropertyChanging("ShipRegion", value);
                    var previousValue = _shipRegion;
                    _shipRegion = value;
                    OnPropertyChanged("ShipRegion", previousValue, value);
                    ShipRegionChanged(previousValue);
                }
            }
        }
        private global::System.String _shipRegion;

        partial void ShipRegionChanging(global::System.String newValue);
        partial void ShipRegionChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String ShipPostalCode
        {
            get { return _shipPostalCode; }
            set
            {
                if (_shipPostalCode != value)
                {
                    ShipPostalCodeChanging(value);
                    OnPropertyChanging("ShipPostalCode", value);
                    var previousValue = _shipPostalCode;
                    _shipPostalCode = value;
                    OnPropertyChanged("ShipPostalCode", previousValue, value);
                    ShipPostalCodeChanged(previousValue);
                }
            }
        }
        private global::System.String _shipPostalCode;

        partial void ShipPostalCodeChanging(global::System.String newValue);
        partial void ShipPostalCodeChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String ShipCountry
        {
            get { return _shipCountry; }
            set
            {
                if (_shipCountry != value)
                {
                    ShipCountryChanging(value);
                    OnPropertyChanging("ShipCountry", value);
                    var previousValue = _shipCountry;
                    _shipCountry = value;
                    OnPropertyChanged("ShipCountry", previousValue, value);
                    ShipCountryChanged(previousValue);
                }
            }
        }
        private global::System.String _shipCountry;

        partial void ShipCountryChanging(global::System.String newValue);
        partial void ShipCountryChanged(global::System.String previousValue);

        #endregion Simple Properties

        #region Complex Properties

        #endregion Complex Properties

        #region Navigation Properties

        [DataMember]
        [NavigationProperty]
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (!ReferenceEquals(_customer, value))
                {
                    CustomerChanging(value);
                    OnPropertyChanging("Customer", value);
                    var previousValue = _customer;
                    _customer = value;
                    FixupCustomer(previousValue);
                    OnPropertyChanged("Customer", previousValue, value, isNavigationProperty: true);
                    CustomerChanged(previousValue);
                }
            }
        }
        private Customer _customer;

        partial void CustomerChanging(Customer newValue);
        partial void CustomerChanged(Customer previousValue);

        [DataMember]
        [NavigationProperty]
        public Employee Employee
        {
            get { return _employee; }
            set
            {
                if (!ReferenceEquals(_employee, value))
                {
                    EmployeeChanging(value);
                    OnPropertyChanging("Employee", value);
                    var previousValue = _employee;
                    _employee = value;
                    FixupEmployee(previousValue);
                    OnPropertyChanged("Employee", previousValue, value, isNavigationProperty: true);
                    EmployeeChanged(previousValue);
                }
            }
        }
        private Employee _employee;

        partial void EmployeeChanging(Employee newValue);
        partial void EmployeeChanged(Employee previousValue);

        [DataMember]
        [NavigationProperty]
        public TrackableCollection<Order_Detail> Order_Details
        {
            get
            {
                if (_order_Details == null)
                {
                    _order_Details = new TrackableCollection<Order_Detail>();
                    _order_Details.CollectionChanged += FixupOrder_Details;
                }
                return _order_Details;
            }
            set
            {
                if (!ReferenceEquals(_order_Details, value))
                {
                    if (!IsDeserializing && ChangeTracker.IsChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }

                    if (_order_Details != null)
                    {
                       _order_Details.CollectionChanged -= FixupOrder_Details;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (Order_Detail item in _order_Details)
                        {
                            ChangeTracker.PropertyChanged -= item.HandleCascadeDelete;
                        }
                    }

                    _order_Details = value;

                    if (_order_Details != null)
                    {
                        _order_Details.CollectionChanged += FixupOrder_Details;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (Order_Detail item in _order_Details)
                        {
                            ChangeTracker.PropertyChanged += item.HandleCascadeDelete;
                        }
                    }

                    OnPropertyChanged("Order_Details", trackInChangeTracker: false);
                }
            }
        }
        private TrackableCollection<Order_Detail> _order_Details;

        [DataMember]
        [NavigationProperty]
        public Shipper Shipper
        {
            get { return _shipper; }
            set
            {
                if (!ReferenceEquals(_shipper, value))
                {
                    ShipperChanging(value);
                    OnPropertyChanging("Shipper", value);
                    var previousValue = _shipper;
                    _shipper = value;
                    FixupShipper(previousValue);
                    OnPropertyChanged("Shipper", previousValue, value, isNavigationProperty: true);
                    ShipperChanged(previousValue);
                }
            }
        }
        private Shipper _shipper;

        partial void ShipperChanging(Shipper newValue);
        partial void ShipperChanged(Shipper previousValue);

        #endregion Navigation Properties

        #region ChangeTracking

        protected override void ClearNavigationProperties()
        {
            Customer = null;
            Employee = null;
            Order_Details.Clear();
            Shipper = null;
        }

        #endregion ChangeTracking

        #region Association Fixup

        private void FixupCustomer(Customer previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }

            if (previousValue != null && previousValue.Orders.Contains(this))
            {
                previousValue.Orders.Remove(this);
            }

            if (Customer != null)
            {
                if (!Customer.Orders.Contains(this))
                {
                    Customer.Orders.Add(this);
                }

                CustomerID = Customer.CustomerID;
            }
            else if (!skipKeys)
            {
                CustomerID = null;
            }

            if (ChangeTracker.IsChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Customer")
                    && ReferenceEquals(ChangeTracker.OriginalValues["Customer"], Customer))
                {
                    //ChangeTracker.OriginalValues.Remove("Customer");
                }
                else
                {
                    //RecordOriginalValue("Customer", previousValue);
                }
                if (Customer != null && !Customer.ChangeTracker.IsChangeTrackingEnabled)
                {
                    Customer.StartTracking();
                }
            }
        }

        private void FixupEmployee(Employee previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }

            if (previousValue != null && previousValue.Orders.Contains(this))
            {
                previousValue.Orders.Remove(this);
            }

            if (Employee != null)
            {
                if (!Employee.Orders.Contains(this))
                {
                    Employee.Orders.Add(this);
                }

                EmployeeID = Employee.EmployeeID;
            }
            else if (!skipKeys)
            {
                EmployeeID = null;
            }

            if (ChangeTracker.IsChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Employee")
                    && ReferenceEquals(ChangeTracker.OriginalValues["Employee"], Employee))
                {
                    //ChangeTracker.OriginalValues.Remove("Employee");
                }
                else
                {
                    //RecordOriginalValue("Employee", previousValue);
                }
                if (Employee != null && !Employee.ChangeTracker.IsChangeTrackingEnabled)
                {
                    Employee.StartTracking();
                }
            }
        }

        private void FixupShipper(Shipper previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }

            if (previousValue != null && previousValue.Orders.Contains(this))
            {
                previousValue.Orders.Remove(this);
            }

            if (Shipper != null)
            {
                if (!Shipper.Orders.Contains(this))
                {
                    Shipper.Orders.Add(this);
                }

                ShipVia = Shipper.ShipperID;
            }
            else if (!skipKeys)
            {
                ShipVia = null;
            }

            if (ChangeTracker.IsChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Shipper")
                    && ReferenceEquals(ChangeTracker.OriginalValues["Shipper"], Shipper))
                {
                    //ChangeTracker.OriginalValues.Remove("Shipper");
                }
                else
                {
                    //RecordOriginalValue("Shipper", previousValue);
                }
                if (Shipper != null && !Shipper.ChangeTracker.IsChangeTrackingEnabled)
                {
                    Shipper.StartTracking();
                }
            }
        }

        private void FixupOrder_Details(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }

            if (e.NewItems != null)
            {
                foreach (Order_Detail item in e.NewItems)
                {
                    item.Order = this;
                    if (ChangeTracker.IsChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.IsChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        RecordAdditionToCollectionProperties("Order_Details", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.PropertyChanged += item.HandleCascadeDelete;
                }
            }

            if (e.OldItems != null)
            {
                foreach (Order_Detail item in e.OldItems)
                {
                    if (ReferenceEquals(item.Order, this))
                    {
                        item.Order = null;
                    }
                    if (ChangeTracker.IsChangeTrackingEnabled)
                    {
                        RecordRemovalFromCollectionProperties("Order_Details", item);
                    // Delete the dependent end of this identifying association. If the current state is Added,
                    // allow the relationship to be changed without causing the dependent to be deleted.
                    if (item.ChangeTracker.State != ObjectState.Added)
                    {
                        item.MarkAsDeleted();
                    }
                    }
                // This is the principal end in an association that performs cascade deletes.
                // Remove the previous dependent from the event listener.
                ChangeTracker.PropertyChanged -= item.HandleCascadeDelete;
                }
            }
        }

        #endregion Association Fixup

        protected override bool IsKeyEqual(Entity other)
        {
            var entity = other as Order;
            if (ReferenceEquals(null, entity)) return false;
            return this.OrderID == entity.OrderID;
        }

        protected override int GetKeyHashCode()
        {
            return this.OrderID.GetHashCode();
        }
    }
}
