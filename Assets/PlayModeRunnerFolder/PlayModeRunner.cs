﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayModeRunner
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Player_Found_By_Name()
        {
			// Use the Assert class to test conditions
			var player = GameObject.Find("Player");
			Assert.IsTrue(player != null);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator PlayModeRunnerWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
