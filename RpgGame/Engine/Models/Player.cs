using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{

    public class Player : INotifyPropertyChanged
    {
        private string _Name;
        private int _Strength;
        private int _Stamina;
        private int _Dexterity;
        private int _Intelligence;
        private int _Exp;
        private int _Gold;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }

        }

        public int Strength
        {
            get
            {
                return _Strength;
            }
            set
            {
                _Strength = value;
                OnPropertyChanged(nameof(Strength));
            }

        }

        public int Stamina
        {
            get
            {
                return _Stamina;
            }
            set
            {
                _Stamina = value;
                OnPropertyChanged(nameof(Stamina));
            }

        }


        public int Dexterity
        {
            get
            {
                return _Dexterity;
            }
            set
            {
                _Dexterity = value;
                OnPropertyChanged(nameof(Dexterity));
            }

        }

        public int Intelligence
        {
            get
            {
                return _Intelligence;
            }
            set
            {
                _Intelligence = value;
                OnPropertyChanged(nameof(Intelligence));
            }

        }

        public int Level
        {
            get
            {
                return _Stamina;
            }
            set
            {
                _Stamina = value;
                OnPropertyChanged(nameof(Stamina));
            }

        }

        public int Exp
        {
            get
            {
                return _Exp;
            }
            set
            {
                _Exp = value;
                OnPropertyChanged(nameof(Exp));
            }

        }

        public int Gold
        {
            get
            {
                return _Gold;
            }
            set
            {
                _Gold = value;
                OnPropertyChanged(nameof(Gold));
            }

        }



        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /*
        int Strength;
        int Stamina;
        int Dexterity;
        int Intelligence;

        int Level;
        int Exp;
        int Gold;
        */
    }
}
