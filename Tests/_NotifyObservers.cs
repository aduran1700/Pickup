using Microsoft.VisualStudio.TestTools.UnitTesting;
using NotifyObservers;
using static Bizmonger.Patterns.MessageBus;
using static Mediation.Messages;
using static TestAPI.Gimme;

namespace Tests
{
    [TestClass]
    public class _NotifyObservers
    {
        [TestInitialize]
        public void Setup() =>
            Subscribe(REQUEST_MESSAGE_SERVER, obj => Publish(REQUEST_MESSAGE_SERVER_RESPONSE, MockMessageServer.Instance));

        [TestMethod]
        public void cannot_broadcast_location_without_observers()
        {
            // Setup
            var viewModel = new ViewModel();
            viewModel.Observers.Clear();

            // Test
            var expected = !viewModel.BroadcastLocation.CanExecute(null);

            // Verify
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void cannot_broadcast_message_without_observers()
        {
            // Setup
            var viewModel = new ViewModel();
            viewModel.Observers.Clear();

            // Test
            var expected = !viewModel.BroadcastMessage.CanExecute(null);

            // Verify
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void can_broadcast_location_with_observers()
        {
            // Setup
            var viewModel = new ViewModel();
            viewModel.Observers.Add(new Core.Observer());

            // Test
            var expected = viewModel.BroadcastLocation.CanExecute(null);

            // Verify
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void can_broadcast_message_with_observers()
        {
            // Setup
            var viewModel = new ViewModel();
            viewModel.Observers.Add(new Core.Observer());

            // Test
            var expected = viewModel.BroadcastMessage.CanExecute(null);

            // Verify
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void broadcast_location_with_observers()
        {
            // Setup
            var viewModel = new ViewModel();
            viewModel.Observers.Add(new Core.Observer());

            // Test
            viewModel.BroadcastLocation.Execute(null);

            // Verify
            Assert.IsTrue(viewModel.LocationBroadcasted);
        }

        [TestMethod]
        public void broadcast_message_with_observers()
        {
            // Setup
            var viewModel = new ViewModel();
            viewModel.Message = new Core.Message(SOME_TEXT, SOME_TEXT);
            viewModel.Observers.Add(new Core.Observer());

            // Test
            viewModel.BroadcastMessage.Execute(null);

            // Verify
            Assert.IsTrue(viewModel.MessageBroadcasted);
        }
    }
}