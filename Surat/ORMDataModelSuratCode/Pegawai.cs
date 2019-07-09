using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DbSurat
{

    public partial class Pegawai
    {
        public Pegawai(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
