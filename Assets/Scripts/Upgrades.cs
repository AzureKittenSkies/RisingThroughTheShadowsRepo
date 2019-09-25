using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{

    public class Upgrade
    {
        public string upgradeName;
        public Dictionary<string, float> researchCost;
        
        

        public Upgrade(string name, Dictionary<string, float> cost)
        {
            upgradeName = name;
            researchCost = cost;
        }




    }


}
