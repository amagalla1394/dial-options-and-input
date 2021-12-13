using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProj
{
    class Telephone
    {
        //Fields for Telephone
        private string manufacturer;
        private string model;
        private bool isConnected = false;
        private string phoneNumber;
        private string lastNumberDialed;

        //Constructor
        public Telephone()
        {

        }

        //default constructor
        public Telephone(string maker, string phoneModel, string number)
        {
            manufacturer = maker;
            model = phoneModel;
            number = phoneNumber;
        }

        //Get and set the properties
        public string getManufaturer()
        {
            return manufacturer;
        }

        public void setManufacturer(string maker)
        {
            manufacturer = maker;
        }

        public string getModel()
        {
            return model;
        }

        public void setModel(string phoneModel)
        {
            model = phoneModel;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(string number)
        {
            phoneNumber = number;
        }

        public string getLastNumberDialed()
        {
            return lastNumberDialed;
        }

        public void setLastNumberDialed(string lastDialed)
        {
            lastNumberDialed = lastDialed;
        }

        //Parent display for phone class
        public virtual void display()
        {
            System.Console.WriteLine("Manufacturer: {0}", manufacturer);
            System.Console.WriteLine("Model: {0}", model);
            System.Console.WriteLine("Phone Number: {0}", phoneNumber);
        }

        //dial method
        public void dial(string phoneNumber, string lastNumberDialed)
        {
            System.Console.WriteLine("Connecting to {0} from {1}...", lastNumberDialed, phoneNumber);
            System.Console.WriteLine("Connected.");
            //set isConnected to true once connection is made
            isConnected = true;
        }

        public void hangUp()
        {
            System.Console.WriteLine("Disconnected.");
            //set is connected to false
            isConnected = false;
        }

        //redial
        public void redial(string phoneNumber, string lastNumberDialed)
        {
            System.Console.WriteLine("Re-connecting to {0} from {1}", lastNumberDialed, phoneNumber);
            //tell the user to hang up if they are still connected
            if (isConnected == true)
            {
                System.Console.WriteLine("You are still connected. Please hang up first.");
            }
            else
            {
                System.Console.WriteLine("Connected.");
                isConnected = true;
            }
        }
    }

    //subclass for Telephone
    class LandLinePhone : Telephone
    {
        private bool hasCord;

        //constructor
        public LandLinePhone()
        {

        }

        //default constructor 
        public LandLinePhone(string maker, string phoneModel, string phoneNumber, bool havingCord)
            //use the fields from base class
            : base(maker, phoneModel, phoneNumber)
        {
            hasCord = havingCord;
        }

        //get and set properties 
        public bool getHasCord()
        {
            return hasCord;
        }

        public void setHasCord(bool havingCord)
        {
            hasCord = havingCord;
        }

        //overide display for the subclass
        public override void display()
        {
            base.display();
            System.Console.WriteLine("Cordless: {0}", hasCord);
        }
    }

    class CellularPhone : Telephone
    {
        private string technology;
        private bool hasCamera;
        private string message;
        CallerId callerId = new CallerId();

        public CellularPhone()
        {

        }

        public CellularPhone(string maker, string phoneModel, string number, string tech, bool camera, string textMessage, CallerId cId)
            //use the fields from base class
            : base(maker, phoneModel, number)
        {
            technology = tech;
            hasCamera = camera;
            message = textMessage;
            callerId = cId;
        }

        public string getTechnology()
        {
            return technology;
        }

        public void setTechnology(string tech)
        {
            technology = tech;
        }

        public bool getHasCamera()
        {
            return hasCamera;
        }

        public void setHasCamera(bool camera)
        {
            hasCamera = camera;
        }

        public string getMessage()
        {
            return message;
        }

        public void setMessage(string textMessage)
        {
            message = textMessage;
        }

        public CallerId getCallerId()
        {
            return callerId;
        }

        public void setCallerId()
        {
            Console.Write("Enter the Person's Name in the Caller Id: ");
            callerId.setCallerName(Console.ReadLine());
            Console.Write("Enter the Phone # in the Caller Id: ");
            callerId.setCallerPhoneNumber(Console.ReadLine());
        }

        public void sendTextMessage(string textMessage, string numberSentTo)
        {
            Console.WriteLine("Sending the following message to "+numberSentTo+"...");
            Console.WriteLine(textMessage);
        }

        public override void display()
        {
            base.display();
            System.Console.WriteLine("Technology: {0}", technology);
            System.Console.WriteLine("Camera: {0}", hasCamera);
            System.Console.WriteLine("{0}", callerId.ToString(callerId.getCallerPhoneNumber(),callerId.getCallerName()));
        }
    }

    class CallerId
    {
        private string callerName;
        private string callerPhoneNumber;

        public CallerId()
        {

        }

        public CallerId(string cName, string cPhoneNumber)
        {
            callerName = cName;
            callerPhoneNumber = cPhoneNumber;
        }

        public string getCallerName()
        {
            return callerName;
        }
        
        public void setCallerName(string cName)
        {
            callerName = cName;
        }

        public string getCallerPhoneNumber()
        {
            return callerPhoneNumber;
        }

        public void setCallerPhoneNumber(string cPhoneNumber)
        {
            callerPhoneNumber = cPhoneNumber;
        }

        public string ToString(string number, string name)
        {
            return ("Caller ID: " + name + ": " + number);
        }
    }
}
