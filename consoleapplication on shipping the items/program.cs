using System;
using System.Collections.Generic;

namespace Shopping3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Iproductmodel> cart = Addsampledata();
            Customermodel customer = getcustomer();
            foreach (Iproductmodel prod in cart)
            {
                prod.shipitem(customer);

                if(prod is IDigitalproductmodel  digital){
                    Console.WriteLine($"{digital.Title} for you {digital.downloadsleft}");

                }
            }
        }
            private static Customermodel getcustomer()
            {
                return new Customermodel
                {
                    Firstname = "pravalika",
                    Lastname = "thatikonda",
                    city = "godavarikhani",
                    emailadress = "pravalika@gmail.com",
                     phonenumber = " 578787897987",



                };
            }
           private static List<Iproductmodel> Addsampledata()
            {
                List<Iproductmodel> output = new List<Iproductmodel>();
                output.Add(new Physicalproductmodel { Title = "bag" });
                output.Add(new Physicalproductmodel { Title = "t-shirt" });
                output.Add(new Physicalproductmodel { Title = "mobile" });
                output.Add(new Digitalproductmodel { Title = "basket" });
                 output.Add(new Couseproductmodel { Title = ".netcore" });
                return output;
            }
        }
