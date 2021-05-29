using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirect : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenUrl()
    {
        Application.OpenURL("https://api.whatsapp.com/send?phone=14155238886&text=join%20knife-occur");
    }
    public void site()
    {
        Application.OpenURL("https://sites.google.com/view/covit1/home");
    }
}
