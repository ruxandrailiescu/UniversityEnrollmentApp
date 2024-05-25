using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UniversityEnrollmentApp.Entities;

namespace UniversityEnrollmentApp.ViewModel
{
    public class CandidateFormViewModel : INotifyPropertyChanged
    {
        #region Properties

        private long _candidateId;
        public long CandidateID
        {
            get { return _candidateId; }
            set
            {
                if (_candidateId == value)
                    return;
                _candidateId = value;
                OnPropertyChanged();
            }
        }

        private string _candidateFirstName;
        public string CandidateFirstName
        {
            get { return _candidateFirstName; }
            set
            {
                if(_candidateFirstName == value)
                    return;
                _candidateFirstName = value;
                OnPropertyChanged();
            }
        }

        private string _candidateLastName;
        public string CandidateLastName
        {
            get { return _candidateLastName; }
            set
            {
                if (_candidateLastName == value)
                    return;
                _candidateLastName = value;
                OnPropertyChanged();
            }
        }

        private DateTime _candidateBirthDate;
        public DateTime CandidateBirthDate
        {
            get { return _candidateBirthDate; }
            set
            {
                if (_candidateBirthDate == value)
                    return;
                _candidateBirthDate = value;
                OnPropertyChanged();
            }
        }

        private string _candidateAddress;
        public string CandidateAddress
        {
            get { return _candidateAddress; }
            set
            {
                if (_candidateAddress == value)
                    return;
                _candidateAddress = value;
                OnPropertyChanged();
            }
        }

        private bool _applicationStatus;
        public bool ApplicationStatus
        {
            get { return _applicationStatus; }
            set
            {
                if(_applicationStatus == value)
                    return;
                _applicationStatus = value;
                OnPropertyChanged();
            }
        }

        private long _facultyId;
        public long FacultyID
        {
            get { return _facultyId; }
            set
            {
                if (_facultyId == value)
                    return;
                _facultyId = value;
                OnPropertyChanged();
            }
        }

        public BindingList<Candidate> Candidates { get; set; }

        #endregion

        public CandidateFormViewModel()
        {
            Candidates = new BindingList<Candidate>();
            CandidateBirthDate = DateTime.Now;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        // [CallerMemberName] - Allows you to obtain the method or property name of the caller to the method. https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute%28v=vs.110%29.aspx
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
