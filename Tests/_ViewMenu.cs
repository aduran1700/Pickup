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
        public void view_profile()
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
    }
}