using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class MenuScript : MonoBehaviour
    {
        public GameObject controlsMenu;

        void OnEnable()
        {

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


        public void OnClickControls()
        {
            controlsMenu.SetActive(true);
        }

        public void OnCloseControls()
        {
            controlsMenu.SetActive(false);
        }

    }

}


