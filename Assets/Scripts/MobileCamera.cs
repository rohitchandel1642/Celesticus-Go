using UnityEngine;
using UnityEngine.UI;

public class MobileCamera : MonoBehaviour {

    private WebCamDevice _cam;
    private WebCamTexture _texture;

    public RawImage Display;

    private int _currentCamIndex = 0;

    /**************************************************/

    void Start() {
        Init();
    }


    private void Init() {
        SetCam(0);
    }


    public void StartCam() {
        if (!HasCam()) {
            return;
        }

        _texture = new WebCamTexture(_cam.name);
        Display.texture = _texture;

        _texture.Play();
    }

    public void StopCam() {
        if (_texture == null) {
            return;
        }

        Display.texture = null;
        _texture.Stop();
        _texture = null;
    }


    public void PrevCam() {
        if (!HasCam()) {
            return;
        }

        _currentCamIndex--;
        if (_currentCamIndex < 0) {
            _currentCamIndex = 0;
        }
        SetCam(_currentCamIndex);

        StopCam();
        StartCam();
    }

    public void NextCam() {
        if (!HasCam()) {
            return;
        }

        _currentCamIndex++;
        if (_currentCamIndex >= WebCamTexture.devices.Length) {
            _currentCamIndex = WebCamTexture.devices.Length - 1;
        }

        SetCam(_currentCamIndex);

        StopCam();
        StartCam();
    }


    private void SetCam(int camIndex) {
        if (!HasCam()) {
            return;
        }

        _cam = WebCamTexture.devices[camIndex];
    }

    private bool HasCam() {
        return WebCamTexture.devices.Length > 0;
    }

}