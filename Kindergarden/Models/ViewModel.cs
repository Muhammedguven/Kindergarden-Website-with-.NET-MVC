using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kindergarden.Models
{
    public class ViewModel
    {
            public IEnumerable<Users> Kullanicilar { get; set; }
            public IEnumerable<Cocuk> Cocuklar { get; set; }
        }
    }