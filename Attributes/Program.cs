using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Attributes
{

    class Program
    {
        static void Main(string[]args)
        {
            MyUIClass
        }
    }
    public class MyUIClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler propertychanged;

        public void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            propertychanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if(value != _name)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }
    
        
    }
    public class MyClass : Attribute
    {
    }

    public class SomeOtherClass
    {
    }

    public class AttributeFile
    {
    }
}
