using System.Collections.Generic;
using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Bizmonger.Patterns.MessageBus;
using static Mediation.Messages;
using static TestAPI.Gimme;

namespace Tests
{
    [TestClass]
    public class _BroadcastLocation
    {
        [TestInitialize]
        public void Setup() =>
            Subscribe(REQUEST_MESSAGE_SERVER, obj => Publish(REQUEST_MESSAGE_SERVER_RESPONSE, MockMessageServer.Instance));

        [TestMethod]
        public void carrier_broadcasts_location()
        {
            // Setup
            var provider = new Provider();

            // Test
            provider.BroadcastLocation();

            // Verify
            var location = provider.Location;
            var expected = location.Latitude > 0 && location.Longitude > 0;

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void observer_broadcasts_location()
        {
            // Setup
            var observer = new Observer();

            // Test
            observer.BroadcastLocation();

            // Verify
            var location = observer.Location;
            var expected = location.Latitude > 0 && location.Longitude > 0;

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void broadcast_carrier_message()
        {
            // Setup
            var carrier = new Provider();
            var observer = new Observer();

            // Test
            carrier.Send(new Message(carrier.Id, new List<string> { observer.Id }, SOME_TEXT));

            // Verify
            var expected = observer.Messages.Count == 1;
            Assert.IsTrue(expected);
        }
    }
}