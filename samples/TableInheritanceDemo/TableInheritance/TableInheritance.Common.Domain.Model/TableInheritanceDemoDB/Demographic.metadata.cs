﻿//------------------------------------------------------------------------------
// <initially_autogenerated>
//   This file was originally generated by T4 code generator Model2.tt.
//   This file is meant to be edited manually and modifications do not get lost on regeneration.
//   In case you want this file to be deleted or regenerated you have to remove (e.g. delete or rename) the existing version manually.
// </initially_autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using NTier.Common.Domain.Model;

namespace TableInheritance.Common.Domain.Model.TableInheritanceDemoDB
{
    [MetadataType(typeof(DemographicMetadata))]
    partial class Demographic
    {
    }

    // This class allows you to attach custom attributes to properties of the Demographic class.
    //
    // For example, the following marks the Xyz property as a
    // required property and specifies the format for valid values:
    //    [Required]
    //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
    //    [StringLength(32)]
    //    string Xyz;
    public sealed class DemographicMetadata
    {
        // this class is not meant to be instantiated by client code
        private DemographicMetadata() { }

#pragma warning disable 0169

        #region Simple Properties

        public global::System.Int64 Id;

        public global::System.String Key;

        public global::System.String Value;

        #endregion Simple Properties

        #region Complex Properties

        #endregion Complex Properties

        #region Navigation Properties

        public Customer Customer;

        public TrackableCollection<Customer> Customers;

        #endregion Navigation Properties

#pragma warning restore 0169
    }
}