using Lab3.Services.Cameras;

namespace Lab3.Services.CameraStates;

public class InitializingState : ICameraState
{
    private int _status;
    private bool _isPaused;
    private readonly Camera _camera;

    public InitializingState(Camera camera)
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
        _status += 10;
        Console.WriteLine($"{_camera.CameraCode}: Initializing {_status}%");
        if (_status >= 100)
        {
            _camera.State = new RunningState(_camera);
        }
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