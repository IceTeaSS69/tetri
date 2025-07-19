using UnityEngine;
using UnityEngine.UI;
public class Spawn : MonoBehaviour
{
    public GameObject blockPrefab;
    private Button button;
    private static bool spawned = false;

    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        bool isPaused = (Time.timeScale == 0);
        button.interactable = isPaused;
        button.image.enabled = isPaused;

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(isPaused);
        }

        if (isPaused && !spawned)
        {
            Instantiate(blockPrefab, transform.position, Quaternion.identity);
            spawned = true;
        }
        if (!isPaused)
        {
            spawned = false;
        }
    }
}

