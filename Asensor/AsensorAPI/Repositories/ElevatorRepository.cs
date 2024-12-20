using ElevatorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ElevatorAPI.Repositories
{
    public class ElevatorRepository : IElevatorRepository
    {
        private static Elevator _elevator = new Elevator();

        public Elevator GetElevator()
        {
            return _elevator;
        }

        public void CallElevator(int floor)
        {
            _elevator.CurrentFloor = floor;
            _elevator.IsMoving = true;
        }

        public void StartElevator()
        {
            if (!_elevator.IsMoving)
            {
                _elevator.IsMoving = true;
            }
        }

        public void StopElevator()
        {
            if (_elevator.IsMoving)
            {
                _elevator.IsMoving = false;
            }
        }

        public void OpenDoors()
        {
            _elevator.DoorsOpen = true;
        }

        public void CloseDoors()
        {
            _elevator.DoorsOpen = false;
        }
    }
}
