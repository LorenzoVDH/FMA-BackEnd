using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.Views.Models;
public class ExpandableViewItem : INotifyPropertyChanged {
    private object _item;
    public object Item {
        get => _item;
        set {
            if (value != _item) {
                _item = value;
                OnPropertyChanged();
            }
        }
    }

    private bool _isExpanded; 
    public bool IsExpanded {
        get => _isExpanded; 
        set {
            if (value != _isExpanded) {
                _isExpanded = value;
                OnPropertyChanged(); 
            }
        }
    } 

    public ExpandableViewItem(object item, bool isExpanded = false) {
        Item = item;
        IsExpanded = isExpanded; 
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
