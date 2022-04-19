using UnityEngine;

public class Crumple : MonoBehaviour {
	public Transform[] crumpled;
    private Transform breakable = null;

    private void OnMouseEnter()
    {
        Vector3 velocity = transform.GetComponent<Rigidbody>().velocity;
        
        if (breakable) return;
        
        breakable = (Transform)Instantiate(crumpled[Random.Range(0,crumpled.Length)], transform.position, transform.rotation); 
        breakable.localScale = transform.localScale;

		breakable.gameObject.GetComponent<Renderer>().materials[0].CopyPropertiesFromMaterial(gameObject.GetComponent<Renderer>().material);
		if (!breakable.gameObject.GetComponent<Rigidbody>())
		{
			breakable.gameObject.AddComponent<Rigidbody>();
		}
		breakable.gameObject.GetComponent<Rigidbody>().velocity = velocity;
		if (!breakable.gameObject.GetComponent<MeshCollider>())
		{
			breakable.gameObject.AddComponent<MeshCollider>();
			breakable.gameObject.GetComponent<MeshCollider>().convex = true;
		}
		
		Destroy(gameObject);
    }
}
