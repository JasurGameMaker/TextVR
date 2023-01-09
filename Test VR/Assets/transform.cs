using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            speed = 5f;
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, 0.5f, 0);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            StartCoroutine(Stop());
        }
    }

    IEnumerator Stop()
    {
        float b = 5;
        for (int i = 0; i < 50; i++)
        {
            speed = b;
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, 0.5f, 0);
            b -= 0.3f;
            yield return new WaitForSeconds(0.01f);
            if (b <= 0)
            {
                break;
            }
            print(1);
        }
    }

}
