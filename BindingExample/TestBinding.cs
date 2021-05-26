using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample
{
    class TestBinding : INotifyPropertyChanged
    {
        //3
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
        private string testProp = "hjk";
        public string TestProp
        {
            get { return testProp; }
            set
            {
                testProp = value;
                OnPropertyChanged(new PropertyChangedEventArgs("TestProp"));
            }
        }
    }

}
