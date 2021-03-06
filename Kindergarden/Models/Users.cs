//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kindergarden.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        [DisplayName("Ad : ")]
        [Required(ErrorMessage = "Bu alan� bo� b�rakamazs�n�z.")]

        public string Ad { get; set; }

        [DisplayName("Soyad : ")]
        [Required(ErrorMessage = "Bu alan� bo� b�rakamazs�n�z.")]

        public string Soyad { get; set; }

        [DisplayName("E-mail : ")]
        [Required(ErrorMessage = "Bu alan� bo� b�rakamazs�n�z.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ge�erli bir e-mail adresi giriniz.")]
        public string Email { get; set; }

        [DisplayName("�ifre : ")]
        [Required(ErrorMessage = "Bu alan� bo� b�rakamazs�n�z.")]

        public string Sifre { get; set; }

        [DisplayName("Telefon : ")]
        [Required(ErrorMessage = "Bu alan� bo� b�rakamazs�n�z.")]

        public string Tel { get; set; }

        [DisplayName("�ocu�unuzun ad� : ")]
        public string CocukAdi { get; set; }

        [DisplayName("��retmen misiniz? : ")]
        [Required(ErrorMessage = "Bu alan� bo� b�rakamazs�n�z.")]

        public string Admin { get; set; }
    }
}
