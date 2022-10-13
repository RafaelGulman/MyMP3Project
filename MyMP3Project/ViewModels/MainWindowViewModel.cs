using MyMP3Project.Models;
using MyMP3Project.ViewModels.Base;
using MyMP3Project.Services;
using System.Collections.ObjectModel;

namespace MyMP3Project.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Properties

        public ObservableCollection<Mp3Directory> Mp3Directories { get; set; }

        public Mp3Directory SelectedDirectory { get; set; }

        #endregion

        #region Commands

        #endregion

        public MainWindowViewModel()
        {
            Mp3Directories =  Mp3Services.InitializeObservableCollection();
        }

    }
}
