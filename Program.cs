using System;
using System.Collections.Generic;

namespace EquipmentHealthMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║    Equipment Health Monitor v1.0     ║");
            Console.WriteLine("╚══════════════════════════════════════╝\n");

            var monitor = new HealthMonitor();

            // Sample sensor readings (simulate real equipment data)
            var readings = new List<SensorReading>
            {
                new SensorReading("Engine-01", temperature: 85.0, pressure: 4.2, rpm: 3200),
                new SensorReading("Engine-02", temperature: 112.5, pressure: 5.8, rpm: 4100),
                new SensorReading("Turbine-01", temperature: 145.0, pressure: 7.2, rpm: 5500),
                new SensorReading("Pump-01",    temperature: 65.0, pressure: 3.1, rpm: 2800),
            };

            Console.WriteLine($"{"Equipment",-15} {"Temp (°C)",-12} {"Pressure (bar)",-17} {"RPM",-10} {"Status",-10}");
            Console.WriteLine(new string('─', 68));

            foreach (var r in readings)
            {
                var result = monitor.Evaluate(r);
                var color = result.Status switch
                {
                    "CRITICAL" => ConsoleColor.Red,
                    "WARNING"  => ConsoleColor.Yellow,
                    _          => ConsoleColor.Green
                };
                Console.ForegroundColor = color;
                Console.WriteLine($"{r.EquipmentId,-15} {r.Temperature,-12:F1} {r.Pressure,-17:F1} {r.RPM,-10} {result.Status,-10}");
                Console.ResetColor();

                if (result.Alerts.Count > 0)
                {
                    foreach (var alert in result.Alerts)
                        Console.WriteLine($"  ⚠ {alert}");
                }
            }

            Console.WriteLine("\n[Report generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]");
        }
    }
}