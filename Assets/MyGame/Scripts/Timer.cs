using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Timer.time;    
    }

    // Update is called once per frame
    void Update()
    {
        float time = Timer.time - startTime;

        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString();

        timer.text = minutes + ":" + seconds;
    }
}
