using System;
using System.Collections.Generic;

namespace addressBook
{
 public class Contact
 {
        

        public Contact(){
    }

    public string FirstName{get; set;}

    public string LastName{get; set;}

     public string Email{get; set;}

      public string Address{get; set;}
      public string FullName(){
        return $"{FirstName} {LastName}";
      }
      
      }
 }
