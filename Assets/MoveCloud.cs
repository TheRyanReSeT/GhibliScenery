using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{


    public float moveSpeed;
    public float deadZone = -1;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        //remove pipe
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
