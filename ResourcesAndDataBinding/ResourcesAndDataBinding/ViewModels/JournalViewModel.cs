using ResourcesAndDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ResourcesAndDataBinding.ViewModels
{
    public class JournalViewModel
    {
        public ObservableCollection<Journal> Journals { get; set; }

        public Journal SelectedJournal { get; set; }

        public JournalViewModel()
        {
            this.Journals = new ObservableCollection<Journal>();
            Journals = new ObservableCollection<Journal>();

            Journal journal1 = new Journal
            {
                Title = "Tech",
                AuthorName = "Insights",
                PublicationDate = new DateTime(2023, 1, 10),
                IsJournalMember = false
            };
            Journal journal2 = new Journal
            {
                Title = "Science",
                AuthorName = "World",
                PublicationDate = new DateTime(2023, 2, 15),
                IsJournalMember = true
            };
            Journal journal3 = new Journal
            {
                Title = "Health",
                AuthorName = "Trends",
                PublicationDate = new DateTime(2023, 3, 20),
                IsJournalMember = true
            };

            Journals.Add(journal1);
            Journals.Add(journal2);
            Journals.Add(journal3);
        }
    }
}
