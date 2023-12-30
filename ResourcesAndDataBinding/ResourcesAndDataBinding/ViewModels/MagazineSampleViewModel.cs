using ResourcesAndDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ResourcesAndDataBinding.ViewModels
{
    public class MagazineSampleViewModel :INotifyPropertyChanged
    {
        public ObservableCollection<MagazineSample> ComponentsOfJournal { get; set; }
        private MagazineSample _selectedJournal;
        public MagazineSample SelectedJournal
        {
            get
            {
                return _selectedJournal;
            }
            set
            {
                _selectedJournal = value;
                OnPropertyChanged();
            }
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }
        public ICommand RefreshCommand { get; set; }
        public ICommand AddComponentsOfJournalCommand { get; set; }
        public ICommand DeleteComponentsOfJournalCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void LoadSampleData()
        {
            ComponentsOfJournal = new ObservableCollection<MagazineSample>();
            // sample data
            MagazineSample journal1 =
            new MagazineSample
            {
                FullNameJ = "Tech Insights",
                EditorialTeam = "Digital Innovations Publishing",
                PublicationDate = new DateTime(2023, 1, 10)
            };
            MagazineSample journal2 =
            new MagazineSample
            {
                FullNameJ = "Science World",
                EditorialTeam = "Knowledge Creations Media",
                PublicationDate = new DateTime(2023, 2, 15)
            };
            MagazineSample journal3 =
            new MagazineSample
            {
                FullNameJ = "Health Trends",
                EditorialTeam = "Wellness Publications",
                PublicationDate = new DateTime(2023, 3, 20)
            };
            ComponentsOfJournal.Add(journal1);
            ComponentsOfJournal.Add(journal2);
            ComponentsOfJournal.Add(journal3);
        }

        public MagazineSampleViewModel()
        {
            LoadSampleData();

            Random r = new Random();
            AddComponentsOfJournalCommand = new Command(() => ComponentsOfJournal.Add(new MagazineSample() 
            {
                EditorialTeam = "Corporate Strategies Press",
                PublicationDate = new DateTime(r.Next(2020,2023), r.Next(1, 12), r.Next(1, 30)),
                FullNameJ = "Business Review"
            }));

            DeleteComponentsOfJournalCommand = new Command<MagazineSample>((journal) => ComponentsOfJournal.Remove(journal));

            RefreshCommand = new Command(async () =>
            {
                IsRefreshing = true;
                LoadSampleData();
                // Simulates a longer operation
                await Task.Delay(2000);
                IsRefreshing = false;
            });
        }

    }
}
