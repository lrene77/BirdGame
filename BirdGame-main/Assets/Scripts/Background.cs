using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour // MonoBehaviour�� ��ӹ޾ƾ���
{
    public float speed = 3; //�ν����Ϳ��� ����� ���� �켱
    public float size = 19.2f;

    // Start is called before the first frame update �����Ҷ� �ѹ��� ����
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //�� �����Ӹ��� ����
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime); // Translate ��ü�� ȭ�鿡�� �����̰ڴ�.

        if (transform.position.x < -size)
        {
            transform.Translate(new Vector3(size * 2, 0, 0));
        }
    }
}
