using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GPSManager : MonoBehaviour {

    public Text TxtLatitude;
    public Text TxtLongitude;
    public Text Status;
    public Text Text1;

    public static GPSManager Instance { get; set; }

    

     public static float Latitude;  //Enlem
     public static float Longitude; // Boylam

    /**************************************************/

    #region Start

    void Start() {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        StartCoroutine(StartLocationService());
    }

    #endregion
    
    #region LocationService: Start

    private IEnumerator StartLocationService() {
        if (!Input.location.isEnabledByUser) {
            Debug.LogWarning("GPS is not active!");
            yield break;
        }

        Input.location.Start(1f,1f);

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
            yield return new WaitForSeconds(1f);
            maxWait--;
        }

        if (maxWait <= 0) {
            Debug.LogWarning("Timed Out");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed) {
            Debug.LogWarning("Unable to determine device location");
            yield break;
        }


        
    }
    private void FixedUpdate()
    {
        Latitude = Input.location.lastData.latitude;
        Longitude = Input.location.lastData.longitude;

        TxtLatitude.text = $"Latitude: {(double)Latitude}";
        TxtLongitude.text = $"Longitude: {(double)Longitude}";
        Status.text =$"GPS Status: {Input.location.status}";
        
    }
    


    #endregion

}