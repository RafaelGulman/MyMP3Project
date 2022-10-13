using MyMP3Project.Models;
using MyMP3Project.ViewModels.Base;
using MyMP3Project.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using MyMP3Project.Infrastructure.Commands;

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

        #endregion

        public MainWindowViewModel()
        {
            CloseProgramCommand = new LambdaCommand(OnCloseProgramCommandExecute, CanCloseProgramCommandExecute);

            Mp3Directories =  Mp3Services.InitializeObservableCollection();
        }

    }
}
