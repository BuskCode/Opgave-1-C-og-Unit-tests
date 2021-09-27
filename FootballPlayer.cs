using System;

namespace OblOpgave1
{
    public class FootballPlayer
    {   
        private string _name;
        private int _price; 
        private int _shirtNumber;
        

        public int Id { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <=4)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

                
            }
            
        }

        //public override string ToString()
        //{
        //    return Id + " " + Name
        //}
        public int Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if(value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                
            }
        }
       
        public int ShirtNumber
        {
            get
            {
                return _shirtNumber;
            }
            set
            {
                if(1 <= value && value <= 100)
                {
                    _shirtNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public FootballPlayer(string name, int price, int shirtNumber)
        {
            _name = name;
            _price = price;
            _shirtNumber = shirtNumber;
        }

    }
}
