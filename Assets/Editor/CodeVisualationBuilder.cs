using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class CodeVisualationBuilder : EditorWindow
{


    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/CodeVis Builder")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        CodeVisualationBuilder window = (CodeVisualationBuilder)EditorWindow.GetWindow(typeof(CodeVisualationBuilder));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Basic Behaviors", EditorStyles.boldLabel);
        if (GUILayout.Button("Recreate Scene"))
        {
            recreateScene();
        }


    }

    void recreateScene()
    {
        // Create/recreate game objects here.
        Debug.Log("Recreating scene from data files on disk.");
        var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single); // vs Additive
        newScene.name = "CodeVis";
        /*
        GameObject[] gameObjects = newScene.GetRootGameObjects();
        Debug.Log("Count of objects: " + gameObjects.Length);
        foreach (GameObject g in gameObjects)
        {
            Debug.Log(message: "Root game object1 " + g.GetType().Name);
        }
        */
        UnitySystemConsoleRedirector.Redirect();
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
        CreateBoxes.createCodeBlocks();
    }
}