using UnityEngine;

[ExecuteAlways]
public class GenerateGUID : MonoBehaviour
{
    [SerializeField] private string _gUID = "";

    public string GUID { get => _gUID; set => _gUID = value; }

    private void Awake()
    {
        // Run only in the editor
        if (!Application.IsPlaying(gameObject))
        {
            if(_gUID == "")
            {
                //Assign GUID
                _gUID = System.Guid.NewGuid().ToString();
            }
        }
    }
}
