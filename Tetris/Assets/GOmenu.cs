using UnityEngine;
using UnityEngine.UI;

public class GOmenu : MonoBehaviour
{
    

    private void Start()
    {
        DestroySc.IsBlockTouched = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plate") || collision.gameObject.CompareTag("Block"))
        {
           DestroySc.IsBlockTouched = true;
        }
        else if (collision.gameObject.CompareTag("End"))
        {
            DestroySc.Endtouch = true;
            
        }
    }
}
