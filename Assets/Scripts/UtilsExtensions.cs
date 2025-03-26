using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilsExtensions 
{
#if UNITY_EDITOR //Esse codigo so vai funcionar quando estiver no editor
    [UnityEditor.MenuItem("Ebac/Test")] //Cria na Barra de Ferrametas
    public static void Test()
    {
        Debug.Log("Test");
    }

    [UnityEditor.MenuItem("Ebac/Test2 %g")] //%G cria um atalho de teclado para o comando
    public static void Test2()
    {
        Debug.Log("Test");
    }
#endif

    public static T GetRandom<T>(this List<T> list) //O T é usado para aceitar qualquer tipo de item da lista
    {
          return list[Random.Range(0, list.Count)];
    }

    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if(list.Count == 1)
        {
            return unique;
        }

        int randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }

}
