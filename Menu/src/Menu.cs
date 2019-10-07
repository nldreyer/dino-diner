using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.src
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
                return availableMenuItems;
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

                return entrees;
            }
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

                return sides;
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

                return drinks;
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
                return availableCombos;
            }
        }

        /// <summary>
        /// Overrides ToString method
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
    }
}
