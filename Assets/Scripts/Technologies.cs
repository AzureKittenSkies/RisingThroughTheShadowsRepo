using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Technologies : MonoBehaviour
{

    public class Science
    {
        public string scienceName;
        public Dictionary<string, float> researchCost;
        public Dictionary<string, bool> scienceDependencies;
        public Dictionary<string, bool> nextSciences;


        public bool unlocked;
        public bool researched;

        public string scienceToolTip;

        //once tech is researched, unlock next techs held in the classobject
        public Science(string name, string tooltip, bool isAvailable, bool isResearched, Dictionary<string, float> cost, Dictionary<string, bool> sciencesNeeded, Dictionary<string, bool> nextTech)
        {
            scienceName = name;
            scienceToolTip = tooltip;
            unlocked = isAvailable;
            researched = isResearched;
            researchCost = cost;
            scienceDependencies = sciencesNeeded;
            nextSciences = nextTech;
        }

        //Sciences that don't have something else unlocked after it's researched (No dependant sciences)
        public Science(string name, string tooltip, bool isAvailable, bool isResearched, Dictionary<string, float> cost, Dictionary<string, bool> sciencesNeeded)
        {
            scienceName = name;
            scienceToolTip = tooltip;
            unlocked = isAvailable;
            researched = isResearched;
            researchCost = cost;
            scienceDependencies = sciencesNeeded;
        }

    }

    public Science runs = new Science("Runs", "Not those kinds of runs, but can get just as messy...", true, false,
        new Dictionary<string, float> { { "Nuyen", 50f } },
        new Dictionary<string, bool> { { "None", true } },
        new Dictionary<string, bool> { { "Magical Decomposition", false }, { "Metallic Sorting", false } });

    public Science magicalDecomposition = new Science("Magical Decomposition", "Turn those weird gooey things into actual stuff to use!", false, false,
        new Dictionary<string, float> { { "Nuyen", 75f }, { "Junk", 150f } },
        new Dictionary<string, bool> { { "Runs", false } },
        new Dictionary<string, bool> { { "Basic Magical Decomposition", false }, { "Basic Research", false } });

    public Science basicMagicalResearch = new Science("Basic Magical Research", "Put on your robe and your wizard hat!", false, false,
        new Dictionary<string, float> { { "Nuyen", 100f }, { "Magical Reagents", 75f } },
        new Dictionary<string, bool> { { "Magical Decomposition", false } },
        new Dictionary<string, bool> { { "Synthesis", false }, { "Industrial Rsearch", false } });

    public Science metallicSorting = new Science("Metallic Sorting", "Ooooh, shiny~", false, false,
        new Dictionary<string, float> { { "Nuyen", 150 }, { "Junk", 175 } },
        new Dictionary<string, bool> { { "Runs", false } },
        new Dictionary<string, bool> { { "Metallic Sorting", false } });

    public Science basicResearch = new Science("Basic Research", "A little more complicated than your childhood science kit. And a lot more explosive.", false, false,
        new Dictionary<string, float> { { "Nuyen", 250f }, { "Junk", 250f } },
        new Dictionary<string, bool> { { "Magical Decomposition", false }, { "Metallic Sorting", false } },
        new Dictionary<string, bool> { { "Mobility", false }, { "Basic Electronics", false }, { "Reusability", false }, { "Military Aquisition", false }, { "Back Room Storage", false } });

    public Science mobility = new Science("Mobility", "Those cars won't make themselves!", false, false,
        new Dictionary<string, float> { { "Science", 275f }, { "Nuyen", 250f } },
        new Dictionary<string, bool> { { "Basic Research", false } },
        new Dictionary<string, bool> { { "Basic Research", false } });

    public Science basicElectronics = new Science("Basic Electronics", "We've made a spinny thing with a battery and a copper wire", false, false,
        new Dictionary<string, float> { { "Science", 300f }, { "Nuyen", 150f } },
        new Dictionary<string, bool> { { "Basic Research", false } },
        new Dictionary<string, bool> { { "Robotics", false }, { "Residence", false }, { "Power Generation", false } });

    public Science reusability = new Science("Reusability", "Reduce, reuse, recycle!", false, false,
        new Dictionary<string, float> { { "Science", 315f }, { "Nuyen", 175f } },
        new Dictionary<string, bool> { { "Basic Research", false } });

    public Science militaryAquisition = new Science("Military Aquisition", "It fell off the back of a truck, officer! I swear!", false, false,
        new Dictionary<string, float> { { "Science", 300f }, { "Nuyen", 350f } },
        new Dictionary<string, bool> { { "Basic Research", false } },
        new Dictionary<string, bool> { { "Military Production", false }, { "Communication", false } });

    public Science backRoomStorage = new Science("Back Room Storage", "Throw things in the spare room and call it a day.", false, false,
        new Dictionary<string, float> { { "Science", 300f }, { "Nuyen", 200f } },
        new Dictionary<string, bool> { { "Basic Research", false } },
        new Dictionary<string, bool> { { "Warehousing", false } });

    public Science synthesis = new Science("Synthesis", "It's like real alchemy!", false, false,
        new Dictionary<string, float> { { "Science", 200f }, { "Magical Reagents", 150f } },
        new Dictionary<string, bool> { { "Basic Magical Research", false } },
        new Dictionary<string, bool> { { "Medicines", false }, { "Industrial Research", false } });

    public Science robotics = new Science("Robotics", "[BEEP BOOP]", false, false,
        new Dictionary<string, float> { { "Science", 375f }, { "Basic Circuitry", 200f } },
        new Dictionary<string, bool> { { "Basic Electronics", false } },
        new Dictionary<string, bool> { { "Advanced Circuitry", false } });

    public Science residence = new Science("Residence", "Little houses for all your little meeples", false, false,
        new Dictionary<string, float> { { "Science", 375f }, { "Nuyen", 400f } },
        new Dictionary<string, bool> { { "Basic Electronics", false} });

    public Science powerGeneration = new Science("Power Generation", "And on the n-th day, there was light!", false, false,
        new Dictionary<string, float> { { "Science", 400f } },
        new Dictionary<string, bool> { { "Basic Electronics", false } },
        new Dictionary<string, bool> { { "Industrial Research", false }, { "Power Storage", false } });

    public Science militaryProduction = new Science("Military Production", "It might not be perfect, but you can still use it as a club I guess!", false, false,
        new Dictionary<string, float> { { "Science", 425f } },
        new Dictionary<string, bool> { { "Military Aquisition", false } },
        new Dictionary<string, bool> { { "Industrial Research", false }, { "Military Automation", false } });

    public Science communication = new Science("Communication", "Mobile phones are a thing of the past in the age of universal VR", false, false,
        new Dictionary<string, float> { { "Science", 400f } },
        new Dictionary<string, bool> { { "Military Aquisition", false } },
        new Dictionary<string, bool> { { "Outpost Establishment", false } });

    public Science warehousing = new Science("Warehousing", "When your spare room isn't big enough for all that junk", false, false,
        new Dictionary<string, float> { { "Science", 375f } },
        new Dictionary<string, bool> { { "Back Room Storage", false } });

    public Science powerStorage = new Science("Power Storage", "", false, false,
        new Dictionary<string, float> { { "Science", 400f } },
        new Dictionary<string, bool> { { "Power Generation", false } },
        new Dictionary<string, bool> { { "Military Automation", false } });








}
