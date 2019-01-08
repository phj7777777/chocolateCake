using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class quiz : MonoBehaviour {
    public TextMeshProUGUI  question;
    public TextMeshProUGUI score;
    public TextMeshProUGUI a;
    public TextMeshProUGUI b;
    public TextMeshProUGUI c;
    public GameObject button;
    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject buttonC;
    public TextMeshProUGUI finalScore;
    public AudioSource wrong;
    public AudioSource success;
    int scorePoint = 0;
    int index = 0;

    string[] questions = {
                             "1. How many gram of butter need to bake?",
                             "2. Do you need to preheat oven before start baking?",
                             "3. How long does it took to bake cake?",
                             "4. What is the suggested temperature to bake cake?",
                             "5. How may egg needed to bake?"
                         
                         };
    string[] choiceA = { "200", "No", "15", "200", "3" };
    string[] choiceB = { "150", "Yes", "200", "160", "2" };
    string[] choiceC = { "1", "Maybe", "150", "-160", "1" };
    string[] answer = { "a", "b", "c", "b", "a" };

	// Use this for initialization
	void Start () {

        button.SetActive(false);
        question.text = questions[index];
        a.text = "A. "+ choiceA[index];
        b.text = "B. "+ choiceB[index];
        c.text = "C. "+ choiceC[index];
        score.text = "Score: "+ scorePoint + "/5";
	}
	
	// Update is called once per frame
	public void nextQuestion(string x) {
        if (index < 4)
        {
            index++;
            question.text = questions[index];
            a.text = "A. " + choiceA[index];
            b.text = "B. " + choiceB[index];
            c.text = "C. " + choiceC[index];

            if (x == answer[index - 1])
            {
                success.Play();
                scorePoint++;
            }
            else {
                wrong.Play();
            }
            score.text = "Score: " + scorePoint + "/5";

        }
        else if(index ==4){
            question.text = "";
            a.text = "";
            b.text = "";
            c.text = "";
            buttonA.SetActive(false);
            buttonB.SetActive(false);
            buttonC.SetActive(false);
            if (x == answer[index]) scorePoint++;
            score.text = "Score: " + scorePoint + "/5";

            if (scorePoint > 2)
            {
                finalScore.text = "Congrats! U get " + scorePoint + "/5!!!";
            }
            else {
                finalScore.text = "Need to put some effort! U get " + scorePoint + "/5!!!";
            }

            button.SetActive(true);
        }
       
       
	}
  
}
