using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition_To_InstructionScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void JumpToInstructionScene()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
}