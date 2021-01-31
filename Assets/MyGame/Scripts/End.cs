using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    public ScriptObject myObject;
    public Text name;
    public Text timer;
    public Text randomValue;
    public Text valueText;
    public Text feedback;
    public float timeStop;


    // Start is called before the first frame update
    void Start()
    {
        name.text = myObject.name;
        valueText.text = myObject.randomValue.ToString("f2");
        timer.text = myObject.time.ToString("f2");

        timeStop = myObject.time;

        if (timeStop < 3)
        {
            feedback.text = "Spitze!!";
        }
        else if (timeStop < 6)
        {
            feedback.text = "Das geht schneller!";
        }
        else
        {
            feedback.text = "Zu langsam...";
        }

    }

    public void Reset()
    {
        myObject.name = "";
        myObject.randomValue = 0;
        myObject.time = 0;
        SceneManager.LoadScene("IntroScene");
    }
}
