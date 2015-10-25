using System.Collections.Generic;
using System.Linq;
using Core;
using EngageObserver.Message;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAPI;
using static Bizmonger.Patterns.MessageBus;
using static Mediation.Messages;
using static TestAPI.Gimme;

namespace Tests
{
    [TestClass]
    public class _EngageObserver
    {
        [TestInitialize]
        public void Setup() =>
            Subscribe(REQUEST_MESSAGE_SERVER, obj => Publish(REQUEST_MESSAGE_SERVER_RESPONSE, MockMessageServer.Instance));

        [TestMethod]
        public void send_observer_message()
        {
            // Setup
            var viewModel = new ViewModel();
            viewModel.Observer = new Observer();

            // Test
            viewModel.SendMessage.Execute(null);

            // Verify
            var expected = viewModel.Observer.Messages.Any();
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void receive_observer_message()
        {
            // Setup
            var viewModel = new ViewModel();
            viewModel.Observer = new Observer();
            var observer = viewModel.Observer;
            var provider = viewModel.Provider;
            var message = new Message(observer.Id, new List<string>() { provider.Id }, SOME_TEXT);

            // Test
            observer.Send(message);

            // Verify
            var expected = provider.Messages.Count() == 1;
            Assert.IsTrue(expected);
        }
    }
}