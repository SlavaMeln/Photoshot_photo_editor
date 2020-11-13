namespace Photoshot.BL.Model.Tools
{
    public interface ITool
    {
        bool IsActive { get; set; }
        void OnClick();
    }
}