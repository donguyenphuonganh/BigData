using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/kafka")]
[ApiController]
public class KafkaController : ControllerBase
{
    private readonly KafkaProducerService _producerService;

    public KafkaController(KafkaProducerService producerService)
    {
        _producerService = producerService;
    }

    [HttpPost("send")]
    public async Task<IActionResult> SendMessage([FromBody] string message)
    {
        await _producerService.SendMessageAsync(message);
        return Ok($"Message sent: {message}");
    }
}
