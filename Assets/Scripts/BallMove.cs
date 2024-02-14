using UnityEngine;
using System.Collections.Generic;

public class BallMove : MonoBehaviour
{
    [SerializeField] List<GameObject> objlist = new List<GameObject>();
    private GameObject currGameObj;
    private GameObject prevGameObj;
    private GameObject nextGameObj;
    private float diffBtwnPlatforms = 0.5f;
    private int index = 0;
    private int firstMember = 0;
    private int lastMember;
    Material m_Material;

    private void Start()
    {

        currGameObj = objlist[index];   // 0
        nextGameObj = objlist[index+1]; // 1
        lastMember = objlist.Count-1;
    }


    private void Update()
    {
        transform.position = new Vector3(currGameObj.transform.position.x, currGameObj.transform.position.y + 1f, currGameObj.transform.position.z);
        //currGameObj.GetComponent<Renderer>() = new Renderer
        //gameObject.renderer.material = renderer1;     Old Way Of Setting Renderer
        m_Material = currGameObj.GetComponent<Renderer>().material;
        gameObject.GetComponent<Renderer>().material = m_Material;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (index == firstMember)
            {
                if (Mathf.Abs(currGameObj.transform.position.y - nextGameObj.transform.position.y) < diffBtwnPlatforms)
                {
                    prevGameObj = currGameObj;
                    index++;
                    currGameObj = nextGameObj;
                    nextGameObj = objlist[index + 1];
                    Debug.Log("Moved To "+ currGameObj.name);
                    Debug.Log(index);
                }
            }
            else if (index > firstMember && index < lastMember)
            {
                if (Mathf.Abs(currGameObj.transform.position.y - nextGameObj.transform.position.y) < diffBtwnPlatforms)
                {
                    prevGameObj = currGameObj;
                    currGameObj = nextGameObj;
                    index++;
                    if(index!=lastMember)
                    {
                        nextGameObj = objlist[index + 1];
                    }
                    
                    Debug.Log("Moved To " + currGameObj.name);
                    Debug.Log(index);
                }
                else if (Mathf.Abs(prevGameObj.transform.position.y - currGameObj.transform.position.y) < diffBtwnPlatforms)
                {
                    nextGameObj = currGameObj;
                    
                    index--;
                    prevGameObj = objlist[index];
                    currGameObj = prevGameObj;
                    Debug.Log("Moved To " + currGameObj.name);
                    Debug.Log(index);
                }
            }
            else if (index == lastMember)
            {
                if (Mathf.Abs(prevGameObj.transform.position.y - currGameObj.transform.position.y) < diffBtwnPlatforms)
                {
                    nextGameObj = currGameObj;
                    currGameObj = prevGameObj;
                    index--;
                    prevGameObj = objlist[index];
                    Debug.Log("Moved To " + currGameObj.name);
                    Debug.Log(index);
                }
            }
        }
    }
}