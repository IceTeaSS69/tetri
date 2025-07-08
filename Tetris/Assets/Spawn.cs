using UnityEngine;
using UnityEngine.UI;
public class Spawn : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        button.interactable = (Time.timeScale == 0);
        button.image.enabled = (Time.timeScale == 0);
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(Time.timeScale == 0);
        }
    }
}

