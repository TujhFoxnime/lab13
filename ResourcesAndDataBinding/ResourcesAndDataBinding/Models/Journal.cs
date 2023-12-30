using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;

namespace ResourcesAndDataBinding.Models
{
    [Table("Journals")]
    public class Journal : INotifyPropertyChanged
    {
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; }

        private string _nameJournal;

        [MaxLength(50)]
        [NotNull]
        public string Title
        {
            get
            {
                return _nameJournal;
            }

            set
            {
                _nameJournal = value;
                OnPropertyChanged();
            }
        }
        private string _AuthorName;
        public string AuthorName
        {
            get
            {
                return _AuthorName;
            }

            set
            {
                _AuthorName = value;
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
        private bool _isJournalMember;
        public bool IsJournalMember
        {
            get
            {
                return _isJournalMember;
            }

            set
            {
                _isJournalMember = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}