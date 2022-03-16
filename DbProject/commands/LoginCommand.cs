using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.commands
{
    class LoginCommand : CommandBase
    {
        public LoginCommand()
        {
        }

        public override bool CanExecute(object parameter) 
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
