using UnityEngine;
using UnityEngine.UI;

public class GOmenu : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Plate"))
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Plate"))
        {
            Destroy(collider.gameObject);
            Time.timeScale = 0f;
        }
    }
}
