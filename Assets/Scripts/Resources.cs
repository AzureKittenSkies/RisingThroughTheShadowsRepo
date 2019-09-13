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

            public Resource(string nam, float tot, string tip)
            {
                name = nam;
                amount = tot;
                tooltip = tip;
                //resourceCap = cap;
            }
        }



        #region Resources
        // T0 resources
        public Resource nuyen = new Resource("Nuyen", 0f, "The green of the future!");
        public Resource magicalReagents = new Resource("Magical Reagents", 0f, "Eye of... maybe that's a newt? No, it's got too many heads...");
        public Resource junk = new Resource("Junk", 0f, "All kinds of things! One man's trash is another one's trash!");
        public Resource energy = new Resource("Energy", 0f, "Zap!");
        public Resource runSpeed = new Resource("Run Speed", 0f, "Super speedy!");

        // T1 Resources
        public Resource foodstuff = new Resource("Foodstuff", 0f, "Soybean based consumables. When combined with lentils and green food dye, it makes a tasty... oh, never mind.");
        public Resource metalScrap = new Resource("Metal Scrap", 0f, "Chunks of wrecked vehicles and drones. Scorch marks and bullet holes included.");
        public Resource rareEarthMetals = new Resource("Rare Earth Metals", 0f, "Clumps of fancy metals with fancier names");
        public Resource plastics = new Resource("Plastics", 0f, "This stuff is everywhere!");

        // T2 Resources
        public Resource explosives = new Resource("Explosives", 0f, "The easiest way to turn a big thing into a lot of little things");
        public Resource arcaneIngredients = new Resource("Arcane Ingredients", 0f, "Glowy glowy stuff");
        public Resource steel = new Resource("Steel", 0f, "Great balls of steel!");
        public Resource compositeMetal = new Resource("Composite Metal", 0f, "Assorted metallic compounds");
        public Resource basicBlades = new Resource("Basic Blades", 0f, "A flattened and sharpened steel rod is more deadly than you think...");

        // T3 Resources
        public Resource basicCircuitry = new Resource("Basic Circuitry", 0f, "The building blocks of artificial life!");
        public Resource flakJackets = new Resource("Flak Jackets", 0f, "It might be the only thing between you and a hole in your chest");
        public Resource medkits = new Resource("Medkits", 0f, "Patching you up!");
        public Resource bullets = new Resource("Bullets", 0f, "Metal slugs that leave a trail of red slime in their wake");

        // T4 Resources
        public Resource drones = new Resource("Drones", 0f, "Robot vaccuums, toaster-bots, and other useful friendly household robots");
        public Resource microprocessors = new Resource("Microprocessors", 0f, "These things just keep getting smaller!");
        public Resource firearms = new Resource("Firearms", 0f, "Guns don't kill people, people do... but the gun helps!");

        // T5 Resources 
        public Resource cyberwear = new Resource("Cyberwear", 0f, "Shiny and chrome!");
        public Resource combatDrones = new Resource("Combat Drones", 0f, "A robot vaccuum with a knife");
        public Resource combatKit = new Resource("Combat Kit", 0f, "Readying you for the big bads out there");

        // T6 Resources
        public Resource microdrones = new Resource("Microdrones", 0f, "Aww, look how cute it is! With it's tiny little gun!");



        #endregion


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}