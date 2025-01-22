using Core.EventSystem;

public interface IShadowComponent
{
    public void StartComponent(EventController eventController);
    public void UpdateComponent();
    public void ClearComponent();
    public void SetupEvents();
    public void ClearEvents();
}
