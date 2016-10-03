using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using labo_4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace labo_4.ViewModel
{
    public class MainViewModel : ViewModelBase,INotifyPropertyChanged
    {
        private ICommand _editStudentCommand;
        private INavigationService _navigationService;
        private Student _selectedStudent;
        private ObservableCollection<Student> _students;


        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Students = new ObservableCollection<Student>(AllStudent.GetAllStudents());
        }

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                RaisePropertyChanged("Students");
            }
        }

        public MainViewModel()
        {
            Students = new ObservableCollection<Student>(AllStudent.GetAllStudents());
        }

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                if(_selectedStudent != null)
                {
                    RaisePropertyChanged("SelectedStudent");
                }
            }
        }

        public ICommand EditStudentCommand
        {
            get
            {
                if(this._editStudentCommand ==null)
                {
                    this._editStudentCommand = new RelayCommand(() => EditStudent());
                }
                return this._editStudentCommand;
            }
        }

        private void EditStudent()
        {
            if(CanExecute())
            {
                _navigationService.NavigateTo("SecondPage", SelectedStudent);
            }
        }

        public bool CanExecute()
        {
            return (SelectedStudent != null);
        }
        
    }
}
