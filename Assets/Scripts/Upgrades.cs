using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{

    public class Upgrade
    {
        public string upgradeName;
        public int researchCost;
        

        public Upgrade(string name, int science)
        {
            upgradeName = name;
            researchCost = science;
        }




    }


}
