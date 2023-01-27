``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 11 (10.0.22000.1455/21H2)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.102
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


```
|     Method |     Mean |    Error |   StdDev | Rank | Allocated |
|----------- |---------:|---------:|---------:|-----:|----------:|
| MainForNow | 19.15 ms | 1.425 ms | 4.133 ms |    1 |   8.54 KB |
