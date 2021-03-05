using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BMI.classes
{
    public class types : INotifyPropertyChanged
    {
        public List<mtype> mtypeList { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        
        
        protected void OnpropertyChanged([CallerMemberName] string name=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }

        private mtype _selectedType{ get; set; }
        public mtype selectedType
        {
            get { return _selectedType; }
            set 
            {
                if (_selectedType != value)
                {
                    _selectedType = value;
                    if (_selectedType.value == "Metric")
                    {
                        myType ="Kg, Cm";
                        kg = "Kg";
                        cm = "Cm";
                    }
                    else if(_selectedType.value=="Standart")
                    {
                        myType = "Pound, Feet";
                        kg = "Pound";
                        cm = "Feet";
                    }else if (_selectedType.value=="None")
                    {
                        kg = null;
                        cm = null;

                    }
                }
            }
        }

        private string _kg { get; set; }
        public string kg
        {
            get { return _kg; }
            set
            {
                if (_kg != value)
                    _kg = value;
                OnpropertyChanged();
            }
        }
        private string _cm { get; set; }
        public string cm
        {
            get { return _cm; }
            set
            {
                if (_cm != value)
                    _cm = value;
                OnpropertyChanged();
            }
        }

        private string _myType;
        public string myType
        {
            get { return _myType; }
            set
            {
                if (_myType != value)
                    _myType = value;
                OnpropertyChanged();
            }
        }





        public types()
        {
            mtypeList = GetMtypes().OrderBy(t => t.value).ToList();
        }
        public List<mtype> GetMtypes()
        {
            var types = new List<mtype>()
            {
                new mtype(){key =1,value="Metric"},
                new mtype(){key =2, value="Standart"},
                new mtype(){key =2, value="None"}



            };
            return types;
        }
    }
    public class mtype
    {
        public int key { get; set; }
        public string value { get; set; }
    }
    
}
