using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition_To_winscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SceneManager.LoadScene(4);
    }
}
