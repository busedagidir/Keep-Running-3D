using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform _camTransform;
    private Vector3 offset;

   void Start()
   {
       offset = _camTransform.position - player.position;
   }

   void Update()
   {
       transform.position = player.position + offset;

   }
}
