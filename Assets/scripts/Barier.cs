using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barier : MonoBehaviour
{
    public bool isbarierActive = true;

    private void Start()
    {
        UpdateVisuals();
    }
    public void bariergodown()
  {
        SetBarier(!isbarierActive);
  }
  public void SetBarier(bool IsbarierActive)
    {
        isbarierActive = IsbarierActive;
        
        if (isbarierActive == false)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled=true;
        }

        Debug.Log(isbarierActive + gameObject.name);

        UpdateVisuals();
    }
    void UpdateVisuals()
    {
        if (isbarierActive)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;

        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;
        }
    }
}
