using Microsoft.AspNetCore.Mvc;

public class WeatherForecast2
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }


}

[ApiController]

[Route("[controller]")]

public class WeatherForecast2Controller : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild",
                "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };



    [HttpGet]

    public IEnumerable<WeatherForecast2> Get()
    {
        var rng = new Random();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast2
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        }).ToArray();
    }

    [HttpPost]

    public IActionResult Post ([FromBody] WeatherForecast2 forecast)
    {
        return Ok(forecast);
    }

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody] WeatherForecast2 forecast)
    {

            return NoContent();
    }

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        return NoContent();
    }

}