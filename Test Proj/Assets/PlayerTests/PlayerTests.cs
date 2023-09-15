using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayerTestsSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator EditorTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        GameObject player = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
        float x = player.transform.position.x;
        yield return new WaitForSeconds(5);
        Assert.IsTrue(player.transform.position.x > x);
    }
}
