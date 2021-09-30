``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.202
  [Host]     : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT


```
|         Method |     Mean |    Error |   StdDev |
|--------------- |---------:|---------:|---------:|
| CreateInstance | 76.38 μs | 0.789 μs | 0.659 μs |
