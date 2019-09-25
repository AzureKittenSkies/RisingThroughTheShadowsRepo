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
            // General building information
            public string name;
            public int amount;
            public string tooltip;
            public float costRatio;
            public Dictionary<string, float> purchaseCost;
            public bool unlocked;

            // Production buildings
            public Dictionary<string, float> resourceConsumption;
            public Dictionary<string, float> resourceProduction;

            // Storage Buildings
            public Dictionary<string, float> storageIncrease;

            // Crafting buildings
            public bool isCraftingBuilding;


            // Constructor for production buildings
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

            // Constructor for storage buildings
            public Building(string nam, int no, string tip, float priceIncAmnt, bool available, Dictionary<string, float> buyCost, Dictionary<string, float> capIncrease)
            {
                name = nam;
                amount = no;
                tooltip = tip;
                costRatio = priceIncAmnt;
                unlocked = available;
                purchaseCost = buyCost;
                storageIncrease = capIncrease;
            }

            // Constructor for buildings that handle one time craft
            public Building(string nam, int no, string tip, float priceIncAmnt, bool available, bool doesItCraft, Dictionary<string, float> buyCost, Dictionary<string, float> resourceUse, Dictionary<string, float> resourceMake)
            {
                name = nam;
                amount = no;
                tooltip = tip;
                costRatio = priceIncAmnt;
                unlocked = available;
                doesItCraft = isCraftingBuilding;
                purchaseCost = buyCost;
                resourceConsumption = resourceUse;
                resourceProduction = resourceMake;
            }

        }

        #region Buildings
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
            new Dictionary<string, float> { { "Explosives", 0.1f } });

        public Building magicalRefinery = new Building("Magical Refinery", 0, "Tables covered with scrolls, sigils and glowing symbols", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 100f }, { "Steel", 100f }, { "Rare Earth Metals", 50f } },
            new Dictionary<string, float> { { "Magical Reagents", 0.4f } },
            new Dictionary<string, float> { { "Arcane Ingredients", 0.2f } });

        public Building smeltery = new Building("Smeltery", 0, "Melt it all down into nice bars of steel", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 50f } },
            new Dictionary<string, float> { { "Metal Scrap", 1f } },
            new Dictionary<string, float> { { "Steel", 0.5f }, { "Composite Metal", 0.35f } });

        public Building simpleBladePress = new Building("Simple Blade Press", 0, "Anything can be a weapon if you swing it right", 1.15f, false, true,
            new Dictionary<string, float> { { "Metal Scrap", 50f } },
            new Dictionary<string, float> { { "Metal Scrap", 15f } },
            new Dictionary<string, float> { { "Basic Blades", 1f } });

        public Building droneFactory = new Building("Drone Factory", 0, "The robots rise!", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 50f }, { "Steel", 25f }, { "Basic Circuitry", 15f } },
            new Dictionary<string, float> { { "Steel", 0.5f }, { "Basic Circuitry", 0.3f } },
            new Dictionary<string, float> { { "Drones", 0.2f } });

        public Building electronicsAssemblyMicroprocessor = new Building("Electronics Assembly", 0, "Putting little wires together", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 100f }, { "Steel", 75f } },
            new Dictionary<string, float> { { "Basic Circuitry", 0.2f }, { "Rare Earth Metals", 0.5f }, { "Nuyen", 1.5f } },
            new Dictionary<string, float> { { "Microprocessors", 0.05f } });

        public Building vehicleWorkshop = new Building("Vehicle Workshop", 0, "Vehicular assembly lines", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 100f }, { "Nuyen", 75 } },
            new Dictionary<string, float> { { "Metal Scrap", 0.5f }, { "Steel", 0.75f }, { "Composite Metal", 0.25f } },
            new Dictionary<string, float> { { "Run Speed", 1f } });

        public Building recycler = new Building("Recyler", 0, " ", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 125f } },
            new Dictionary<string, float> { { "Junk", 1f } },
            new Dictionary<string, float> { { "Plastic", 0.5f } });

        public Building armory = new Building("Armory", 0, "Equipping you with the best (that we've got)!", 1.15f, false, true,
            new Dictionary<string, float> { { "Steel", 100f }, { "Basic Circuitry", 100f }, { "Composite Metal", 150f } },
            new Dictionary<string, float> { { "Composite Metal", 25f }, { "Metal Scrap", 10f } },
            new Dictionary<string, float> { { "Flak Jacket", 1f } });

        public Building ammunitionMill = new Building("Ammunition Mill", 0, "Churing out bullets like a belt fed HMG", 1.5f, false,
            new Dictionary<string, float> { { "Steel", 50f }, { "Metal Scrap", 100f }, { "Basic Circuitry", 50f } },
            new Dictionary<string, float> { { "Steel", 2.5f }, { "Explosives", 5f } },
            new Dictionary<string, float> { { "Bullets", 5f } });

        public Building augmentationManufactory = new Building("Augmentation Manufactory", 0, "Upgrades, upgrades, upgrades!", 1.15f, false, true,
            new Dictionary<string, float> { { "Steel", 150f }, { "Basic Circuitry", 200f }, { "Microprocessors", 150f } },
            new Dictionary<string, float> { { "Steel", 10f }, { "Composite Metal", 17.5f }, { "Microprocessors", 25f } },
            new Dictionary<string, float> { { "Cyberwear", 1f } });

        public Building droneFactoryCombatDrones = new Building("Drone Factory", 0, "The robots rise!", 1.15f, false, true,
            new Dictionary<string, float> { { "Metal Scrap", 200f }, { "Steel", 200f }, { "Basic Circuitry", 150f } },
            new Dictionary<string, float> { { "Drones", 5f }, { "Firearms", 5f }, { "Bullets", 25f }, { "Composite Metal", 25 }, { "Energy", 7.5f } },
            new Dictionary<string, float> { { "Combat Drones", 1f } });

        public Building weaponsmith = new Building("Weaponsmith", 0, "The ring of metal hitting metal; turning molten steel into weapons", 1.15f, false, true,
            new Dictionary<string, float> { { "Metal Scrap", 200f }, { "Steel", 250f } },
            new Dictionary<string, float> { { "Bullets", 100f }, { "Metal Scrap", 10f }, { "Composite Metal", 25f }, { "Energy", 2.5f } },
            new Dictionary<string, float> { { "Firearms", 1 } });

        public Building armoryCombatKit = new Building("Armory", 0, "Equipping you with the best (that we've got)!", 1.15f, false, true,
            new Dictionary<string, float> { { "Metal Scrap", 50f }, { "Steel", 25f }, { "Basic Circuitry", 15f } },
            new Dictionary<string, float> { { "Medkit", 5f }, { "Firearms", 3f }, { "Bullets", 150f }, { "Flak Jackets", 2f } },
            new Dictionary<string, float> { { "Combat Kit", 1f } });

        public Building basicResearchBench = new Building("Basic Research Bench", 0, "TBA", 1.15f, false, true,
            new Dictionary<string, float> { { "Junk", 150f }, { "Rare Earth Metals", 150f }, { "Metal Scrap", 150f } },
            new Dictionary<string, float> { { "Junk", 0.5f } },
            new Dictionary<string, float> { { "Science", 0.2f } });




        // Storage Buildings
        public Building backRoomStorage = new Building("Back Room Storage", 0, "We can move some stuff around to make more space...", 1.15f, false,
            new Dictionary<string, float> { { "Nuyen", 150f} },
            new Dictionary<string, float> { { "Metal Scrap", 50f}});

        public Building warehouse = new Building("Warehouse", 0, "Build yourself your very own shack to put things in", 1.15f, false,
            new Dictionary<string, float> { { "Metal Scrap", 100f }, { "Steel", 50f } },
            new Dictionary<string, float> { { "Metal Scrap", 50f }, { "Steel", 50f }, { "Basic Circuitry", 50f } });

        public Building batteryArray = new Building("Battery Array", 0, "Where the extra stuff goes!", 1.15f, false,
            new Dictionary<string, float> { { "Composite Metal", 100f }, { "Steel", 75f } },
            new Dictionary<string, float> { { "Energy", 150f } });



        // Power production
        public Building fuelGenerator = new Building("Fuel Generator", 0, "Best way to stop clutter is to burn it!", 1.15f, false,
            new Dictionary<string, float> { { "Composite MEtal", 75f }, { "Steel", 125f } },
            new Dictionary<string, float> { { "Junk", 5f } },
            new Dictionary<string, float> { { "Energy", 10f } });

        #endregion


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
