using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{ 
    public ScriptObject myObject;
    public Text name;
    public Text timer;
    public Text randomValue;

    // Start is called before the first frame update
    void Start()
    {
        name.text = myObject.name;  
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = Time.timeSinceLevelLoad.ToString("f2");
    }

    public void Generator()
    {
        float value = Random.Range(1.0f, 10.0f);
        randomValue.text = value.ToString();
        myObject.randomValue = value;
    }

    public void LoadScene()
    {
        if(myObject.randomValue != 0)
        {
            myObject.time = Time.timeSinceLevelLoad;
            SceneManager.LoadScene("EndScene");
        }
    }

}


