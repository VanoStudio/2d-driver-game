using System.Data.Common;
using UnityEngine;

    public class Delivery : MonoBehaviour
    {
    bool hasPackage = false;
    
    [SerializeField] Color32 hasPackageColor = new Color32(107, 255, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Aduh Nabrak");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Packages") && !hasPackage)
        {
        Debug.Log("Pick Up Package");
        Destroy(other.gameObject);
        hasPackage = true;
        GetComponent<SpriteRenderer>().color = hasPackageColor;
        }

        if (other.CompareTag("Customer") && hasPackage)
        {
        Debug.Log("Package Delivered");
        hasPackage = false;
        GetComponent<SpriteRenderer>().color = noPackageColor;
        }
    }
}
