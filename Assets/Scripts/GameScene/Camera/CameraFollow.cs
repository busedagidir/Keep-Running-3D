using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

   [SerializeField] private Transform player;
   public Vector3 offset;

   // Update is called once per frame
   void Update()
   {
       transform.position = player.position + offset;

   }



    //******************************************************************

    //public GameObject object;
    //Vector3 distance;

    //void Start()
    //{
    //    distance = transform.position - object.transform.position;
    //}

    //void LateUpdate()
    //{
    //    transform.position = object.transform.position + distance;
    //}

    //********************************************************************

    ////kamera bu target ı takip edecek
    //public Transform _target;

    //public Transform _camTransform;

    ////target ve cam arası mesafe
    //public Vector3 _offset;

    //public float _smoothTime = 0.125f;

    //private Vector3 _velocity = Vector3.zero;

    //private void Start()
    //{
    //    _offset = _camTransform.position - _target.position;
    //}

    //private void LateUpdate()
    //{
    //    //kameranın pozisyonunu güncelliyoruz
    //    if(_target != null)
    //    {
    //        Vector3 _targetPosition = _target.position + _offset;
    //        _camTransform.position = Vector3.SmoothDamp(transform.position, _targetPosition, ref _velocity, _smoothTime);
    //        //_camTransform.position = Vector3.Lerp(transform.position, _targetPosition, _smoothTime);
    //        transform.LookAt(_target);
    //    }
    //    else
    //    {
    //        _camTransform.position = transform.position;
    //    }

    //}

    //void Update()
    //{
    //    // if target öldüyse you lost screen çıksın
    //}

}
