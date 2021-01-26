using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

    public static DontDestroyOnLoad instance;

	void OnEnable()
	{
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

	void OnDisable()
	{
	
	}

	void Start() 
	{
		
	}
	
	void Update() 
	{
		
	}
	
	void SetInitialReferences()
	{
	
	}
}
