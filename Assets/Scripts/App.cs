using UnityEngine;

public class App : MonoBehaviour {

    public MobileCamera MobileCamera;

    /**************************************************/

    #region Start

    private void Start() {
        MobileCamera.StartCam();
    }

    #endregion

}