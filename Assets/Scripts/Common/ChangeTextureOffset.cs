using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextureOffset : MonoBehaviour
{
    public float offsetX = 1;
    Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // 커밋이랑 푸시 동시에
    void Update()
    {
        var offset = material.mainTextureOffset;
        offset.x += offsetX * Time.deltaTime;
        material.mainTextureOffset = offset;
    }
}
