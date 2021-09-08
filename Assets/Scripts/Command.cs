using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    private GameObject commandPanel;
    void Start()
    {
        commandPanel = GameObject.Find("NamePanel").transform.Find
            ("CommandPanel").gameObject;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenCommandPanel()
    {
        commandPanel.SetActive(true);
    }

    public void CloseCommandPanel()
    {
        commandPanel.SetActive(false);
    }
}

