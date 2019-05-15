using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.IO;

/**
 *Copyright(C) 2019 by hiscene
 *All rights reserved.
 *FileName:     DebugWindow.cs
 *Author:       yic
 *UnityVersion：2018.3.9f1
 *Date:         2019-05-15
 *Description:  Debug窗口
 *              1) StreamingAssets目录生成            
*/


public class DebugWindow : EditorWindow
{
    [MenuItem("Window/DebugWindow")]
    private static void ShowWindow()
    {
        var window = GetWindow<DebugWindow>();
        window.titleContent = new GUIContent("DebugWindow");
        window.minSize = new Vector2(512, 256);
        window.Show();
    }

    private void OnGUI()
    {
        EditorGUILayout.BeginVertical();
        EditorGUILayout.Space();

        if (GUILayout.Button("生成StreamingAsset目录"))
        {
            string pathDir = Application.streamingAssetsPath;
            if (!Directory.Exists(pathDir))
                Directory.CreateDirectory(pathDir);
        }

        EditorGUILayout.EndVertical();


    }
}
