using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public Vector2 min;
    public Vector2 max;

    void FixedUpdate()
    {
        Vector3 smoothedPosition = target.position + offset;
       // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(smoothedPosition.x,min.x,max.x), Mathf.Clamp(smoothedPosition.y, min.y, max.y), smoothedPosition.z);
    }

}
