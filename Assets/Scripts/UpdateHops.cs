using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class UpdateHops : MonoBehaviour
{
    [SerializeField]
    public Text numberOfHops;

    public GPSManager GPS;


    [SerializeField]
    public Text Clue;
    private static string Cluetext = "Reach Starting Point Padole Hospital Square";





    public static int hops;

    [SerializeField]
    public Text Xpscore;

    public static int xps;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    void Update()
    {
        Xpscore.text = xps.ToString();
        numberOfHops.text = hops.ToString();
        Clue.text = $"NEXT CLUE: {Cluetext}";
        
        
    }

    // Update is called once per frame
    public void Scoreplus()
    {
        xps = xps + 1000;
        hops = hops + 1;

        GPSManager.Latitude = Input.location.lastData.latitude;
        GPSManager.Longitude = Input.location.lastData.longitude;
    }

    public void Cluegeneratorshortpath()
    {

        if ((((double)21.112265 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.113339)) || (((double)79.047976 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.049337)))
        {

            Cluetext = "Walk Along The Same Path Towards The Direction In Which Sun Rises";
        }
        else if ((((double)21.112653 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.113777)) || (((double)79.053118 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.054346)))
        {
            Cluetext = "Near Square That Is Named After 13Th King Of Mewar";
        }
        else if ((((double)21.112706 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.114715)) || (((double)79.056094 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.057604)))
        {
            Cluetext = "Near First Hospital In Nagpur, That Is Licensed By FDA To Run Blood Storage Unit ";
        }
        else if ((((double)21.120201 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.122428)) || (((double)79.055315 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.057734)))
        {
            Cluetext = "Near First Hospital In Nagpur, That Is Licensed By FDA To Run Blood Storage Unit ";
        }
        else if ((((double)21.111190 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.113588)) || (((double)79.063888 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.066281)))
        {
            Cluetext = "Near Sqaure Named After Greatest Maratha Ruler";
        }
        else if ((((double)21.123736 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.125877)) || (((double)79.057174 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.060558)))
        {
            Cluetext = "Near First Hospital In Nagpur, That Is Licensed By FDA To Run Blood Storage Unit ";
        }
        else if ((((double)21.124849 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.127273)) || (((double)79.062704 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.065122)))
        {
            Cluetext = "Near First Hospital In Nagpur, That Is Licensed By FDA To Run Blood Storage Unit ";
        }
        else if ((((double)21.119478 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.121372)) || (((double)79.071302 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.074347)))
        {
            Cluetext = "Near Sqaure Named After Greatest Maratha Ruler";
        } else
        {
            Cluetext = "Wander Around";
        }
    }

    public void Cluegeneratorlongpath()
    {

        if ((((double)21.112265 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.113339)) || (((double)79.047976 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.049337)))
        {

            Cluetext = "Near Sqaure That Lies In Vicinity Of IIM, Nagpur";
        }
        else if ((((double)21.112653 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.113777)) || (((double)79.053118 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.054346)))
        {
            Cluetext = "Near Sqaure That Lies In Vicinity Of IIM, Nagpur";
        }
        else if ((((double)21.112706 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.114715)) || (((double)79.056094 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.057604)))
        {
            Cluetext = "Near Sqaure That Lies In Vicinity Of IIM, Nagpur";
        }
        else if ((((double)21.120201 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.122428)) || (((double)79.055315 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.057734)))
        {
            Cluetext = "Near Sqaure That Lies In The Vicinity Of Jewellery Shop Inaugurated By Katrina Kaif";
        }
        else if ((((double)21.111190 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.113588)) || (((double)79.063888 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.066281)))
        {
            Cluetext = "Near The Square Named After Only Prime Minister Of India Who Was Professional Pilot";
        }
        else if ((((double)21.123736 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.125877)) || (((double)79.057174 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.060558)))
        {
            Cluetext = "Walk 500m From Nearest Pizza Hut Towards The Direction In Which Earth Rotate";
        }
        else if ((((double)21.124849 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.127273)) || (((double)79.062704 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.065122)))
        {
            Cluetext = "Near The Square Named After Only Prime Minister Of India Who Was Professional Pilot";
        }
        else if ((((double)21.119478 < GPSManager.Latitude) && (GPSManager.Latitude < (double)21.121372)) || (((double)79.071302 < GPSManager.Longitude) && (GPSManager.Longitude < (double)79.074347)))
        {
            Cluetext = "Near First Hospital In Nagpur, That Is Licensed By FDA To Run Blood Storage Unit ";
        }
        else
        {
            Cluetext = "Wander Around";
        }
    }
    public void Scoreminus()
    {
        xps = xps - 1000;
        hops = hops + 1;
        
    }
    
}
