using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ResourcesAndDataBinding.Models
{
    public class MagazineSample : INotifyPropertyChanged
    {
        private string fullNameJ;
        public string FullNameJ
        {
            get
            {
                return fullNameJ;
            }
            set
            {
                fullNameJ = value;
                OnPropertyChanged();
            }
        }

        private DateTime publicationDate;

        public DateTime PublicationDate
        {
            get
            {
                return publicationDate;
            }
            set
            {
                publicationDate = value;
                OnPropertyChanged();
            }
        }
        private string editTeam;
        public string EditorialTeam
        {
            get
            {
                return editTeam;
            }
            set
            {
                editTeam = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName
                                        = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
