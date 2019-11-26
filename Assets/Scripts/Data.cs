using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static int VerificadorPesquisa = 0;
    public static int Pesquisou = 0;

    private GameObject[] Datas;

    void Awake()
    {
        Datas = GameObject.FindGameObjectsWithTag("Data");
        if(Datas.Length >= 2)
        {
            Destroy(Datas[0]);
        }
        DontDestroyOnLoad(transform.gameObject);
    }
}
