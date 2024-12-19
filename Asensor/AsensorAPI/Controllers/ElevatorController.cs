using AscensorAPI.Models;
using AscensorAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ElevatorController : ControllerBase
{
    private readonly IElevatorRepository _elevatorRepository;

    public ElevatorController(IElevatorRepository elevatorRepository)
    {
        _elevatorRepository = elevatorRepository;
    }

    [HttpGet("status")]
    public ActionResult<Elevator> GetElevatorStatus()
    {
        var elevator = _elevatorRepository.GetElevator();
        return Ok(elevator);
    }

    [HttpPost("call")]
    public ActionResult CallElevator([FromBody] ElevatorCallRequest request)
    {
        if (request.FloorNumber < 1)
        {
            return BadRequest("El piso debe ser mayor o igual a 1.");
        }

        _elevatorRepository.CallElevator(request.FloorNumber);
        return Ok(new { message = "Ascensor llamado", floor = request.FloorNumber });
    }

    [HttpPost("start")]
    public ActionResult StartElevator()
    {
        _elevatorRepository.StartElevator();
        return Ok(new { message = "Ascensor iniciado" });
    }

    [HttpPost("stop")]
    public ActionResult StopElevator()
    {
        _elevatorRepository.StopElevator();
        return Ok(new { message = "Ascensor detenido" });
    }

    [HttpPost("open-doors")]
    public ActionResult OpenDoors()
    {
        _elevatorRepository.OpenDoors();
        return Ok(new { message = "Puertas abiertas" });
    }

    [HttpPost("close-doors")]
    public ActionResult CloseDoors()
    {
        _elevatorRepository.CloseDoors();
        return Ok(new { message = "Puertas cerradas" });
    }
}
public class ElevatorCallRequest
{
    public int FloorNumber { get; set; }
}
