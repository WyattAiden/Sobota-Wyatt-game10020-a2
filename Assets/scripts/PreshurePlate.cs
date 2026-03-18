using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PreshurePlate : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent onPresurplatstep;

    public bool standOn;

    private void Awake()
    {
        onPresurplatstep = new UnityEvent();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Playersteped()
    {
        Presurestate(!standOn);
    }

    void Presurestate(bool Steped)
    {
        standOn = Steped;

        Debug.Log(standOn + gameObject.name);

        onPresurplatstep.Invoke();

        UpdateVisuals();
    }
    void UpdateVisuals()
    {
        if (!standOn)
        {
            GetComponent<SpriteRenderer>().color = Color.gray;

        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
    }
}
