namespace Lab3.Services.CameraStates;

public interface ICameraState
{
    void Execute();
    void ChangeState();
    void Pause();
}