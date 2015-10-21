using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAPI;
using ViewMenu;
using static Bizmonger.Patterns.MessageBus;
using static Mediation.Messages;

namespace Tests
{
    [TestClass]
    public class _ViewMenu
    {
        [TestInitialize]
        public void Setup()
        {
            Subscribe(REQUEST_PROFILE, obj => Publish(REQUEST_PROFILE_RESPONSE, new Mock().Profile));
        }

        [TestMethod]
        public void view_profile_launched()
        {
            // Setup
            var viewModel = new ViewModel();
            var profileViewModel = new ManageProfile.ViewModel();

            // Test
            viewModel.ViewProfile.Execute(null);

            // Verify
            var expected = !string.IsNullOrEmpty(profileViewModel.Alias);
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void compose_message_launched()
        {
            // Setup
            var viewModel = new ViewModel();
            var messageViewModel = new EngageObserver.Message.ViewModel();
            var observer = new Core.Observer();
            Publish(OBSERVER_TO_MESSAGE, observer);

            // Test
            viewModel.ComposeMessage.Execute(null);

            // Verify
            var expected = messageViewModel.Observer == observer;
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void confirm_interaction_launched()
        {
            // Setup
            var viewModel = new ViewModel();
            var confirmationViewModel = new EngageObserver.Confirmation.ViewModel();
            var observer = new Core.Observer();
            Publish(CONFIRM_INTERACTION, observer);

            // Test
            viewModel.RequestConfirmation.Execute(null);

            // Verify
            var expected = confirmationViewModel.Observer == observer;
            Assert.IsTrue(expected);
        }
    }
}