using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }

        public int ProductionYear
        {
            get
            {
                return _productionYear;
            }
            set
            {
                if ()
                _productionYear = value;
            }
        }

        public Engine Engine { get; set; }

        private string _mark; //prywatne zmienne z "_" na początku
        private string _model;
        private int _productionYear;


    }
}
