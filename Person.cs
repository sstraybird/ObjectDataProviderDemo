using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataProviderDemo
{
    class Person : INotifyPropertyChanged
    {
        public Person(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
