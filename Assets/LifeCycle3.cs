using UnityEngine;

public class LifeCycle3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        // int number = 4; //스칼라 값
        // Vector3 vec = new Vector3(5,5,5); //벡터 값
        // transform.Translate(vec);
    }

    void Update(){
        // Vector3 vec = new Vector3(0,0.1f,0); //벡터 값
        // Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);
    }
}
