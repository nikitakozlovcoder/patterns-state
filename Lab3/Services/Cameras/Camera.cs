using Lab3.Services.CameraStates;

namespace Lab3.Services.Cameras;

public class Camera
{
    public ICameraState State { private get; set; }
    public Guid CameraCode { get; set; }

    public Camera()
    {
        State = new NotInitializedState(this);
        CameraCode = Guid.NewGuid();
    }
    public async Task Operate(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            State.Execute();
            await Task.Delay(1000);
        }
    }

    public void Pause()
    {
        State.Pause();
    }

    public void ChangeState()
    {
        State.ChangeState();
    }
    
    
}