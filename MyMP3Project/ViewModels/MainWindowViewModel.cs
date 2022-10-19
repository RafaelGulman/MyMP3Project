using MyMP3Project.Models;
using MyMP3Project.ViewModels.Base;
using MyMP3Project.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using MyMP3Project.Infrastructure.Commands;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Linq;

namespace MyMP3Project.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Properties

        public ObservableCollection<Mp3Directory> Mp3Directories { get; set; }

        public Mp3Directory SelectedDirectory { get; set; }

        #endregion

        #region Commands

        #region CloseProgramCommand

        public ICommand CloseProgramCommand { get; }

        protected void OnCloseProgramCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }

        protected bool CanCloseProgramCommandExecute(object p) => true;

        #endregion

        #region OpenDirectoryCommand

        public ICommand OpenDirectoryCommand { get; }

        protected bool CanOpenDirectoryCommand(object p) => true;

        protected void OnOpenDirectoryCommand(object p)
        {

        }

        #endregion

        #region BackDirectoryCommand

        public ICommand BackDirectoryCommand { get; }

        protected bool CanBackDirectoryCommand(object p) => true;

        protected void OnBackDirectoryCommand(object p)
        {

        }

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            CloseProgramCommand = new LambdaCommand(OnCloseProgramCommandExecute, CanCloseProgramCommandExecute);
            OpenDirectoryCommand = new LambdaCommand(OnOpenDirectoryCommand, CanOpenDirectoryCommand);
            BackDirectoryCommand = new LambdaCommand(OnBackDirectoryCommand, CanBackDirectoryCommand);

            Mp3Directories = Mp3Services.InitializeObservableCollection();
        }

    }
}
