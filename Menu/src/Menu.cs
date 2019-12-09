/*  Menu.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Returns a list of all available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();
                availableMenuItems.AddRange(AvailableEntrees);
                availableMenuItems.AddRange(AvailableSides);
                availableMenuItems.AddRange(AvailableDrinks);
                availableMenuItems.AddRange(AvailableCombos);
                return new List<IMenuItem>(availableMenuItems);
            }
        }

        /// <summary>
        /// Returns a list of all available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                Brontowurst brontowurst = new Brontowurst();
                DinoNuggets dinoNuggets = new DinoNuggets();
                PrehistoricPBJ prehistoricPBJ = new PrehistoricPBJ();
                PterodactylWings pterodactylWings = new PterodactylWings();
                SteakosaurusBurger steakosaurusBurger = new SteakosaurusBurger();
                TRexKingBurger tRexKingBurger = new TRexKingBurger();
                VelociWrap velociWrap = new VelociWrap();

                List<IMenuItem> entrees = new List<IMenuItem>();
                entrees.Add(brontowurst);
                entrees.Add(dinoNuggets);
                entrees.Add(prehistoricPBJ);
                entrees.Add(pterodactylWings);
                entrees.Add(steakosaurusBurger);
                entrees.Add(tRexKingBurger);
                entrees.Add(velociWrap);

                return new List<IMenuItem>(entrees);
            }
        }

        /// <summary>
        /// Returns a list of menu items after the category is checked
        /// </summary>
        /// <param name="availableItems">List of items to filter</param>
        /// <param name="category"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterCategory(List<IMenuItem> availableItems, List<string> category)
        {
            IEnumerable<IMenuItem> combos = category.Contains("Combo") ? availableItems.OfType<CretaceousCombo>() : null;
            IEnumerable<IMenuItem> entrees = category.Contains("Entree") ? availableItems.OfType<Entree>() : null;
            IEnumerable<IMenuItem> sides = category.Contains("Side") ? availableItems.OfType<Side>() : null;
            IEnumerable<IMenuItem> drinks = category.Contains("Drink") ? availableItems.OfType<Drink>() : null;
            IEnumerable<IMenuItem> items = null;
            if (combos != null)
            {
                items = combos;
            }
            if (entrees != null)
            {
                if (items != null)
                {
                    items = items.Concat(entrees);
                }
                else
                {
                    items = entrees;
                }
            }
            /*List<IMenuItem> items = new List<IMenuItem>();
            foreach (IMenuItem item in availableItems)
            {
                if (item is CretaceousCombo && category.Contains("Combo"))
                {
                    items.Add(item);
                }
                else if (item is Entree && category.Contains("Entree"))
                {
                    items.Add(item);
                }
                else if (item is Side && category.Contains("Side"))
                {
                    items.Add(item);
                }
                else if (item is Drink && category.Contains("Drink"))
                {
                    items.Add(item);
                }
            }*/
            return combos.GroupJoin(entrees).ToList();
        }

        /// <summary>
        /// Returns a Menu that has been name string searched
        /// </summary>
        /// <param name="availableItems">List of items to filter</param>
        /// <param name="search">Search string</param>
        /// <returns></returns>
        public static List<IMenuItem> Search(List<IMenuItem> availableItems, string search)
        {
            IEnumerable<IMenuItem> items = availableItems.Where(item => item.Description.ToLower().Contains(search.ToLower()));
            /*List<IMenuItem> items = new List<IMenuItem>();
            foreach (IMenuItem item in availableItems)
            {
                if (item.Description.Contains(search))
                {
                    items.Add(item);
                }
            }*/
            return items.ToList();
        }

        /// <summary>
        /// Returns a list of all available sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                Fryceritops fryceritops = new Fryceritops();
                MeteorMacAndCheese meteorMacAndCheese = new MeteorMacAndCheese();
                MezzorellaSticks mezzorellaSticks = new MezzorellaSticks();
                Triceritots triceritots = new Triceritots();

                List<IMenuItem> sides = new List<IMenuItem>();
                sides.Add(fryceritops);
                sides.Add(meteorMacAndCheese);
                sides.Add(mezzorellaSticks);
                sides.Add(triceritots);

                return new List<IMenuItem>(sides);
            }
        }

        /// <summary>
        /// Returns a list of all available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                JurassicJava jurassicJava = new JurassicJava();
                Sodasaurus sodasaurus = new Sodasaurus();
                Tyrannotea tyrannotea = new Tyrannotea();
                Water water = new Water();

                List<IMenuItem> drinks = new List<IMenuItem>();
                drinks.Add(jurassicJava);
                drinks.Add(sodasaurus);
                drinks.Add(tyrannotea);
                drinks.Add(water);

                return new List<IMenuItem>(drinks);
            }
        }

        /// <summary>
        /// Returns a list of all available combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> availableCombos = new List<IMenuItem>();
                foreach (IMenuItem entree in AvailableEntrees)
                {
                    availableCombos.Add(new CretaceousCombo((Entree)entree));
                }
                return new List<IMenuItem>(availableCombos);
            }
        }

        /// <summary>
        /// Hides ToString method
        /// </summary>
        /// <returns>All menu items in string form</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem menuItem in AvailableMenuItems)
            {
                sb.AppendLine(menuItem.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns a list of items with a lower price boundary filter
        /// </summary>
        /// <param name="availableItems">List of items to filter</param>
        /// <param name="min">Minimum value of item</param>
        /// <returns></returns>
        public static List<IMenuItem> FilterMin(List<IMenuItem> availableItems, float min)
        {
            IEnumerable<IMenuItem> items = availableItems.Where(item => item.Price - min > -0.001);
            /*List<IMenuItem> items = new List<IMenuItem>();
            foreach (IMenuItem item in availableItems)
            {
                if (item.Price - min > -0.001)
                {
                    items.Add(item);
                }
            }*/
            return items.ToList();
        }

        /// <summary>
        /// Returns a list of items with an upper price boundary filter
        /// </summary>
        /// <param name="availableItems">List of items to filter</param>
        /// <param name="max">Maximum value of item</param>
        /// <returns></returns>
        public static List<IMenuItem> FilterMax(List<IMenuItem> availableItems, float max)
        {
            IEnumerable<IMenuItem> items = availableItems.Where(item => item.Price - max < -.000000000001);
            /*List<IMenuItem> items = new List<IMenuItem>();
            foreach (IMenuItem item in availableItems)
            {
                double temp = item.Price - max;
                if (item.Price - max < -0.000000000001)
                {
                    items.Add(item);
                }
            }*/
            return items.ToList();
        }

        public static List<IMenuItem> FilterIngredients(List<IMenuItem> availableItems, List<String> excludeIngredients)
        {
            IEnumerable<IMenuItem> items = availableItems.Where(item => item is IMenuItem);
            foreach (string ingredient in excludeIngredients)
            {
                items = items.Where(item => !item.Ingredients.Contains(ingredient));
            }
            /*List<IMenuItem> items = new List<IMenuItem>(availableItems);
            foreach (IMenuItem item in availableItems)
            {
                foreach (String ingredient in excludeIngredients)
                {
                    if (item.Ingredients.Contains(ingredient))
                    {
                        items.Remove(item);
                    }
                }
            }*/
            return items.ToList();
        }

        public List<string> AllIngredients
        {
            get
            {
                List<IMenuItem> items = AvailableMenuItems;
                List<string> ingredients = new List<string>();
                foreach (IMenuItem item in items)
                {
                    foreach (string ingredient in item.Ingredients)
                    {
                        if (!ingredients.Contains(ingredient))
                        {
                            ingredients.Add(ingredient);
                        }
                    }
                }
                return ingredients;
            }
        } 
    }
}
