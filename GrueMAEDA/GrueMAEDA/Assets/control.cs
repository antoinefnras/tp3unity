using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float forceCrochet = 1200f;
    public ArticulationBody crochet;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            crochet.AddRelativeForce(transform.up * -forceCrochet);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            crochet.AddRelativeForce(transform.up * forceCrochet);
        }
    }
}
