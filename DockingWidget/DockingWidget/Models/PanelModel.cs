using DockingWidget.Docking;
using System;

namespace DockingWidget.Models
{
    public class PanelModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public DockZoneType Zone { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
