﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cours_CommandMVVM.MVVM
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string _propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propName));
        }
    }
}
