``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 11 (10.0.22000.1455/21H2)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.102
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


```
|              Method |     Mean |   Error |   StdDev |    Median | Ratio | RatioSD | Rank |   Gen0 | Allocated | Alloc Ratio |
|-------------------- |---------:|--------:|---------:|----------:|------:|--------:|-----:|-------:|----------:|------------:|
|    GetYearFromSplit | 103.4 ns | 3.48 ns | 10.25 ns |  99.98 ns |  0.23 |    0.02 |    1 | 0.0381 |     160 B |          NA |
| GetYearFromDateTime | 466.2 ns | 9.31 ns | 24.36 ns | 459.96 ns |  1.00 |    0.00 |    2 |      - |         - |          NA |
