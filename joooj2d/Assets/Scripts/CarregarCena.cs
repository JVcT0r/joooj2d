using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{
    public string cenaPCarregar;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(cenaPCarregar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
