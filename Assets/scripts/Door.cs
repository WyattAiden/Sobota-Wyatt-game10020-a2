using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    bool isLocked = true;

    Color Brown = new(0.4392157f, 0.1607843f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        UpdateVisuals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoorOpen()
    {
        if (isLocked == false)
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
    public void SetState(bool toggle)
    {
        isLocked = !toggle;
        
        
        Debug.Log(isLocked + gameObject.name);
    
        UpdateVisuals();
    }
    void UpdateVisuals()
    {
        if (!isLocked)
        {
            GetComponent<SpriteRenderer>().color = Color.black;

        }
        else
        {
            GetComponent<SpriteRenderer>().color = Brown;
        }
    }
}
