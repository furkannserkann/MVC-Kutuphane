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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        public enum Yetkiler { Kullan�c� = 0, Personel = 0, Y�netici = 2 };


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.EmanetKitaplar = new HashSet<EmanetKitaplar>();
        }

        public int ID { get; set; }
        [DisplayName("TC NO")]
        [Required(ErrorMessage = "TC NO Giriniz")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TC NO 11 Haneli Olmal�d�r!")]
        [RegularExpression("[0-9]+", ErrorMessage = "Sadece Say� ��erebilir")]
        public string Tc { get; set; }
        [DisplayName("�S�M")]
        [Required(ErrorMessage = "�sim Giriniz")]
        [StringLength(50, ErrorMessage = "En Fazla 50 Karakter Olabilir")]
        [RegularExpression("[a-zA-Z������]+", ErrorMessage = "Sadece Harf ��erebilir")]
        public string Adi { get; set; }
        [DisplayName("SOY�S�M")]
        [Required(ErrorMessage = "Soyisim Giriniz")]
        [StringLength(50, ErrorMessage = "En Fazla 50 Karakter Olabilir")]
        [RegularExpression("[a-zA-Z������]+", ErrorMessage = "Sadece Harf ��erebilir")]
        public string Soyadi { get; set; }
        [DisplayName("DO�UM TAR�H�")]
        [Required(ErrorMessage = "DO�UM TAR�H� Giriniz")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        [DisplayName("DO�UM YER�")]
        public string DogumYeri { get; set; }
        [Required(ErrorMessage = "Telefon Numaras� Giriniz")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Telefon Numaras� 11 Haneli Olmal�")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[0-9]+", ErrorMessage = "Hatal� Telefon Numaras�")]
        [DisplayName("TELEFON")]
        public string Telefon { get; set; }
        [DisplayName("�YEL�K TAR�H�")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public Nullable<System.DateTime> UyelikTarihi { get; set; }
        [DisplayName("C�NS�YET")]
        public string Cinsiyet { get; set; }
        [DisplayName("ADRES")]
        [Required(ErrorMessage = "Adres Giriniz")]
        [StringLength(250, ErrorMessage = "En Fazla 250 Karakter Olabilir")]
        public string Adres { get; set; }
        [DisplayName("EMA�L")]
        [Required(ErrorMessage = "Email Giriniz")]
        [EmailAddress(ErrorMessage = "Hatal� Email Adresi")]
        [StringLength(100, ErrorMessage = "En Fazla 100 Karakter Olabilir")]
        public string Email { get; set; }
        [DisplayName("KULLANICI ADI")]
        [Required(ErrorMessage = "Kullan�c� Ad� Giriniz")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Uzunluk 6-50 Aras�nda Olmal�d�r")]
        [RegularExpression("[a-zA-Z������0-9]+", ErrorMessage = "Sadece Harf ve Say� ��erebilir")]
        public string Username { get; set; }
        [DisplayName("��FRE")]
        [Required(ErrorMessage = "�ifre Giriniz")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Uzunluk 6-50 Aras�nda Olmal�d�r")]
        [RegularExpression("[a-zA-Z������0-9.\"-]+", ErrorMessage = "Sadece Harf, Say� ve �zel Karakter [. \" -] ��erebilir")]
        public string Password { get; set; }
        [DisplayName("YETK�")]
        public Nullable<int> Yetki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmanetKitaplar> EmanetKitaplar { get; set; }
    }
}
