using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_1
{
   public class Bike
   {
      int idBike;
      string mark;
      string name;

      string gender;
      string color;

      int wheelSize;
      int frameSize;

      string frameMaterial;
      string brakesType;
      int weight;

      int manufacturerId;

      DateTime lastModified;
      string user;

      public int GetIdBike() => idBike;
      public string GetMark() => mark;
      public string GetName() => name;
      public string GetGender() => gender;
      public string GetColor() => color;
      public int GetWheelSize() => wheelSize;
      public int GetFrameSize() => frameSize;
      public string GetFrameMaterial() => frameMaterial;
      public string GetBrakesType() => brakesType;
      public int GetWeight() => weight;
      public int GetManufacturerId() => manufacturerId;
      public DateTime GetLastModified() => lastModified;
      public string GetUser() => user;

      public Bike SetIdBike(int _value, string _user)
      {
         if (_value >= 0)
         {
            idBike = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetMark(string _value, string _user)
      {
         if (!string.IsNullOrEmpty(_value))
         {
            mark = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetName(string _value, string _user)
      {
         if (!string.IsNullOrEmpty(_value))
         { 
            name = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetGender(string _value, string _user)
      {
         if (_value == "Male" || _value == "Female")
            gender = _value;
         return this;
      }

      public Bike SetColor(string _value, string _user)
      {
         if (!string.IsNullOrEmpty(_value))
         { 
            color = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetWheelSize(int _value, string _user)
      {
         if (_value >= 10)
         {
            wheelSize = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetFrameSize(int _value, string _user)
      {
         if (_value >= 8)
         {
            frameSize = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetFrameMaterial(string _value, string _user)
      {
         if (!string.IsNullOrEmpty(_value))
         {
            frameMaterial = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetBrakesType(string _value, string _user)
      {
         if(!string.IsNullOrEmpty(_value))
         {
            brakesType = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetWeight(int _value, string _user)
      {
         if (_value >= 5000)
         {
            weight = _value;
            SetUser(_user);
         }
         return this;
      }

      public Bike SetManufacturerId(int _value, string _user)
      {
         if (_value >= 0)
         {
            manufacturerId = _value;
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
         if(!string.IsNullOrEmpty(_value))
         {
            user = _value;
            SetLastModified();
         }
      }
   }
}
