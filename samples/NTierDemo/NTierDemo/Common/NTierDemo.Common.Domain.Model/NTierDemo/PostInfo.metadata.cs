﻿//------------------------------------------------------------------------------
// <initially_autogenerated>
//   This file was originally generated by T4 code generator NTierDemoModel_NTierEntityGenerator.tt.
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

namespace NTierDemo.Common.Domain.Model.NTierDemo
{
    [MetadataType(typeof(PostInfoMetadata))]
    partial class PostInfo
    {
    }

    // This class allows you to attach custom attributes to properties of the PostInfo class.
    //
    // For example, the following marks the Xyz property as a
    // required property and specifies the format for valid values:
    //    [Required]
    //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
    //    [StringLength(32)]
    //    string Xyz;
    public sealed class PostInfoMetadata
    {
        // this class is not meant to be instantiated by client code
        private PostInfoMetadata() { }

#pragma warning disable 0169

        #region Simple Properties

        public global::System.Int64 Id;

        public global::System.Int64 BlogId;

        public global::System.Int64 Title;

        public global::System.Int64 Abstract;

        public global::System.String Content;

        public global::System.DateTime CreatedDate;

        public global::System.DateTime ModifiedDate;

        #endregion Simple Properties

        #region Complex Properties

        #endregion Complex Properties

        #region Navigation Properties

        #endregion Navigation Properties

#pragma warning restore 0169
    }
}