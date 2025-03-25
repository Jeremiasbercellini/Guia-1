using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    [SerializeField] float altura;
    [SerializeField] bool donante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
