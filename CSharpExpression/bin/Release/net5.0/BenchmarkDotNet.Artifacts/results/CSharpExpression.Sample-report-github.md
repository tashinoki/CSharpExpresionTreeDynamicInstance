``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.202
  [Host]     : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT


```
|         Method |         Mean |      Error |     StdDev |
|--------------- |-------------:|-----------:|-----------:|
|         Create |     34.50 ns |   0.422 ns |   0.329 ns |
| CreateInstance | 73,722.54 ns | 928.888 ns | 823.435 ns |
