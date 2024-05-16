using Reddit.Library.SearchFunctions;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Search = Reddit.Library.SearchFunctions.Search;

namespace RedditEngineApp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string query;
        public string Query
        {
            get => query;
            set
            {
                if (query != value)
                {
                    query = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string results;
        public string Results
        {
            get => results;
            set
            {
                if (results != value)
                {
                    results = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Query = string.Empty;
            BindingContext = this;
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // converts string to + separated query, then searches for it
            Results = Search.SearchQuery(Search.StringToQuery(Query));
        }
    }
}
