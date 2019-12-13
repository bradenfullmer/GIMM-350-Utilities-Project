using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities {

    public static string ProcessText (string textIn) {
        if (textIn != null) {
            try {
                float numbers;
                numbers = float.Parse (textIn);
                textIn = "You entered the number: " + numbers;
                return textIn;
            } catch {
                return ("The string you entered was: " + textIn);
            }
        }
        return null;
    }

    using System.Collections.Generic;
    using System.Collections;
    using UnityEngine;

    public class DuckScript : MonoBehaviour {
        public float ducksCol = 0;

        // Update is called once per frame
        private void OnTriggerEnter (Collider other) {
            if (other.gameObject.tag == "Hand") {
                if (gameObject.tag == "Vines") {
                    StartCoroutine ("Fade");
                } else {
                    Debug.Log ("Duck Collected");
                    ducksCol += 1f;
                    Destroy (gameObject);
                }
            }
        }

        private IEnumerator Fade () {
            for (float ft = 1f; ft >= 0; ft -= 0.1f) {
                Color c = GetComponent<Renderer> ().material.color;
                c.a = ft;
                GetComponent<Renderer> ().material.color = c;
                yield return new WaitForSeconds (.1f);
            }
            if (GetComponent<Renderer> ().material.color.a <= 0.125f) {
                Destroy (gameObject);
            }
        }
    }

}