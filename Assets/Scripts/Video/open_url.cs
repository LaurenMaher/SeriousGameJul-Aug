using UnityEngine;

public class open_url : MonoBehaviour {

    public string Url;

	// Use this for initialization
	public void Open()
    {
        Application.OpenURL(Url);	
		
	}
}
