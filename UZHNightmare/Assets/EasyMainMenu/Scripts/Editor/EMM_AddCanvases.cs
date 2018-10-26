using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class EMM_AddCanvases : EditorWindow{

    public static bool showWindow = true;
    public static void OpenWindow()
    {
        if(showWindow)
        {
            GetWindow<EMM_AddCanvases>("Easy Main Menu");
            GetWindow<EMM_AddCanvases>("Easy Main Menu").maxSize = new Vector2(265, 350);
            GetWindow<EMM_AddCanvases>("Easy Main Menu").minSize = new Vector2(264, 350);

            showWindow = false;
        }
    }

    [MenuItem("EMM/Support!", false, 1)]
    public static void BuyFullVersion()
    {
        GetWindow<EMM_AddCanvases>("Easy Main Menu");
        GetWindow<EMM_AddCanvases>("Easy Main Menu").maxSize = new Vector2(265, 350);
        GetWindow<EMM_AddCanvases>("Easy Main Menu").minSize = new Vector2(264, 350);

    }

    void OnGUI()
    {
        //EMM Logo
        Texture t = (Texture) Resources.Load("EMM_img");

        if (GUILayout.Button(t))
        {
            Application.OpenURL("http://u3d.as/W3m");
        }

        GUILayout.Label("", GUI.skin.horizontalSlider);

        EditorGUILayout.HelpBox("Hi guys, If you liked this demo or you used this in any of your games, " +
                                    "then consider buying the full version from here!", MessageType.Info);

        if (GUILayout.Button("Buy Full Version [Asset Store]"))
        {
            Application.OpenURL("http://u3d.as/W3m");
        }
        if (GUILayout.Button("Buy Full Version [Sellfy Store - 20% OFF]"))
        {
            Application.OpenURL("https://sellfy.com/p/5ujr/");
        }


    }

    [MenuItem("EMM/Add/Loading Canvas &#L", false)]
    public static void AddLoadingCanvas()
    {
        Debug.Log("This feature is in full version..");
    }

    [MenuItem("EMM/Add/Main Menu Canvas  &#M", false)]
    public static void AddMainMenuCanvas()
    {
        //instantiate ui canvas
        GameObject mainMenu = Instantiate(Resources.Load("Prefabs/MainMenu")) as GameObject;
        //rename it
        mainMenu.name = "Main Menu";

        GameObject bgImg = Instantiate(Resources.Load("Prefabs/BackgroundImageCamera")) as GameObject;
        //rename it
        bgImg.name = "Background Image";

        Debug.Log("Main Menu Created!");
    }

    [MenuItem("EMM/Add/Gameplay UI &#G", false)]
    public static void AddGameplayUI() {

        Debug.Log("This feature is in full version..");

    }

    [MenuItem("EMM/Add/Save Game Trigger &#T", false)]
    public static void AddSaveGameTrigger()
    {
        Debug.Log("This feature is in full version..");

    }

    [MenuItem("EMM/Demo/Simple Cube Character", false)]
    public static void AddSimpleCube()
    {
        Debug.Log("This feature is in full version..");
    }

    [MenuItem("EMM/Demo/Sample Maze Scene", false)]
    public static void AddSampleMazeScene()
    {
        Debug.Log("This feature is in full version..");
    }

    [MenuItem("EMM/Clear Game Data &#X", false)]
    public static void ResetPlayerPref()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Game Data Cleared!");
    }

    
}
