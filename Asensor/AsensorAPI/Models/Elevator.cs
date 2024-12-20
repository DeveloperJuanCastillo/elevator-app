namespace ElevatorAPI.Models
{
    public class Elevator
    {
        public int CurrentFloor { get; set; } = 1;  
        public bool DoorsOpen { get; set; } = false;  
        public bool IsMoving { get; set; } = false;  

    }
}
