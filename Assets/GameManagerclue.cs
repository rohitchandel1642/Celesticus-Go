using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerclue : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;
    
    [SerializeField]
    private Text factText;

    public UpdateHops updateHops;

    
    

    [SerializeField]
    private Text optionText1;

    [SerializeField]
    private Text optionText2;

    [SerializeField]
    private Text optionText3;

    [SerializeField]
    private Text optionText4;

    [SerializeField]
    private float timeBetweenQuestions = 1f;
    
    
    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();

        updateHops = new UpdateHops();
        

    }
    
    void SetCurrentQuestion()
    {
        int RandomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[RandomQuestionIndex];

        unansweredQuestions.RemoveAt(RandomQuestionIndex);
        factText.text = currentQuestion.fact;
        optionText1.text = currentQuestion.optionText1;
        optionText2.text = currentQuestion.optionText2;
        optionText3.text = currentQuestion.optionText3;
        optionText4.text = currentQuestion.optionText4;

        
    }

    IEnumerator TransitionToNextScene()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

       
    }
    public void UserSelect()
    {
        if(currentQuestion.isTrue == 0)
        {
            Debug.Log("correct1");
            updateHops.Scoreplus();
            updateHops.Cluegeneratorshortpath();

        } else
        {
            Debug.Log("Wrong1");
            updateHops.Scoreminus();
            updateHops.Cluegeneratorlongpath();

        }
        StartCoroutine(TransitionToNextScene());
        SceneManager.LoadScene(2);
    }
    public void UserSelect1()
    {
        if (currentQuestion.isTrue == 1)
        {
            Debug.Log("correct2");
            updateHops.Scoreplus();
            updateHops.Cluegeneratorshortpath();

        }
        else
        {
            Debug.Log("Wrong2");
            updateHops.Scoreminus();
            updateHops.Cluegeneratorlongpath();
        }
        StartCoroutine(TransitionToNextScene());
        SceneManager.LoadScene(2);
    }
    public void UserSelect2()
    {
        if (currentQuestion.isTrue == 2)
        {
            Debug.Log("correct3");
            updateHops.Scoreplus();
            updateHops.Cluegeneratorshortpath();
        }
        else
        {
            Debug.Log("Wrong3");
            updateHops.Scoreminus();
            updateHops.Cluegeneratorlongpath();
        }
        StartCoroutine(TransitionToNextScene());
        SceneManager.LoadScene(2);
    }
    public void UserSelect3()
    {
        

        if (currentQuestion.isTrue == 3)
        {
            Debug.Log("correct4");
            updateHops.Scoreplus();
            updateHops.Cluegeneratorshortpath();
        }
        else
        {
            Debug.Log("Wrong4");
            updateHops.Scoreminus();
            updateHops.Cluegeneratorlongpath();
        }
        StartCoroutine(TransitionToNextScene());
        SceneManager.LoadScene(2);
    }
}
