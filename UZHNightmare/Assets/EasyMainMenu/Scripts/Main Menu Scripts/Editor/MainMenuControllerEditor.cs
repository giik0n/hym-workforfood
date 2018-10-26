using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MainMenuController))]
public class MainMenuControllerEditor : Editor {

    public override void OnInspectorGUI()
    {
        EMM_AddCanvases.OpenWindow();

        EditorGUILayout.BeginVertical(EditorStyles.helpBox);

        EditorGUILayout.BeginHorizontal(EditorStyles.helpBox);

        EditorGUILayout.LabelField("Main Menu Controller", EditorStyles.helpBox);

        GUIStyle bSKin = new GUIStyle("box");
        bSKin.normal.textColor = Color.green;

       
        EditorGUILayout.EndHorizontal();

        
            EditorGUILayout.HelpBox("The Controller script which will be controlling the whole menu system behaviour.\n\n" +
                                    "This is just a demo version to showcase what you can expect" +
                                    " in the paid version. \n\n" +
                                    "If you liked this demo or you used this in any of your games, " +
                                    "then consider buying the full version from here!", MessageType.Info);

            if (GUILayout.Button("Buy Full Version [Asset Store]"))
            {
                Application.OpenURL("https://www.assetstore.unity3d.com/#!/content/98746");
            }
            if (GUILayout.Button("Buy Full Version [Sellfy Store - 20% OFF]"))
            {
                Application.OpenURL("https://sellfy.com/p/5ujr/");
            }

            EditorGUILayout.HelpBox("Your support is all what I am counting on! For further development of this Asset please support us " +
                                    "by buying it!\n\n" +
                                    "Thanks\n" +
                                    "Hamzah\n" +
                                    "Support : walledcityinfotech@gmail.com", MessageType.Info);

        base.OnInspectorGUI();

        EditorGUILayout.EndVertical();

        
    }

}
