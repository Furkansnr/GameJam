using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tıklama : MonoBehaviour
{
    public int motivation;
    public CanVeMotivasyon canvemotivasyon;
    
    void Start()
    {
        canvemotivasyon = GameObject.Find("UImanager").GetComponent<CanVeMotivasyon>();
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
                          canvemotivasyon.motiveChange(-5);
                          canvemotivasyon.pcpanel.SetActive(true);
      
      
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
