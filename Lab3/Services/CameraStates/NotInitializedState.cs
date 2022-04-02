using Lab3.Services.Cameras;

namespace Lab3.Services.CameraStates;

public class NotInitializedState : ICameraState
{
    private readonly Camera _camera;

    public NotInitializedState(Camera camera)
    {
        _camera = camera;
    }

    public void Execute()
    {
      
    }

    public void ChangeState()
    {
        _camera.State = new InitializingState(_camera);
    }

    public void Pause()
    {
        Console.WriteLine("Camera is not working");
    }
}