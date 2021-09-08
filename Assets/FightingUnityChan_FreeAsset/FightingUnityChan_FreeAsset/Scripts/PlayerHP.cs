using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : HPScript
{
    // Start is called before the first frame update
    void Start()
    {
        base.SetSlider(400f);
    }

    // Update is called once per frame
    void Update()
    {
        base.Damage(Input.GetKeyDown(KeyCode.Alpha4));
    }
}
