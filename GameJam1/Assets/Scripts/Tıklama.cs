using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tıklama : MonoBehaviour
{
    public int motivation;
    void Start()
    {
        
    }

    
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
              {
                  RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                  if (hit.collider != null)
                  {
                      if (hit.collider.gameObject.CompareTag("bilgisayar"))
                      {
                          Debug.Log("Bilgisyara basıldı selam ");
                          
      
      
                      }
                      if (hit.collider.gameObject.CompareTag("kapi"))
                      {
                          Debug.Log("evden çikildi ");
                      }
                      Debug.Log(hit.collider.gameObject.tag);
                  }
              }  
    }
}
