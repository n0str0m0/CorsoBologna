using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corso.Bologna.Models;
using Corso.Bologna.Services;
using GalaSoft.MvvmLight;

namespace Corso.Bologna.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private IList<Recipe> _recipes;

        public MainViewModel()
        {
            Title = nameof(MainViewModel);
            LoadDataAsync();
        }

        public async void LoadDataAsync()
        {
            Recipes = await new RecipeService().GetRecipeAsync();
        }
        public string Title { get; set; }

        public IList<Recipe> Recipes
        {
            get { return _recipes; }
            set
            {
                       
                Set(ref _recipes, value);
            }
        }
    }
}
