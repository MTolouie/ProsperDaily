using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDailyTests.Repositories;

namespace ProsperDaily;

public partial class App : Application
{

    public static BaseRepository<Transaction>	TransactionsRepository { get; set; }
    public App(BaseRepository<Transaction> _transactionsRepository)
	{
		InitializeComponent();
		TransactionsRepository = _transactionsRepository;
		MainPage = new NavigationPage(new AppContainer());
	}
}
