using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Engine.Models
{
    public class Location : INotifyPropertyChanged
    {
        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        private string _ImageName;
        public string ImageName //{ get; set; }
        {

            get
            {
                return _ImageName;
            }

            set
            {
                if (value != null)
                    _ImageName = value;

                OnPropertyChanged("ImageName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
