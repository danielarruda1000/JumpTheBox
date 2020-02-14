using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMove : MonoBehaviour
{

    public float bgSpeed;
    public Renderer bgRender;
    void Start()
    {
      
    }
    void Update()
    {
        bgRender.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }

   

}
