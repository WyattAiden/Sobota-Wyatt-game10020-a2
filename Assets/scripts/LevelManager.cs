using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public Torch torch1;
    public Torch torch2;
    public Torch torch3;
    public Door door;
    public PreshurePlate preshure;
    public PreshurePlate preshure2;
    public Barier Barier1;
    public Barier Barier2;

    [HideInInspector]
    public UnityEvent <bool> OnAllTorchesLit;

    List <Torch> torches = new List <Torch>();

    // Start is called before the first frame update
    void Start()
    {
        torch1.onInteract.AddListener (torch2.TorchLight);
        torch1.onInteract.AddListener (torch3.TorchLight);
        torch2.onInteract.AddListener (torch3.TorchLight);
        torch3.onInteract.AddListener (torch1.TorchLight);
        OnAllTorchesLit.AddListener(door.SetState);
        preshure.onPresurplatstep.AddListener(Barier1.bariergodown);
        preshure.onPresurplatstep.AddListener (Barier2.bariergodown);
        preshure2.onPresurplatstep.AddListener(Barier1.bariergodown);
        preshure2.onPresurplatstep.AddListener(Barier2.bariergodown);

        torches.Add(torch1);
        torches.Add(torch2);
        torches.Add(torch3);
        foreach(Torch torch in torches)
        {
            torch.ontorchlit.AddListener(alltorcheslit);
        }
        
    }
    void alltorcheslit()
    {
        bool allLit = true;
        foreach (Torch torch in torches)
        {
            if(torch.Toggled == false)
            {
                allLit = false;
            }
            
        }
        OnAllTorchesLit.Invoke(allLit);
        Debug.Log(allLit + gameObject.name);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
