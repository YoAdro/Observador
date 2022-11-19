using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void goToProtoScene()
    {
        SceneManager.LoadScene("ProtoScene");
    }
    

}
