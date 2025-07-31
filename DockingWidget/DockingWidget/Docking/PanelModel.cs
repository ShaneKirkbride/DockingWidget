using System;

namespace DockingWidget.Docking
{
    public class PanelModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public DockZoneType Zone { get; set; }
    }
}
