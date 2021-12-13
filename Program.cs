using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProj
{
    class Program
    {
        static void Main(string[] args)
        {
            char bCamera = ' ';
            //Create an object called myPhone
            CellularPhone myPhone = new CellularPhone();
            LandLinePhone homePhone = new LandLinePhone();
            homePhone.setManufacturer("VTech");
            homePhone.setModel("V-4321");
            homePhone.setPhoneNumber("219-999-2345");
            homePhone.setHasCord(true);

            //Gather user input for the specifics of the myPhone object
            Console.Write("Enter the Cell Phone Manufacturer: ");
            myPhone.setManufacturer(Console.ReadLine());

            Console.Write("Enter the Cell Phone Model: ");
            myPhone.setModel(Console.ReadLine());

            Console.Write("Enter the Cell Phone Technology: ");
            myPhone.setTechnology(Console.ReadLine());

            Console.Write("Does it have a Built-in Camera? [Y or N]: ");
            bCamera = Convert.ToChar(Console.ReadLine().ToUpper());
            myPhone.setHasCamera((bCamera != 'Y' ? false : true));

            Console.Write("Enter the Phone Number of your Cell Phone: ");
            myPhone.setPhoneNumber(Console.ReadLine());

            myPhone.setCallerId();


            Console.Write("Enter the short text message you wish to send: ");
            myPhone.setMessage(Console.ReadLine());

            Console.Write("Enter the Number you wish to send the text message: ");
            myPhone.setLastNumberDialed(Console.ReadLine());


            Console.WriteLine("");
            //Run  through myPhone object and methods
            Console.WriteLine("===MY CELLPHONE===");
            myPhone.display();
            Console.WriteLine("");
            myPhone.sendTextMessage(myPhone.getMessage(),myPhone.getLastNumberDialed());
            
            Console.WriteLine("");

            Console.WriteLine("===yourHomePhone===");

            Console.Write("Enter the Number you wish to call from the landline: ");
            homePhone.setLastNumberDialed(Console.ReadLine());
            homePhone.display();
            Console.WriteLine("");
            homePhone.dial(homePhone.getPhoneNumber(), homePhone.getLastNumberDialed());
            homePhone.redial(homePhone.getLastNumberDialed(), homePhone.getPhoneNumber());
            homePhone.hangUp();
        }
    }
}
