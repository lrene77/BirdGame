using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour // MonoBehaviour를 상속받아야함
{
    public float speed = 3; //인스펙터에서 적용된 값이 우선
    public float size = 19.2f;

    // Start is called before the first frame update 시작할때 한번만 실행
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //매 프레임마다 실행
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime); // Translate 물체를 화면에서 움직이겠다.

        if (transform.position.x < -size)
        {
            transform.Translate(new Vector3(size * 2, 0, 0));
        }
    }
}
