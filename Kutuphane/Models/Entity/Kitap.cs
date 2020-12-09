//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitap()
        {
            this.EmanetKitaplar = new HashSet<EmanetKitaplar>();
            this.KitapKategorileri = new HashSet<KitapKategorileri>();
            this.KitapYazarlari = new HashSet<KitapYazarlari>();
        }
    
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string Adi { get; set; }
        public Nullable<int> YazarId { get; set; }
        public string Cevirmen { get; set; }
        public Nullable<int> YayinEviId { get; set; }
        public Nullable<int> Sayfa { get; set; }
        public string IlkBasimYili { get; set; }
        public string Ebat { get; set; }
        public string BasimSayisi { get; set; }
        public Nullable<int> DilId { get; set; }
        public string CiltTipi { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> StokAdedi { get; set; }
        public string DeweyKod { get; set; }
        public string YerNumarasi { get; set; }
    
        public virtual Dil Dil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmanetKitaplar> EmanetKitaplar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KitapKategorileri> KitapKategorileri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KitapYazarlari> KitapYazarlari { get; set; }
    }
}
