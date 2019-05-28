using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{

    private Dictionary<int, GameObject> trails = new Dictionary<int, GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tap effect 
        // Checks for all fingers
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            // A tap is a quick touch and release
            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                // Touches are screen locations, this converts them in to world locations
                Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);

                // Creates the Explosion Effect
                SpecialEffects.MakeExplosion((position));
            }

            else
            {
                // Controls for the Swipe Gesture
                if (touch.phase == TouchPhase.Began)
                {
                    // Store this new value
                    if (trails.ContainsKey(i) == false)
                    {
                        // Touches are screen locations, this converts them in to world locations
                        Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);
                        // Ensures the trail is visible
                        position.z = 0;

                        // Creates the Trails Effect
                        GameObject trail = SpecialEffects.MakeTrail(position);

                        // If the trail is still enabled
                        if (trail != null)
                        {
                            // Log the trail
                            Debug.Log(trail);
                            // Add some more Trails 
                            trails.Add(i, trail);
                        }
                    }
                }

                else if (touch.phase == TouchPhase.Moved)
                {
                    // Moves the trail
                    if (trails.ContainsKey(i))
                    {
                        // Array for the Trails
                        GameObject trail = trails[i];

                        // Converts touches in to world locations
                        Camera.main.ScreenToWorldPoint(touch.position);
                        Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);
                        // Ensures trail is visible
                        position.z = 0;

                        // Sets position of the trails to position of the finger
                        trail.transform.position = position;
                    }
                }

                else if (touch.phase == TouchPhase.Ended)
                {
                    // Clears all visible trails
                    if (trails.ContainsKey(i))
                    {
                        GameObject trail = trails[i];

                        // Fades trails out
                        Destroy(trail, trail.GetComponent<TrailRenderer>().time);
                        trails.Remove(i);
                    }
                }
            }
        }
        
    }
}
