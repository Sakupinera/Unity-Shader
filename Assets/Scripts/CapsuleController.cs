using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        // float MouseInputX = Input.GetAxis("MouseX");

        Vector3 displacement = new Vector3(inputX * speed * Time.deltaTime, 0, inputZ * speed * Time.deltaTime);

        this.transform.Translate(displacement);
    }
}
