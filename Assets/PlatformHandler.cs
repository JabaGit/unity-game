using UnityEngine;

public class PlatformHandler : MonoBehaviour
{

    public Vector3 startPoint;
    public Vector3 endPoint;
    public float speed = 1f;
    
    void FixedUpdate()
    {
        
        transform.position = Vector3.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1.0f));
        
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
           
            other.transform.parent = transform;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
           

        }
    }

}
