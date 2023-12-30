﻿using ResourcesAndDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourcesAndDataBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JournalsListView : ContentPage
    {
        private ObservableCollection<Journal> Journals { get; set; }
        public JournalsListView()
        {
            InitializeComponent();
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
            BindingContext = Journals;
        }

        private void JournalList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var journal = e.SelectedItem as Journal;
            if (journal != null)
            {
                DisplayAlert("Edit", "Here we can edit selected element", "Ok");
            }
        }
    }
}