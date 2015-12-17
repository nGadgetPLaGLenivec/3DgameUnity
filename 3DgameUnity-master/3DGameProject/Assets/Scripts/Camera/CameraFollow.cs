using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;            // The position that that camera will be following.
        public float smoothing = 5f;        // The speed with which the camera will be following.
        private float x = 0.0f; //Угол поворота по Y? 
        private float y = 0.0f;
        public float xSpeed = 125.0f; //Чуствительность по Х 
        public float ySpeed = 50.0f;
        public float distance = 3.0f;
        public float targetHeight = 2.0f; 
       // Vector3 offset;                     // The initial offset from the target.


        void Start ()
        {
            // Calculate the initial offset.

            //offset = transform.position - target.position;
        }


        void FixedUpdate ()
        {
            // Create a postion the camera is aiming for based on the offset from the target.
            //Vector3 targetCamPos = target.position + offset;
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            transform.rotation = rotation;
            // Smoothly interpolate between the camera's current position and it's target position.
            transform.position = rotation * new Vector3(0.0f, targetHeight + 0.5f, -distance) + target.position;//Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
        }
    }
}