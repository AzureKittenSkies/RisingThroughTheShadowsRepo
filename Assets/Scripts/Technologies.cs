using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Technologies : MonoBehaviour
{
    
    public class Science
    {
        public string scienceName;
        public Dictionary<string, float> researchCost;
        public Dictionary<string, bool> nextScienceUnlocked;
        

        public bool unlocked = false;

        public string scienceToolTip;

        public Science(string name, string tooltip, Dictionary<string,float> cost, Dictionary<string,bool> nextTech)
        {
            scienceName = name;
            researchCost = cost;
            scienceToolTip = tooltip;
            nexxtScienceUnlocked = nextTech;
        }
    }

    public Science runs = new Science("Runs", "Not those kinds of runs, but can get just as messy...",
        new Dictionary<string, float> { { "Nuyen", 50f} },
        new Dictionary<string, bool> { { "Magical Decomposition", false}, { "Metallic Sorting", false} });

    public Science magicalDecomposition = new Science("Magical Decomposition", "Turn those weird gooey things into actual stuff to use!",
        new Dictionary<string, float> { { "Nuyen", 75f }, { "Junk", 150f } },
        new Dictionary<string, bool> { { "Basic Magical Research", false }, { "Basic Research", false } });

    //public Science 









}
