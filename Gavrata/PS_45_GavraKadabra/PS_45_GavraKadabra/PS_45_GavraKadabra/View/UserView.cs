using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class UserView
    {
    private UserViewModel _viewModel ;

    public UserView(UserViewModel viewModel )
    {
        _viewModel = viewModel;
    }

    public void Display() {
        Console.WriteLine("Welcome\r\n" +
            "User:" + _viewModel.Name +
            "\r\nRole: " + _viewModel.Role);
    }

}

