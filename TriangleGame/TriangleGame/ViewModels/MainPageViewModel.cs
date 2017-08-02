using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using TriangleGame.Services;

namespace TriangleGame.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ICommand CreateGame { get; set; }

        readonly IShareService shareService;
        readonly IGameService gameService;

        public MainPageViewModel(IShareService shareService, IGameService gameService)
        {
            this.gameService = gameService;
            this.shareService = shareService;
            CreateGame = new DelegateCommand(OnCreateGame);
        }

        private async void OnCreateGame()
        {
            await shareService.ShareUrl("http://test.com/" + gameService.GetNewGameToken());
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
