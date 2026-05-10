# Equipment Health Monitor

A C# console application that simulates real-time equipment health monitoring
by evaluating sensor readings against configurable safety thresholds.

Inspired by industrial MRO (Maintenance, Repair & Overhaul) use cases in
aerospace and power systems engineering.

## Features
- Evaluates temperature, pressure, and RPM sensor readings
- Three-tier alert system: OK / WARNING / CRITICAL
- Color-coded console output for quick visual assessment
- Easily extensible threshold configuration
- Timestamped health reports

## Sample Output
```
╔══════════════════════════════════════╗
║    Equipment Health Monitor v1.0     ║
╚══════════════════════════════════════╝

Equipment       Temp (°C)    Pressure (bar)    RPM        Status
────────────────────────────────────────────────────────────────────
Engine-01       85.0         4.2               3200       OK
Engine-02       112.5        5.8               4100       WARNING
  ⚠ Temperature 112.5°C exceeds warning limit (100°C)
Turbine-01      145.0        7.2               5500       CRITICAL
  ⚠ Temperature 145.0°C exceeds critical limit (130°C)
  ⚠ Pressure 7.2 bar exceeds critical limit (7.0 bar)
  ⚠ RPM 5500.0 exceeds critical limit (5000.0)
Pump-01         65.0         3.1               2800       OK
```

## Project Structure
```
EquipmentHealthMonitor/
├── Program.cs          # Entry point, sample data, console output
├── SensorReading.cs    # Data models
├── HealthMonitor.cs    # Threshold evaluation logic
└── README.md
```

## Tech Stack
- Language: C#
- Framework: .NET 6 Console Application
- IDE: Visual Studio / VS Code

## Future Enhancements
- Read sensor data from CSV/JSON files
- Export reports to file
- Add more sensor types (vibration, oil level)
- REST API integration for live sensor feeds
