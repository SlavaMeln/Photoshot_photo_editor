namespace Photoshot.BL.Model.Tools
{
    public interface IToggleable
    {
        ITool GetCurrentTool();
        void OnToggle();
    }
}