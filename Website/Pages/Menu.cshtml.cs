using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;


namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu;
        public List<IMenuItem> Combos;
        public List<IMenuItem> Entrees;
        public List<IMenuItem> Sides;
        public List<IMenuItem> Drinks;
        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> category { get; set; } = new List<string>();
        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }
        [BindProperty]
        public List<string> exclude { get; set; } = new List<string>();

        public void OnGet()
        {
            Menu = new Menu();
            Combos = new Menu().AvailableCombos;
            Entrees = new Menu().AvailableEntrees;
            Sides = new Menu().AvailableSides;
            Drinks = new Menu().AvailableDrinks;
        }

        public void OnPost(string search, List<string> category, float? minimumPrice, float? maximumPrice, List<string> exclude)
        {
            Menu = new Menu();
            Combos = new Menu().AvailableCombos;
            Entrees = new Menu().AvailableEntrees;
            Sides = new Menu().AvailableSides;
            Drinks = new Menu().AvailableDrinks;

            if (search != null)
            {
                Combos = Menu.Search(Combos, search);
                Entrees = Menu.Search(Entrees, search);
                Sides = Menu.Search(Sides, search);
                Drinks = Menu.Search(Drinks, search);
            }

            if (category.Count > 0)
            {
                Combos = Menu.FilterCategory(Combos, category);
                Entrees = Menu.FilterCategory(Entrees, category);
                Sides = Menu.FilterCategory(Sides, category);
                Drinks = Menu.FilterCategory(Drinks, category);
            }

            if (minimumPrice != null)
            {
                Combos = Menu.FilterMin(Combos, (float)minimumPrice);
                Entrees = Menu.FilterMin(Entrees, (float)minimumPrice);
                Sides = Menu.FilterMin(Sides, (float)minimumPrice);
                Drinks = Menu.FilterMin(Drinks, (float)minimumPrice);
            }

            if (maximumPrice != null)
            {
                Combos = Menu.FilterMax(Combos, (float)maximumPrice);
                Entrees = Menu.FilterMax(Entrees, (float)maximumPrice);
                Sides = Menu.FilterMax(Sides, (float)maximumPrice);
                Drinks = Menu.FilterMax(Drinks, (float)maximumPrice);
            }

            if (exclude.Count > 0)
            {
                Combos = Menu.FilterIngredients(Combos, exclude);
                Entrees = Menu.FilterIngredients(Entrees, exclude);
                Sides = Menu.FilterIngredients(Sides, exclude);
                Drinks = Menu.FilterIngredients(Drinks, exclude);
            }
        }
    }
}