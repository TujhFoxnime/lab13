using ResourcesAndDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourcesAndDataBinding.Views
{
    

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JournalView : ContentPage
    {
        private Journal NewJournal { get; set; }
        public JournalView()
        {
            InitializeComponent();
            NewJournal = new Journal
            {
                Title = "Tech",
                AuthorName = "Insights",
                PublicationDate = new DateTime(2023, 1, 10),
                IsJournalMember = false
            };

            BindingContext = NewJournal;
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Contact saved", $"{NewJournal.Title} " +
                $"{Environment.NewLine} {NewJournal.AuthorName} " +
                $"{Environment.NewLine} {NewJournal.PublicationDate}", "Ok");
        }
    }
}