using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GODestroyer : MonoBehaviour
{
    public float minX = int.MinValue;
    // 이건 아직 작업중이라서 올려선 안되는거
    void Update()
    {
        if (transform.position.x < minX)
            Destroy(gameObject);
    }


    // 이건 5월 20일에 강의할 내용
    // 이건 마스터 브랜치에 올려햘 할내용
}
