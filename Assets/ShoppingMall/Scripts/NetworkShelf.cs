using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetworkShelf : NetworkBehaviour
{
    [SerializeField]
    GameObject CanvasCamera;
    [SerializeField]
    GameObject ProductDisplay;

    NetworkIdentity identity;

    // Start is called before the first frame update
    void Start()
    {
        identity = GetComponent<NetworkIdentity>();
        identity.AssignClientAuthority(connectionToServer);
    }

    [ClientRpc]
    public void ClickOnShelf()
    {
        Debug.Log("Meesage sent from other pc");
        if(CanvasCamera.activeInHierarchy == false)
        {
            ProductDisplay.SetActive(true);
            CanvasCamera.SetActive(true);
        }
    }
}
