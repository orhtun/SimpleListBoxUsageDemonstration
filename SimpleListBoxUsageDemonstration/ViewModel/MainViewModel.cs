using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;

namespace SimpleListBoxUsageDemonstration.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<string> _sampleList = new ObservableCollection<string>();

        public RelayCommand InsertRandomItemCommand { get; private set; }

        public MainViewModel()
        {
            InsertRandomItemCommand = new RelayCommand(InsertRandomItemCommandExecute, InsertRandomItemCommandCanExecute);
        }

        public ObservableCollection<string> SampleList
        {
            get { return _sampleList; }
            set
            {
                _sampleList = value;
                RaisePropertyChanged();
            }
        }

        public bool InsertRandomItemCommandCanExecute()
        {
            return true;
        }

        public void InsertRandomItemCommandExecute()
        {
            SampleList.Add(string.Format("Item {0}", SampleList.Count + 1));
        }
    }
}