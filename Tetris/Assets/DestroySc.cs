using UnityEngine;

public class DestroySc : MonoBehaviour
{
    public GameObject GranitsaPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == GranitsaPrefab)
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject == GranitsaPrefab)
        {
            Destroy(collider.gameObject);
            Time.timeScale = 0f;
        }
    }
}
