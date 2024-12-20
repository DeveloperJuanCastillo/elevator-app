public class Elevator
{
    private List<int> _requests = new();
    private bool _doorsOpen = false;
    private bool _isMoving = false;
    private int _currentFloor = 0;

    public int CurrentFloor => _currentFloor;
    public bool DoorsOpen => _doorsOpen;
    public bool IsMoving => _isMoving;

    public void Call(int floor)
    {
        if (!_requests.Contains(floor))
        {
            _requests.Add(floor);
        }
    }

    public void OpenDoors()
    {
        if (_currentFloor >= 0)
        {
            _doorsOpen = true;
        }
    }

    public void CloseDoors()
    {
        _doorsOpen = false;
    }

    public void StartMovement()
    {
        if (_requests.Any())
        {
            _isMoving = true;
            ProcessRequests();
        }
    }

    public void StopMovement()
    {
        _isMoving = false;
    }

    private void ProcessRequests()
    {
        while (_requests.Any())
        {
            // Simulate that the elevator processes requests in ascending order
            _requests = _requests.OrderBy(f => f).ToList();

            foreach (var request in _requests.ToList())
            {
                // Simulate movement to the requested floor
                _currentFloor = request;
                _requests.Remove(request);
                OpenDoors(); // Open doors when the elevator reaches a floor
                Thread.Sleep(1000); // Wait to simulate the elevator moving
                CloseDoors();
            }
        }
        _isMoving = false;
    }
}
