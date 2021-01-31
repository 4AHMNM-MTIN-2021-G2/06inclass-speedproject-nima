using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeedProject : MonoBehaviour
{
    public InputField InputField;
    public Button nextSceneBtn;
    public Color red;
    public Text yourName;
  

    public void LoadScene ()
    {
        if(InputField.GetComponent<InputField>().text == "")
            {
            InputField.GetComponent<Image>().color = Color.red;
            }
        else
            {
               yourName.name = InputField.GetComponent<InputField>().text;
                SceneManager.LoadScene("MainScene");
            }
        
           
    }


    
        
    }



