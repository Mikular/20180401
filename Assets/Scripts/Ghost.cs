using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField]
    private static Transform bench;

    [SerializeField]
    private readonly Sprite Sprite;
    
    [SerializeField]
    private GhostBindable _boundTo;
    
    public GhostBindable BoundTo
    {
        get
        {
            return _boundTo;
        }
        set
        {
            transform.SetParent(value?.transform ?? bench);
            _boundTo = value;
        }
    }

    [SerializeField]
    private IEnumerable<GhostPower> _powers;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
