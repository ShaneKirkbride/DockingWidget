using System.Collections.Generic;
using System.Linq;

namespace DockingWidget.Docking
{
    public class DockService : IDockService
    {
        private readonly List<PanelModel> _panels = new List<PanelModel>
        {
            new PanelModel { Title = "Panel 1", Zone = DockZoneType.Left },
            new PanelModel { Title = "Panel 2", Zone = DockZoneType.Right },
            new PanelModel { Title = "Panel 3", Zone = DockZoneType.Bottom }
        };

        public IEnumerable<PanelModel> GetPanels(DockZoneType zone)
        {
            return _panels.Where(p => p.Zone == zone);
        }

        public void MovePanel(PanelModel panel, DockZoneType zone)
        {
            var target = _panels.FirstOrDefault(p => p.Id == panel.Id);
            if (target != null)
            {
                target.Zone = zone;
            }
        }
    }
}
