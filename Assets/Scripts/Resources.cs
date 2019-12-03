using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RisingThroughTheShadows
{
    public class Resources : MonoBehaviour
    {

        public class Resource
        {
            public string name;
            public float amount;
            public string tooltip;
            public float resourceCap;
            public bool unlocked;

            public Resource(string nam, float tot, string tip, bool avail)
            {
                name = nam;
                amount = tot;
                tooltip = tip;
                unlocked = avail;
                //resourceCap = cap;
            }

            public bool getUnlocked()
            {
                return unlocked;
            }
        }

        public List<Resource> resourceList = new List<Resource>();

        #region Resources
        // T0 resources
        public Resource nuyen = new Resource("Nuyen", 5000f, "The green of the future!", true);
        public Resource magicalReagents = new Resource("Magical Reagents", 0f, "Eye of... maybe that's a newt? No, it's got too many heads...", false);
        public Resource junk = new Resource("Junk", 0f, "All kinds of things! One man's trash is another one's trash!", false);
        public Resource energy = new Resource("Energy", 0f, "Zap!", false);
        // default amount set to 1 because Run Speed is a multiplier resource
        public Resource runSpeed = new Resource("Run Speed", 1f, "Super speedy!", false);
        public Resource science = new Resource("Science", 0f, "Science, bitch!", false);

        // T1 Resources
        public Resource foodstuff = new Resource("Foodstuff", 0f, "Soybean based consumables. When combined with lentils and green food dye, it makes a tasty... oh, never mind.", false);
        public Resource metalScrap = new Resource("Metal Scrap", 0f, "Chunks of wrecked vehicles and drones. Scorch marks and bullet holes included.", false);
        public Resource rareEarthMetals = new Resource("Rare Earth Metals", 0f, "Clumps of fancy metals with fancier names", false);
        public Resource plastic = new Resource("Plastic", 0f, "This stuff is everywhere!", false);

        // T2 Resources
        public Resource explosives = new Resource("Explosives", 0f, "The easiest way to turn a big thing into a lot of little things", false);
        public Resource arcaneIngredients = new Resource("Arcane Ingredients", 0f, "Glowy glowy stuff", false);
        public Resource steel = new Resource("Steel", 0f, "Great balls of steel!", false);
        public Resource compositeMetal = new Resource("Composite Metal", 0f, "Assorted metallic compounds", false);
        public Resource basicBlades = new Resource("Basic Blades", 0f, "A flattened and sharpened steel rod is more deadly than you think...", false);

        // T3 Resources
        public Resource basicCircuitry = new Resource("Basic Circuitry", 0f, "The building blocks of artificial life!", false);
        public Resource flakJackets = new Resource("Flak Jackets", 0f, "It might be the only thing between you and a hole in your chest", false);
        public Resource medkits = new Resource("Medkits", 0f, "Patching you up!", false);
        public Resource bullets = new Resource("Bullets", 0f, "Metal slugs that leave a trail of red slime in their wake", false);

        // T4 Resources
        public Resource drones = new Resource("Drones", 0f, "Robot vaccuums, toaster-bots, and other useful friendly household robots", false);
        public Resource microprocessors = new Resource("Microprocessors", 0f, "These things just keep getting smaller!", false);
        public Resource firearms = new Resource("Firearms", 0f, "Guns don't kill people, people do... but the gun helps!", false);

        // T5 Resources 
        public Resource cyberwear = new Resource("Cyberwear", 0f, "Shiny and chrome!", false);
        public Resource combatDrones = new Resource("Combat Drones", 0f, "A robot vaccuum with a knife", false);
        public Resource combatKit = new Resource("Combat Kit", 0f, "Readying you for the big bads out there", false);

        // T6 Resources
        public Resource microdrones = new Resource("Microdrones", 0f, "Aww, look how cute it is! With it's tiny little gun!", false);



        #endregion

        void Start()
        {
            resourceList.Add(nuyen);
            resourceList.Add(magicalReagents);
            resourceList.Add(junk);
            resourceList.Add(energy);
            resourceList.Add(runSpeed);
            resourceList.Add(science);
            resourceList.Add(foodstuff);
            resourceList.Add(metalScrap);
            resourceList.Add(rareEarthMetals);
            resourceList.Add(plastic);
            resourceList.Add(explosives);
            resourceList.Add(arcaneIngredients);
            resourceList.Add(steel);
            resourceList.Add(compositeMetal);
            resourceList.Add(basicBlades);
            resourceList.Add(basicCircuitry);
            resourceList.Add(flakJackets);
            resourceList.Add(medkits);
            resourceList.Add(bullets);
            resourceList.Add(drones);
            resourceList.Add(microprocessors);
            resourceList.Add(firearms);
            resourceList.Add(cyberwear);
            resourceList.Add(combatDrones);
            resourceList.Add(combatKit);
            resourceList.Add(microdrones);
        }
    }
}