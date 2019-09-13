using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Technologies : MonoBehaviour
{
    
    public class Science
    {
        public string scienceName;
        public int researchCost;
        public int nuyenCost;

        public bool unlocked = false;

        public string scienceToolTip;

        public Science(string name, int science, int cost)
        {
            scienceName = name;
            researchCost = science;
            nuyenCost = cost;
        }



    }







}
