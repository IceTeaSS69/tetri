using UnityEngine;
using UnityEngine.UI;

public class GOmenu : MonoBehaviour
{
    

    private void Start()
    {
        DestroySc.IsBlockTouched = false;
        DestroySc.Endtouch = false;
        DestroySc.IsPlateTouched = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            DestroySc.IsBlockTouched = true;
        }
        else
        {
            Debug.Log("SpawnDelet");
        }
        if (collision.gameObject.CompareTag("Plate"))
        {
            DestroySc.IsPlateTouched = true;
        }
        else
        {
            Debug.Log("SpawnDelet");
        }
        if (collision.gameObject.CompareTag("End"))
        {
            DestroySc.Endtouch = true;
            Time.timeScale = 0f;

        }
        
    }

}
