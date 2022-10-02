using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubecontroleur : MonoBehaviour
{
    public Transform monTransform;  //[SerializeField] private pour pouvoir modif depuis l'editeur
    [SerializeField] private GameObject prefabAInstantier;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabAInstantier, new Vector3(1f, 1f, 1f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //monTransform.position = monTransform.position + new Vector3(0.25f, , 0f) * Time.deltaTime; //marche avec +=
        monTransform.position = new Vector3(0.25f, Mathf.Sin(2f * Time.time), 0f);
    }
}
