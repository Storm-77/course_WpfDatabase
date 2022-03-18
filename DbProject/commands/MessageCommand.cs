using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DbProject.commands
{
    class MessageCommand : CommandBase
    {
        public readonly string m_message;

        public MessageCommand(string message)
        {
            m_message = message;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override void Execute(object parameter)
        {
            MessageBox.Show(m_message, "yo",MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
