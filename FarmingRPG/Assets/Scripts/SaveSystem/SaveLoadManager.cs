using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadManager : SingletonMonobehaviour<SaveLoadManager>
{
    public List<ISavable> iSavableObjectList;

    protected override void Awake()
    {
        base.Awake();

        iSavableObjectList = new List<ISavable>();
    }

    public void StoreCurrentSceneData()
    {
        foreach(ISavable iSavableObject in iSavableObjectList)
        {
            iSavableObject.ISavableStoreScene(SceneManager.GetActiveScene().name);
        }
    }

    public void RestoreCurrentSceneData()
    {
        foreach(ISavable iSavableObject in iSavableObjectList)
        {
            iSavableObject.ISavableRestoreScene(SceneManager.GetActiveScene().name);
        }
    }
}
