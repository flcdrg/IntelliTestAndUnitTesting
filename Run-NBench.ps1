param(
    [switch] $Counter,
    [switch] $Algorithm
)

if ($Counter.IsPresent)
{
    .\packages\NBench.Runner.0.3.0\lib\net45\NBench.Runner.exe IntelliTestAndUnitTesting.NBench\bin\debug\IntelliTestAndUnitTesting.NBench.dll include=*CounterPerfSpecs*
}

if ($Algorithm.IsPresent)
{
    .\packages\NBench.Runner.0.3.0\lib\net45\NBench.Runner.exe IntelliTestAndUnitTesting.NBench\bin\debug\IntelliTestAndUnitTesting.NBench.dll include=*AlgorithmPerfSpecs*
}