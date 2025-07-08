using UnityEditor.Search.Providers;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public void update()
    {
        
    }
    public void RestartLevel()
    {
        
                
                    

                    SceneManager.LoadScene("Scene1");
                
    }
}
