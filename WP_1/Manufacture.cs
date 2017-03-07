using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_1
{
   public class Manufacture
   {
      int idManufacture;
      string name;

      DateTime lastModified;
      string user;

      public int GetIdManufacture() => idManufacture;
      public string GetName() => name;

      public Manufacture SetIdManufacture(int _value, string _user)
      {
         if (_value >= 0)
         {
            idManufacture = _value;
            SetUser(_user);
         }
         return this;
      }

      public Manufacture SetName(string _value, string _user)
      {
         if (!string.IsNullOrEmpty(_value))
         {
            name = _value;
            SetUser(_user);
         }
         return this;
      }

      void SetLastModified()
      {
         lastModified = DateTime.Now;
      }

      void SetUser(string _value)
      {
         if (!string.IsNullOrEmpty(_value))
         {
            user = _value;
            SetLastModified();
         }
      }
   }
}
