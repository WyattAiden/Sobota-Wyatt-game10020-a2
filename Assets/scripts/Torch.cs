using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Torch : MonoBehaviour
{
 
    [HideInInspector]
    public UnityEvent onInteract;
    public UnityEvent ontorchlit;

    public bool Toggled;

    Color FireOrange = new(1f, 0.31f, 0f);

    // Start is called before the first frame update
    void Awake()
    {
        onInteract = new UnityEvent();
    }

    private void Start()
    {
        UpdateVisuals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TorchLight()
    {
        SetState(!Toggled, false);
    }
    public void PlayerLight()
    {
        SetState(!Toggled,true);
    }
    

    void SetState(bool toggle, bool doevent)
    {
        Toggled = toggle;

        Debug.Log(Toggled + gameObject.name);
        if (doevent)
        {
            onInteract.Invoke();
        }
        ontorchlit.Invoke();
        UpdateVisuals();

    }

    void UpdateVisuals()
    {
        if (Toggled)
        {
            GetComponent<SpriteRenderer>().color = FireOrange;

        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.gray;
        }
    }

}
