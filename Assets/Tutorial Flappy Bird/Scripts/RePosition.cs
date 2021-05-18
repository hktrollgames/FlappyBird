using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RePosition : MonoBehaviour
{
    public float minX;
    public float width;

    private void Start()
    {
        var spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        width = spriteRenderer.sprite.bounds.size.x * transform.lossyScale.x;
        //minX = -width;
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ��ġ���� �ڷ� ���ٸ� ������ �̵���Ű��
        if (transform.position.x < minX)
        {
            transform.Translate(width * 2, 0, 0);
        }
    }
}
