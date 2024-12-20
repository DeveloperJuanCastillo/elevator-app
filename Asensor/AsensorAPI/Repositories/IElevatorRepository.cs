using ElevatorAPI.Models;

namespace ElevatorAPI.Repositories
{
    public interface IElevatorRepository
    {
        Elevator GetElevator();
        void CallElevator(int floor);
        void StartElevator();
        void StopElevator();
        void OpenDoors();
        void CloseDoors();
    }
}
