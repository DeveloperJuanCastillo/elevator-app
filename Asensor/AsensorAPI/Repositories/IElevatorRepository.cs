using AscensorAPI.Models;

namespace AscensorAPI.Repositories
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
