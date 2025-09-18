using UnityEngine;
using System;
using NUnit.Framework;
using System.Collections.Generic;
public class carmovement : MonoBehaviour
{
    public enum axel { front, rear }
   [Serializable]
    public struct wheel
    {
        public GameObject wheelmodel;
        public WheelCollider wheelcollider;
        public axel axel;
    }
    public float maxAcceleration = 30f;
    public float maxbreakforce = 50f;
    public List<wheel> wheels;
    float movementinput;
    private Rigidbody carrb;
        void Start()
    {
        carrb = GetComponent<Rigidbody>();
    }
    void Update()
    {
     getinputs();
    }
    private void LateUpdate()
    {
        move();
    }
    void getinputs()
    {         movementinput = Input.GetAxis("Vertical"); }
    void move()
    {
        foreach (var wheel in wheels)
        {
            wheel.wheelcollider.motorTorque = movementinput * maxAcceleration * Time.deltaTime; 
        }
    }
}
