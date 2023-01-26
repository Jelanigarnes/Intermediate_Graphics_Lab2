using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab2_Lighting : MonoBehaviour
{
    public List<Material> materials = new List<Material>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) 
        { 
            this.gameObject.GetComponent<MeshRenderer>().material = materials[0];
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[1];
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[2];
        }
        else if(Input.GetKey(KeyCode.Alpha4))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[3];
        }
        else if(Input.GetKey(KeyCode.Alpha5))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[4];
        }
        else if(Input.GetKey(KeyCode.Alpha6))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[5];
        }
    }
}
