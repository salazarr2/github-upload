 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = this.transform.position;
        print(pos);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        if(Input.GetKey(KeyCode.RightArrow)){
            pos.x += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            pos.x -= speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            pos.y += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            pos.y -= speed * Time.deltaTime;
        }
        this.transform.position = pos;
    }
}
