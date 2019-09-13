using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RisingThroughTheShadows
{
    public class Buildings : MonoBehaviour
    {
        public Dictionary<string, Building> buildingsRegistry = new Dictionary<string, Building>();

        public Dictionary<string, float> tempBuyDict;
        public Dictionary<string, float> tempUseDict;
        public Dictionary<string, float> tempMakeDict;
        public class Building
        {
            public string name;
            public int amount;
            public string tooltip;
            public float costRatio;
            public Dictionary<string, float> purchaseCost;
            public Dictionary<string, float> resourceConsumption;
            public Dictionary<string, float> resourceProduction;
            public bool unlocked;

            public Building(string nam, int no, string tip, float priceIncAmnt, bool available, Dictionary<string, float> buyCost, Dictionary<string, float> resourceUse, Dictionary<string, float> resourceMake)
            {
                name = nam;
                amount = no;
                tooltip = tip;
                costRatio = priceIncAmnt;
                unlocked = available;
                purchaseCost = buyCost;
                resourceConsumption = resourceUse;
                resourceProduction = resourceMake;
            }





        }

        //public Building nutrientDispenser = new Building("Metal ")

        public Building metalSalvagingTable = new Building("Metal Salvaging Table", 0, "Separating the metal wheat from the rest of that weird stuff", 1.15f, false,
            new Dictionary<string, float> { { "Nuyen", 100f }, { "Metal Scrap", 50f } },
            new Dictionary<string, float> { { "Junk", 1f } },
            new Dictionary<string, float> { { "Metal Scrap", 0.5f }, { "Rare Earth Metals", 0.3f } });

        public Building nutrientDispenser = new Building("Nutrient Dispenser", 0, "It's not pretty, or tasty, but it's still food", 1.15f, false,
            new Dictionary<string, float> { { "Nuyen", 150f } },
            new Dictionary<string, float> { { "Nuyen", 0.5f } },
            new Dictionary<string, float> { { "Foodstuff", 0.25f } });

        public Building magicalSalvagingTable = new Building("Magical Salvaging Table", 0, "We actually like that weird stuff, thank you very much", 1.15f, false,
            new Dictionary<string, float> { { "Nuyen", 50f }, { "Junk", 75f } },
            new Dictionary<string, float> { { "Junk", 1f } },
            new Dictionary<string, float> { { "Magical Reagents", 0.2f } });

        public Building electronicsAssembly = new Building("Electronics Assembly", 0, "Putting little wires together", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 100f }, { "Steel", 75f } },
            new Dictionary<string, float> { { "Composite Metal", 1f }, { "Rare Earth Elements", 0.5f } },
            new Dictionary<string, float> { { "Basic Circuitry", 0.4f } });

        public Building transmutationStation = new Building("Transmutation Station", 0, "Lead to gold!", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 50f }, { "Steel", 75f } },
            new Dictionary<string, float> { { "Magical Reagents", 0.75f } },
            new Dictionary<string, float> { { "Explosives", 0.1 } });

        public Building magicalRefinery = new Building("Magical Refinery", 0, "Tables covered with scrolls, sigils and glowing symbols", false,
            new Dictionary<string, float> { { "Metal Scrap", 100f }, { "Steel", 100f }, { "Rare Earth Metals", 50f } },
            new Dictionary<string, float> { { "Magical Reagents", 0.4f } },
            new Dictionary<string, float> { { "Arcane Ingredients", 0.2f } });

        public Building smeltery = new Building("Smeltery", 0, "Melt it all down into nice bars of steel", false,
            new Dictionary<string, float> { { "Metal Scrap", 50f } },
            new Dictionary<string, float> { { "Metal Scrap", 1f } },
            new Dictionary<string, float> { { "Steel", 0.5f }, { "Composite Metal", 0.35f } });

        // Not a building, but crafted resource? Not sure how to handle. Maybe use it as an upgrade or something??
        //public Building simpleBladePress = new Building("Simple Blade Press", 0, "Anything can be a weapon if you swing it right", false,
        //    new Dictionary<string, float> { { "Metal Scrap", 50f } },
        //    new Dictionary<string, float> { { "Metal Scrap", 15f } },
        //    new Dictionary<string, float> { { "Basic Blades", 1f } });

        public Building droneFactory = new Building("Drone Factory", 0, "The robots rise!", false,
            new Dictionary<string, float> { { "Metal Scrap", 50f }, { "Steel", 25f }, { "Basic Circuitry", 15f } },
            new Dictionary<string, float> { { "Steel", 0.5f }, { "Basic Circuitry", 0.3f } },
            new Dictionary<string, float> { { "Drones", 0.2f } });

        public Building electronicsAssembly = new Building("Electronics Assembly", 0, "Putting little wires together", false,
            new Dictionary<string, float> { { "Metal Scrap", 100f }, { "Steel", 75f } },
            new Dictionary<string, float> { { "Basic Circuitry", 0.2f }, { "Rare Earth Metals", 0.5f }, { "Nuyen", 1.5f } },
            new Dictionary<string, float> { { "Microprocessors", 0.05f } });

        // not sure how to handle storage upgrades and/or housing

        

        // Use this for initialization
        void Start()
        {

            Debug.Log(metalSalvagingTable.name);

            //buildingsRegistry metalSalvage = new buildingsRegistry("Metal Salvaging Table", metalSalvagingTable);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
s