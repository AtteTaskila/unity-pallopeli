using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelaajakoodiAzzom : MonoBehaviour
public class KameraKoodi : MonoBehaviour
{
    public float nopeus;
    public Transform PelaajakoodiAzzom;
    Vector3 suunta;
    Rigidbody RB;
    // Start is called before the first frame update
    void Start(){
       RB = GetComponent <Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate(){
        suunta.x = Input.GetAxis("Horizontal");
        suunta.z = Input.GetAxis("Vertical");
        RB.AddForce(suunta * nopeus);
    }
}
