using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class LoadMPPrefs : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject Shelf;
    // Start is called before the first frame update
    void Start()
    {
        NetworkManager.Instantiate(Player);
        NetworkManager.Instantiate(Shelf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
