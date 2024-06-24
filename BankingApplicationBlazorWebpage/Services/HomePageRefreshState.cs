namespace BankingApplicationBlazorWebpage.Services
{
    public class HomePageRefreshState
    {
        public event Action OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
