using System.Collections.Generic;

namespace DockingWidget.Docking
{
    public interface IDockService
    {
        IEnumerable<PanelModel> GetPanels(DockZoneType zone);
        void MovePanel(PanelModel panel, DockZoneType zone);
    }
}
