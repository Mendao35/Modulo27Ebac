using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Car))]
public class CarEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Car myTarget = (Car)target;

        myTarget.carPrefab =(GameObject)EditorGUILayout.ObjectField(myTarget.carPrefab, typeof(GameObject), true);

        myTarget.speed = EditorGUILayout.IntField("Velocidade", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Marcha", myTarget.gear);

        EditorGUILayout.LabelField("Velocidade Total", myTarget.TotalSpeed.ToString());

        EditorGUILayout.HelpBox("Calcule a Velocidade Total do Carro", MessageType.Info);

        if(myTarget.TotalSpeed > 200)
        {
            EditorGUILayout.HelpBox("Velocidade Acima do Permitido", MessageType.Error);
        }

        GUI.color = Color.cyan;

        if(GUILayout.Button("Criar Carro"))
        {
            myTarget.CraeteCar();
        }
        

    }
}
