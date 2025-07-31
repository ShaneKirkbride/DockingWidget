using System.Linq;
using DockingWidget.Docking;
using Xunit;

namespace DockingWidget.Tests
{
    public class DockServiceTests
    {
        [Fact]
        public void GetPanels_ReturnsPanelsInRequestedZone()
        {
            var service = new DockService();
            var leftPanels = service.GetPanels(DockZoneType.Left).ToList();

            Assert.Single(leftPanels);
            Assert.Equal(DockZoneType.Left, leftPanels[0].Zone);
        }

        [Fact]
        public void MovePanel_ChangesPanelZone()
        {
            var service = new DockService();
            var panel = service.GetPanels(DockZoneType.Left).First();

            service.MovePanel(panel, DockZoneType.Right);

            Assert.Empty(service.GetPanels(DockZoneType.Left));
            Assert.Contains(panel, service.GetPanels(DockZoneType.Right));
        }
    }
}
