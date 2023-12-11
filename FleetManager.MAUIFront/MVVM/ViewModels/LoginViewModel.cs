using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FleetManager.MAUIFront.MVVM.ViewModels;
public class LoginViewModel {
    public ICommand LoginCommand => new Command(ExecuteLogin);
    public LoginViewModel() {
        
    }

    private void ExecuteLogin() {
        
    }
}
