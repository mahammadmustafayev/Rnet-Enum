using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnumDisplay.Models
{
    public enum Status:byte
    {
        None=0,
        [Display(Name ="Aktif Kullanicilar Listeler")]
        Active=1,
        [Display(Name = "Passive Kullanicilar Listeler")]
        Passive =2,
        [Display(Name = "Deleted Kullanicilar Listeler")]
        Deleted =3,
        [Display(Name = "Holiday Kullanicilar Listeler")]
        Holiday
    }
    public class Customer
    {
        public Status Status { get; set; }
        public void GetDisplayName()
        {
            var properties=typeof(Status).GetFields();
            foreach (var pp in properties)
            {
                var da=pp.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute ;
                if (da!=null)
                {
                    Console.WriteLine(pp.Name+" -> "+da.Name);
                }
            }
        }
    }
}
