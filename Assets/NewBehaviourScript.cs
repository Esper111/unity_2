using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int x;
    public Material[] material;
    Renderer rend;
    void Start()
    {
        x=0;
        rend=GetComponent<Renderer>();
        rend.enabled=true;
        rend.sharedMaterial=material[x];
    }

    // Update is called once per frame
    public void change(){
        if(x==0){
            x=1;
            rend.sharedMaterial=material[x];
        }
        else{
            x=0;
            rend.sharedMaterial=material[x];
        }
    }
    void Update()
    {
        
    }
}
