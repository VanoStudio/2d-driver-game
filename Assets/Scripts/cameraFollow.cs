using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject target;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            target.transform.position.x,
            target.transform.position.y,
            target.transform.position.z -10f);


        
    }
}
