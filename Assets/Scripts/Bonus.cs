using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bonus : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        if (UpdateHops.hops < 6)
        {
            UpdateHops.xps = UpdateHops.xps + 3000;
        }
        else if((UpdateHops.hops < 9) && (UpdateHops.hops > 6))
        {
             UpdateHops.xps = UpdateHops.xps + 2000;
        }
        else if (UpdateHops.hops > 9)
        {
            UpdateHops.xps = UpdateHops.xps + 1000;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
