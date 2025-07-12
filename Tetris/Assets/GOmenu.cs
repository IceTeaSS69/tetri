using UnityEngine;
using UnityEngine.UI;

public class GOmenu : MonoBehaviour
{
    public int current = 0;
  
    public GameObject[] blocks;
    public float fallSpeed = 3;
    public Vector3 SpaPosition;
    
    public int blockInt = 0;
    public void Spawn()
    {
        current = (current + 1) % blocks.Length;
        blockInt++;
        blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
    }
    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.CompareTag("Plate"))
    //    {
    //        Spawn();
    //    }
    //    else
    //    {
    //        Debug.Log("Error");
    //    }
    //}
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("End"))
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
        }
        else if (collision.gameObject.CompareTag("Plate"))
        {
            Spawn();
        }
        else if (collision.gameObject.CompareTag("Block"))
        {
            Spawn();
        }
        else
        {
            Debug.Log("Error2");
        }
    }
    //private void OnTriggerEnter2D(Collider2D collider)
    //{
    //    if (collider.gameObject.CompareTag("End"))
    //    {
    //        Destroy(collider.gameObject);
    //        Time.timeScale = 0f;
    //    }
    //    else if (collider.gameObject.CompareTag("Plate"))
    //    {
    //        Spawn();
    //    }
    //    else if (collider.gameObject.CompareTag("Block"))
    //    {
    //        Spawn();
    //    }
    //     else
    //    {
    //        Debug.Log("Error2");
    //    }
    //}
}
