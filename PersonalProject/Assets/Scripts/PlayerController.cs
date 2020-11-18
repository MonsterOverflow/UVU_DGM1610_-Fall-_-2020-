using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public GameObject projectilePrefab;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");

      transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);  

      if(transform.position.x < 4)
      {
          transform.position = new Vector3(4, transform.position.y, transform.position.z);
      }
      if(transform.position.x > 15)
      {
          transform.position = new Vector3(15, transform.position.y, transform.position.z);
      }
      if(Input.GetKeyDown(KeyCode.Space))
      {
          Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
      }
    }
}