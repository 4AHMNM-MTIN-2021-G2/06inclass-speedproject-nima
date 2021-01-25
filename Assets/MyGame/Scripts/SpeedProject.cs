using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeedProject : MonoBehaviour
{
    public void LoadMain ()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadEnd()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void LoadIntro()
    {
        SceneManager.LoadScene("IntroScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
