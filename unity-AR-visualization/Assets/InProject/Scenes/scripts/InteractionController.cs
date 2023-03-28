using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using jsonhelpernamespace;
namespace Microsoft.MixedReality.Toolkit.UI
{
    public class InteractionController : MonoBehaviour
    {
        public InteractableToggleCollection interactable;
        public GameObject RadialSelector;

        // Start is called before the first frame update
        void Start()
        {

        }

        public void OnClick()
        {
            SceneBuilderController.currentIndex = interactable.CurrentIndex; 
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
