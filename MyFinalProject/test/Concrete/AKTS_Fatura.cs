//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.Concrete
{
    using System;
    using System.Collections.Generic;
    
    public partial class AKTS_Fatura
    {
        public byte Fis_Durum { get; set; }
        public int Fis_No { get; set; }
        public short Fis_Sira { get; set; }
        public Nullable<byte> SatisTipi { get; set; }
        public Nullable<short> SatisYili { get; set; }
        public Nullable<short> SatisAyi { get; set; }
        public Nullable<int> SatisNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public string FaturaNo { get; set; }
        public Nullable<System.DateTime> FatTarihi { get; set; }
        public string SatCinsi { get; set; }
        public Nullable<double> SatMiktar { get; set; }
        public Nullable<double> SatFiyat { get; set; }
        public Nullable<double> SatTutar { get; set; }
        public Nullable<double> FatToplam { get; set; }
        public Nullable<double> FatKdv { get; set; }
        public Nullable<double> FatNet { get; set; }
        public string Aciklama { get; set; }
        public string Acilis_User { get; set; }
        public string Update_User { get; set; }
        public string Iptal_User { get; set; }
        public Nullable<System.DateTime> Acilis_Zaman { get; set; }
        public Nullable<System.DateTime> Update_Zaman { get; set; }
        public Nullable<System.DateTime> Iptal_Zaman { get; set; }
    }
}