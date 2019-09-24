using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Technologies : MonoBehaviour
{
    
    public class Science
    {
        public string scienceName;
        public Dictionary<string, float> researchCost;
        

        public bool unlocked = false;

        public string scienceToolTip;

        public Science(string name, Dictionary<string,float> cost, string tooltip)
        {
            scienceName = name;
            researchCost = cost;
            scienceToolTip = tooltip;


        }



    }







}
