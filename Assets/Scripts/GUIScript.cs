using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RisingThroughTheShadows
{
    public class GUIScript : MonoBehaviour
    {


        #region Screen Resolution variables
        public float scrX = 0;
        public float scrY = 0;

        public float tempX = 0;
        public float tempY = 0;


        #endregion

        #region Menu variables

        public bool startMenu = true;
        public bool gameMenus = false;

        public bool buildingMenu;
        public bool automationMenu;
        public bool scienceMenu;
        public bool upgradeMenu;
        public bool runsMenu;
        public bool settingsMenu;
        public bool tradeMenu;

        public int tempListCounter = 0;
        public string tempResourceString;

        #endregion

        #region Buildings Menu
        public Vector2 scrollPos = Vector2.zero;


        #endregion

        #region Runs Menu
        public bool equipmentStorageMenu;
        public bool sendATeamMenu;
        public bool activeRunsMenu;
        public bool memorialMenu;



        #endregion

        #region Tick Timer
        public float timer = 0f;
        public int dayCounter = 0;
        public float tickTimer = 0.2f;
        public bool canRunTick = true;
        #endregion


        #region Scripts
        public Resources resourceScript;
        public Buildings buildingScript;
        #endregion

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            scrX = Screen.width / 16f;
            scrY = Screen.height / 9f;



            if (canRunTick)
            {
                canRunTick = false;
                StartCoroutine("ResourceTick");
            }


        }

        private IEnumerator ResourceTick()
        {
            // T0 Resource
            if (resourceScript.nuyen.getUnlocked())
            {
                resourceScript.nuyen.amount += -(buildingScript.nutrientDispenser.resourceConsumption["Nuyen"] * buildingScript.nutrientDispenser.amount);
            }
            if (resourceScript.magicalReagents.getUnlocked())
            {
                resourceScript.magicalReagents.amount += (buildingScript.magicalSalvagingTable.resourceProduction["Magical Reagents"] * buildingScript.magicalSalvagingTable.amount) - (buildingScript.transmutationStation.resourceConsumption["Magical Reagents"] * buildingScript.transmutationStation.amount + buildingScript.magicalRefinery.resourceConsumption["Magical Reagents"] * buildingScript.magicalRefinery.amount);
            }
            if (resourceScript.junk.getUnlocked())
            {
                resourceScript.junk.amount += -(buildingScript.metalSalvagingTable.resourceConsumption["Junk"] * buildingScript.metalSalvagingTable.amount + buildingScript.magicalSalvagingTable.resourceConsumption["Junk"] * buildingScript.metalSalvagingTable.amount + buildingScript.recycler.resourceConsumption["Junk"] * buildingScript.recycler.amount + buildingScript.basicResearchBench.resourceConsumption["Junk"] * buildingScript.basicResearchBench.amount);
            }
            if (resourceScript.energy.getUnlocked())
            {
                resourceScript.energy.amount += (buildingScript.fuelGenerator.resourceProduction["Energy"] * buildingScript.fuelGenerator.amount) - (buildingScript.weaponsmith.resourceConsumption["Energy"] * buildingScript.weaponsmith.amount);
            }
            if (resourceScript.science.getUnlocked())
            {
                resourceScript.science.amount += (buildingScript.basicResearchBench.resourceProduction["Science"] * buildingScript.basicResearchBench.amount);
            }

            // T1 Resources
            if (resourceScript.foodstuff.getUnlocked())
            {
                resourceScript.foodstuff.amount += (buildingScript.nutrientDispenser.resourceProduction["Foodstuff"] * buildingScript.nutrientDispenser.amount);
            }
            if (resourceScript.metalScrap.getUnlocked())
            {
                resourceScript.metalScrap.amount += (buildingScript.metalSalvagingTable.resourceProduction["Metal Scrap"] * buildingScript.metalSalvagingTable.amount) - (buildingScript.smeltery.resourceConsumption["Metal Scrap"] * buildingScript.smeltery.amount + buildingScript.armory.resourceConsumption["Metal Scrap"] * buildingScript.armory.amount);
            }
            if (resourceScript.rareEarthMetals.getUnlocked())
            {
                resourceScript.rareEarthMetals.amount += (buildingScript.metalSalvagingTable.resourceProduction["Rare Earth Metals"] * buildingScript.metalSalvagingTable.amount) - (buildingScript.electronicsAssembly.resourceConsumption["Rare Earth Metals"] * buildingScript.electronicsAssembly.amount + buildingScript.electronicsAssemblyMicroprocessor.resourceConsumption["Rare Earth Metals"] * buildingScript.electronicsAssemblyMicroprocessor.amount);
            }
            if (resourceScript.plastic.getUnlocked())
            {
                resourceScript.plastic.amount += (buildingScript.recycler.resourceProduction["Plastic"] * buildingScript.recycler.amount);
            }

            // T2 Resources
            if (resourceScript.explosives.getUnlocked())
            {
                resourceScript.explosives.amount += (buildingScript.transmutationStation.resourceProduction["Explosives"] * buildingScript.transmutationStation.amount) - (buildingScript.ammunitionMill.resourceConsumption["Explosives"] * buildingScript.ammunitionMill.amount);
            }
            if (resourceScript.arcaneIngredients.getUnlocked())
            {
                resourceScript.arcaneIngredients.amount += (buildingScript.magicalRefinery.resourceProduction["Arcane Ingredients"] * buildingScript.magicalRefinery.amount);
            }
            if (resourceScript.steel.getUnlocked())
            {
                resourceScript.steel.amount += (buildingScript.smeltery.resourceProduction["Steel"] * buildingScript.smeltery.amount) - (buildingScript.smeltery.resourceConsumption["Steel"] * buildingScript.smeltery.amount + buildingScript.ammunitionMill.resourceConsumption["Steel"] * buildingScript.smeltery.amount);
            }
            if (resourceScript.compositeMetal.getUnlocked())
            {
                resourceScript.compositeMetal.amount += (buildingScript.smeltery.resourceProduction["Composite Metal"] * buildingScript.smeltery.amount);
            }


            // T3 Resources
            if (resourceScript.basicCircuitry.getUnlocked())
            {
                resourceScript.basicCircuitry.amount += (buildingScript.electronicsAssembly.resourceProduction["Basic Circuitry"] * buildingScript.electronicsAssembly.amount) - (buildingScript.droneFactory.resourceConsumption["Basic Circuitry"] * buildingScript.droneFactory.amount);
            }
            if (resourceScript.flakJackets.getUnlocked())
            {
                resourceScript.flakJackets.amount += (buildingScript.armory.resourceProduction["Flak Jacket"] * buildingScript.armory.amount) - (buildingScript.armoryCombatKit.resourceConsumption["Flak Jacket"] * buildingScript.armoryCombatKit.amount);
            }
            if (resourceScript.medkits.getUnlocked())
            {
                resourceScript.medkits.amount += (buildingScript.medicalLab.resourceProduction["Medkit"] * buildingScript.medicalLab.amount) - (buildingScript.armoryCombatKit.resourceConsumption["Medkit"] * buildingScript.armoryCombatKit.amount);
            }
            if (resourceScript.bullets.getUnlocked())
            {
                resourceScript.bullets.amount += (buildingScript.ammunitionMill.resourceProduction["Bullets"] * buildingScript.ammunitionMill.amount);
            }

            // T4 Resources
            if (resourceScript.drones.getUnlocked())
            {
                resourceScript.drones.amount += (buildingScript.droneFactory.resourceProduction["Drones"] * buildingScript.droneFactory.amount);
            }
            if (resourceScript.microprocessors.getUnlocked())
            {
                resourceScript.microprocessors.amount += (buildingScript.electronicsAssemblyMicroprocessor.resourceProduction["Microprocessors"] * buildingScript.electronicsAssemblyMicroprocessor.amount);
            }
            if (resourceScript.firearms.getUnlocked())
            {
                resourceScript.firearms.amount += (buildingScript.weaponsmith.resourceProduction["Firearms"] * buildingScript.weaponsmith.amount) - (buildingScript.droneFactoryCombatDrones.resourceConsumption["Firearms"] * buildingScript.droneFactoryCombatDrones.amount + buildingScript.armoryCombatKit.resourceConsumption["Firearms"] * buildingScript.armoryCombatKit.amount);
            }

            // T5 Resources
            if (resourceScript.cyberwear.getUnlocked())
            {
                resourceScript.cyberwear.amount += (buildingScript.augmentationManufactory.resourceProduction["Cyberwear"] * buildingScript.augmentationManufactory.amount);
            }
            if (resourceScript.combatDrones.getUnlocked())
            {
                resourceScript.combatDrones.amount += (buildingScript.droneFactoryCombatDrones.resourceProduction["Combat Drones"] * buildingScript.droneFactoryCombatDrones.amount);
            }
            if (resourceScript.combatKit.getUnlocked())
            {
                resourceScript.combatKit.amount += (buildingScript.armoryCombatKit.resourceProduction["Combat Kit"] * buildingScript.armoryCombatKit.amount);
            }

            // T6 Resources
            if (resourceScript.microdrones.getUnlocked())
            {
                resourceScript.microdrones.amount += (buildingScript.droneFactoryMicrodrones.resourceProduction["Microdrones"] * buildingScript.droneFactoryCombatDrones.amount);
            }


            canRunTick = true;
            yield return new WaitForSeconds(0.2f);

        }


        void OnGUI()
        {
            if (startMenu)
            {
                GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Main menu background");
                GUI.Box(new Rect(scrX * 3f, scrY * 1.5f, scrX * 10f, scrY * 3f), "Game Logo");
                if (GUI.Button(new Rect(scrX * 3.5f, scrY * 5.5f, scrX * 2.5f, scrY * 1f), "Start Game"))
                {
                    startMenu = false;
                    gameMenus = true;
                }
                if (GUI.Button(new Rect(scrX * 6.75f, scrY * 5.5f, scrX * 2.5f, scrY * 1f), "Load Game"))
                {

                }
                if (GUI.Button(new Rect(scrX * 10f, scrY * 5.5f, scrX * 2.5f, scrY * 1f), "Exit Game"))
                {
#if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
#else

                    Application.Quit();
#endif
                }
            }
            if (gameMenus)
            {
                // Top menu bar
                GUI.Box(new Rect(0, 0, Screen.width, scrY * 0.75f), "Top bar box");

                #region Resource box
                // Resource container
                GUI.Box(new Rect(0, scrY * 0.75f, scrX * 2.5f, scrY * 8.25f), "Resource box");
                tempListCounter = 0;
                foreach (Resources.Resource resource in Resources.resourceList)
                {
                    tempListCounter++;
                    if (resource.unlocked)
                    {
                        tempResourceString = resource.name + ": " + resource.amount + "/" + resource.resourceCap;
                        GUI.Box(new Rect(0.25f * scrX, 0.75f * scrY + 0.75f * tempListCounter, 2f * scrX, scrY * 0.75f), tempResourceString);
                    }
                }


                #endregion

                // Run Status and Feed
                GUI.Box(new Rect(scrX * 13.5f, scrY * 0.75f, scrX * 2.5f, scrY * 6f), "Run Status and Feed");

                // Rotating 3D object
                GUI.Box(new Rect(scrX * 13.5f, Screen.height - (scrX * 2.5f), scrX * 2.5f, scrX * 2.5f), "3D object");

                // Tooltip bar
                if (!runsMenu && !settingsMenu)
                {
                    GUI.Box(new Rect(scrX * 2.5f, scrY * 8.25f, scrX * 11f, scrY * 0.75f), "Tooltip");
                }

                // Temp guide for central container
                //GUI.Box(new Rect(scrX * 2.5f, scrY * 0.75f, scrX * 11f, scrY * 7.5f), "");



                #region Main Menu bar buttons
                if (GUI.Button(new Rect(0, 0, scrX * 2.5f, scrY * 0.75f), "Buildings"))
                {
                    buildingMenu = true;
                    automationMenu = false;
                    scienceMenu = false;
                    upgradeMenu = false;
                    runsMenu = false;
                    settingsMenu = false;
                    tradeMenu = false;
                }
                if (GUI.Button(new Rect(scrX * 2.5f, 0, scrX * 2.2f, scrY * 0.75f), "Automation"))
                {
                    buildingMenu = false;
                    automationMenu = true;
                    scienceMenu = false;
                    upgradeMenu = false;
                    runsMenu = false;
                    settingsMenu = false;
                    tradeMenu = false;
                }
                if (GUI.Button(new Rect(scrX * 4.7f, 0, scrX * 2.2f, scrY * 0.75f), "Science"))
                {
                    buildingMenu = false;
                    automationMenu = false;
                    scienceMenu = true;
                    upgradeMenu = false;
                    runsMenu = false;
                    settingsMenu = false;
                    tradeMenu = false;
                }
                if (GUI.Button(new Rect(scrX * 6.9f, 0, scrX * 2.2f, scrY * 0.75f), "Upgrades"))
                {
                    buildingMenu = false;
                    automationMenu = false;
                    scienceMenu = false;
                    upgradeMenu = true;
                    runsMenu = false;
                    settingsMenu = false;
                    tradeMenu = false;
                }
                if (GUI.Button(new Rect(scrX * 9.1f, 0, scrX * 2.2f, scrY * 0.75f), "Runs"))
                {
                    buildingMenu = false;
                    automationMenu = false;
                    scienceMenu = false;
                    upgradeMenu = false;
                    runsMenu = true;
                    settingsMenu = false;
                    tradeMenu = false;
                }
                if (GUI.Button(new Rect(scrX * 11.3f, 0, scrX * 2.2f, scrY * 0.75f), "Trade"))
                {
                    buildingMenu = false;
                    automationMenu = false;
                    scienceMenu = false;
                    upgradeMenu = false;
                    runsMenu = false;
                    settingsMenu = false;
                    tradeMenu = true;
                }
                if (GUI.Button(new Rect(scrX * 13.5f, 0, scrX * 2.5f, scrY * 0.75f), "Settings"))
                {
                    buildingMenu = false;
                    automationMenu = false;
                    scienceMenu = false;
                    upgradeMenu = false;
                    runsMenu = false;
                    settingsMenu = true;
                    tradeMenu = false;
                }
                #endregion

                #region Buildings
                if (buildingMenu)
                {
                    // Trying a scrollview, might be redundant with less buildings
                    //scrollPos = GUI.BeginScrollView(new Rect(scrX * 2.5f, scrY * 0.75f, scrX * 11f, scrY * 7.5f), scrollPos, new Rect();

                    GUI.Box(new Rect(scrX * 2.5f, scrY * 0.75f, scrX * 11f, scrY * 0.75f), "Buildings submenu");

                    GUI.Button(new Rect(scrX * 2.5f, scrY * 0.75f, scrX * 2f, scrY * 0.75f), "All buildings");
                    GUI.Button(new Rect(scrX * 4.75f, scrY * 0.75f, scrX * 2f, scrY * 0.75f), "Type 1");
                    GUI.Button(new Rect(scrX * 7f, scrY * 0.75f, scrX * 2f, scrY * 0.75f), "Type 2");
                    GUI.Button(new Rect(scrX * 9.25f, scrY * 0.75f, scrX * 2f, scrY * 0.75f), "Type 3");
                    GUI.Button(new Rect(scrX * 11.5f, scrY * 0.75f, scrX * 2f, scrY * 0.75f), "Type 4");



                }
                #endregion

                #region Automation
                if (automationMenu)
                {

                }
                #endregion

                #region Science
                if (scienceMenu)
                {

                }

                #endregion

                #region Upgrades
                if (upgradeMenu)
                {

                }

                #endregion

                #region Runs
                if (runsMenu)
                {
                    GUI.Box(new Rect(scrX * 2.5f, scrY * 0.75f, scrX * 11f, scrY * 0.75f), "");
                    #region Runs Submenu Buttons
                    if (GUI.Button(new Rect(scrX * 2.5f, scrY * 0.75f, scrX * 2.25f, scrY * 0.75f), "Equipment Storage"))
                    {
                        equipmentStorageMenu = true;
                        sendATeamMenu = false;
                        activeRunsMenu = false;
                        memorialMenu = false;
                    }
                    if (GUI.Button(new Rect(scrX * 5.4f, scrY * 0.75f, scrX * 2.25f, scrY * 0.75f), "Send A Team"))
                    {
                        equipmentStorageMenu = false;
                        sendATeamMenu = true;
                        activeRunsMenu = false;
                        memorialMenu = false;
                    }
                    if (GUI.Button(new Rect(scrX * 8.32f, scrY * 0.75f, scrX * 2.25f, scrY * 0.75f), "Active Runs"))
                    {
                        equipmentStorageMenu = false;
                        sendATeamMenu = false;
                        activeRunsMenu = true;
                        memorialMenu = false;
                    }
                    if (GUI.Button(new Rect(scrX * 11.25f, scrY * 0.75f, scrX * 2.25f, scrY * 0.75f), "Memorial"))
                    {
                        equipmentStorageMenu = false;
                        sendATeamMenu = false;
                        activeRunsMenu = false;
                        memorialMenu = true;
                    }
                    #endregion
                    // Temp background container box
                    GUI.Box(new Rect(scrX * 2.5f, scrY * 1.5f, scrX * 11f, scrY * 7.5f), "");

                    #region Runs Submenus
                    if (equipmentStorageMenu)
                    {
                        // Equipment Storage
                        GUI.Box(new Rect(scrX * 2.5f, scrY * 1.5f, scrX * 11f, scrY * 7.5f), "Item 1 | Class | Effect\nItem 2 | Class | Effect");
                    }
                    if (sendATeamMenu)
                    {
                        // Run jobs container
                        GUI.Box(new Rect(scrX * 2.5f, scrY * 1.5f, scrX * 2.25f, scrY * 3.75f), "Run Jobs temp box");
                        // Run Description
                        GUI.Box(new Rect(scrX * 2.5f, scrY * 5.25f, scrX * 2.25f, scrY * 1.875f), "Run Description");
                        // Estimated Duration of Run
                        GUI.Box(new Rect(scrX * 2.5f, scrY * 7.125f, scrX * 2.25f, scrY * 1.875f), "Estimated duration of run");

                        // Runners for Hire 
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 1.5f, scrX * 4f, scrY * 0.75f), "Runners for Hire");
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 2.25f, scrX * 4f, scrY * 3f), "Runner 1\nRunner 2");
                        // Runners on Job
                        GUI.Box(new Rect(scrX * 9.5f, scrY * 1.5f, scrX * 4f, scrY * 0.75f), "Runners On Job");
                        GUI.Box(new Rect(scrX * 9.5f, scrY * 2.25f, scrX * 4f, scrY * 3f), "Runner 1\nRunner 2");

                        // Arrows
                        GUI.Box(new Rect(scrX * 8.75f, scrY * 1.5f, scrX * 0.75f, scrY * 3.75f), "=>");
                        GUI.Box(new Rect(scrX * 8.75f, scrY * 5.25f, scrX * 0.75f, scrY * 3.75f), "=>");

                        // Company inventory
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 5.25f, scrX * 4f, scrY * 0.75f), "Company Inventory");
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 6f, scrX * 4f, scrY * 3f), "Runner 1\nRunner 2");
                        // Run inventory
                        GUI.Box(new Rect(scrX * 9.5f, scrY * 5.25f, scrX * 4f, scrY * 0.75f), "Runners On Job");
                        GUI.Box(new Rect(scrX * 9.5f, scrY * 6f, scrX * 4f, scrY * 3f), "Runner 1\nRunner 2");
                    }
                    if (activeRunsMenu)
                    {
                        // Team selection
                        GUI.Box(new Rect(scrX * 2.5f, scrY * 1.5f, scrX * 2.25f, scrY * 0.5f), "Team Selection");
                        GUI.Box(new Rect(scrX * 2.5f, scrY * 2f, scrX * 2.25f, scrY * 7.5f), "Team 1\nTeam 2\nTeam 3");
                        // Runner list
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 1.5f, scrX * 6.5f, scrY * 0.5f), "Runner List");
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 2f, scrX * 6.5f, scrY * 1f), "Runner 1\nRunner2\nRunner 3");
                        // Time until return
                        GUI.Box(new Rect(scrX * 11.25f, scrY * 1.5f, scrX * 2.25f, scrY * 0.5f), "Time Until Return");
                        GUI.Box(new Rect(scrX * 11.25f, scrY * 2f, scrX * 2.25f, scrY * 1f), "<time remaining>");


                        // Run Job
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 3f, scrX * 4.5f, scrY * 0.5f), "Run Job");
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 3.5f, scrX * 4.5f, scrY * 0.75f), "<Job title & brief description>");
                        // Run Location
                        GUI.Box(new Rect(scrX * 9.25f, scrY * 3f, scrX * 4.25f, scrY * 0.5f), "Run Location");
                        GUI.Box(new Rect(scrX * 9.25f, scrY * 3.5f, scrX * 4.25f, scrY * 0.75f), "<Location>");

                        // Equipment On Run
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 4.25f, scrX * 4.5f, scrY * 0.5f), "Equipment on Run");
                        GUI.Box(new Rect(scrX * 4.75f, scrY * 4.75f, scrX * 4.5f, scrY * 5f), "Equipment 1\nEquipment 2");

                        // Loot Gained
                        GUI.Box(new Rect(scrX * 9.25f, scrY * 4.25f, scrX * 4.25f, scrY * 0.5f), "Loot Gained");
                        GUI.Box(new Rect(scrX * 9.25f, scrY * 4.75f, scrX * 4.25f, scrY * 5f), "Loot 1\nLoot 2\nLoot 3");
                    }
                    if (memorialMenu)
                    {
                        // List of dead runners
                        GUI.Box(new Rect(scrX * 2.5f, scrY * 1.5f, scrX * 11f, scrY * 7.5f), "Dead Runner 1\nDead Runner 2");
                    }

                    #endregion



                }

                #endregion

                #region Settings
                if (settingsMenu)
                {


                    // Save game
                    if (GUI.Button(new Rect(scrX * 7f, scrY * 6f, scrX * 2.5f, scrY * 1f), "Save Game"))
                    {

                    }

                    // Exit Button
                    if (GUI.Button(new Rect(scrX * 7f, scrY * 7.5f, scrX * 2.5f, scrY * 1f), "Exit"))
                    {
#if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
#else

                        Application.Quit();
#endif
                    }
                }

                #endregion






            }
        }



    }
}