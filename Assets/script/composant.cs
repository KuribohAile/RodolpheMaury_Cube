using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class composant : MonoBehaviour
{
    public int monEntier;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(monEntier); //on utilise souvent "Awake" (pour que tout soit pret pour le jeu) / "Start" / "Update" / "LateUpdate"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
