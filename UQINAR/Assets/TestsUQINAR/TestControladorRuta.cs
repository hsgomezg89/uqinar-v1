﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class TestControladorRuta
    {
       
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestControladorRutaWithEnumeratorPasses()
        {
            SceneManager.LoadScene("Ingenieria");
            yield return null;
        }
    }
}
