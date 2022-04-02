using Lab3.Services.Cameras;

namespace Lab3.Services.CameraStates;

public class RunningState : ICameraState
{
    private long _frameNumber;
    private bool _isPaused;
    private readonly Camera _camera;

    public RunningState(Camera camera)
    {
        _camera = camera;
    }

    public void Execute()
    {
        if (_isPaused)
        {
            Console.WriteLine($"Paused");
            return;
        }
        Console.WriteLine($"{_camera.CameraCode}: Frame number {_frameNumber++}");
        
    }

    public void ChangeState()
    {
        _camera.State = new NotInitializedState(_camera);
    }

    public void Pause()
    {
        _isPaused = !_isPaused;
    }
}