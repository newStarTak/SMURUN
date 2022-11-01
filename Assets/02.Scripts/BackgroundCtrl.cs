using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundCtrl : MonoBehaviour
{
    private MeshRenderer rend;
    private float offset;

    public Texture2D background;
    public float scrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        /*
        background.wrapMode = TextureWrapMode.Repeat;
        rend = GetComponent<MeshRenderer>();
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        offset += Time.deltaTime * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(offset, 0);
        */
        transform.position = new Vector3(transform.position.x + scrollSpeed, transform.position.y, transform.position.z);

        if(transform.position.x < -18)
        {
            transform.position = new Vector3(18f, transform.position.y, transform.position.z);
        }
    }
}
