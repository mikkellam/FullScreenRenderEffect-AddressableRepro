using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableSceneLoader : MonoBehaviour
{
    [SerializeField] private AssetReference _sceneReference;
    private void OnEnable()
    {
        LoadScene(_sceneReference);
    }

    public void LoadScene(AssetReference sceneReference)
    {
        StartCoroutine(LoadSceneAsync(sceneReference));
    }

    private IEnumerator LoadSceneAsync(AssetReference sceneReference)
    {
        var asyncLoad = sceneReference.LoadSceneAsync();

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.IsDone)
        {
            if (!asyncLoad.IsValid())
            {
                Debug.Log("internal Operation was not valid");    
            }
            yield return null;
        }

    }
}


        
