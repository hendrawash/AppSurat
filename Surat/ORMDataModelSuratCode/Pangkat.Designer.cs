﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DbSurat
{

    public partial class Pangkat : XPLiteObject
    {
        string fGolongan;
        [Indexed(Name = @"Golongan", Unique = true)]
        [Size(255)]
        public string Golongan
        {
            get { return fGolongan; }
            set { SetPropertyValue<string>(nameof(Golongan), ref fGolongan, value); }
        }
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fPangkatValue;
        [Indexed(Name = @"Pangkat", Unique = true)]
        [Size(255)]
        [Persistent(@"Pangkat")]
        public string PangkatValue
        {
            get { return fPangkatValue; }
            set { SetPropertyValue<string>(nameof(PangkatValue), ref fPangkatValue, value); }
        }
        [Association(@"PegawaiReferencesPangkat")]
        public XPCollection<Pegawai> Pegawais { get { return GetCollection<Pegawai>(nameof(Pegawais)); } }
    }

}
