References 

https://benchmarkdotnet.org/articles/configs/configs.html

Memoria Y tal 
https://andresantarosa.medium.com/heap-stack-e-garbage-collector-a-practical-guide-to-net-memory-management-system-7e60bbadf199


Ejemplitos
https://blog.nimblepros.com/blogs/benchmarking-in-dotnet/
https://www.codemag.com/Article/2209061/Benchmarking-.NET-6-Applications-Using-BenchmarkDotNet-A-Deep-Dive#:~:text=BenchmarkDotNet%20is%20an%20open%2Dsource,into%20the%20performance%20data%20collected.

Para los que les duele el candy code

https://learn.microsoft.com/es-es/dotnet/core/tutorials/top-level-templates

Repo Oficial
https://github.com/dotnet/BenchmarkDotNet

Framewoh!
https://learn.microsoft.com/en-us/dotnet/standard/frameworks

The Pareto Principle (also called the 80/20 Rule) describes uneven distribution. For 
example, 20% of a given effort produces 80% of the results, 20% of the hazards causes 80% 
of the injuries, 20% of the bugs cause 80% of the crashes, and so on. We can apply the 
Pareto Principle to the bottlenecks (let’s call it The Bottlenecks Rule5
) and say that 20% of the 
code consumes 80% of the resource. If we go deeper and try to find the problem using this 
20%, we can apply the Pareto Principle again and get the second-order Pareto Principle 
(or just Pareto2
). In this case, we are talking about 4% of the code (4%  = 20%  · 20%) and 
64% of the resource (64%  = 80%  · 80%). In huge applications with a complex multilevel 
architecture, we can go even deeper and formulate the third-order Pareto Principle (or just 
Pareto3
). In this case, we get 0.8% of the code (0.8%  = 20%  · 20%  · 20%) and 51.2% of the 
resource (51.2%  = 80%  · 80%  · 80%). To summarize:
The Bottlenecks Rule:
• Pareto1
: 20% of the code consumes 80% of the resource
• Pareto2
: 4% of the code consumes 64% of the resource
• Pareto3
: 0.8% of the code consumes 51.2% of the resource


Given of 
Benchmark Requirements
Repeatability
Verifiability and Portability
Non-Invading Principle
Examp
    Electric circuit
    When you want to measure voltage in an electric circuit, you 
    connect a voltmeter to the circuit, but then you’ve made some 
    changes in the circuit that can affect the original voltage. Usually, 
    the voltage delta is less than the measurement error, so it’s not a 
    problem.
    • Mercury-in-glass thermometer
    When you are using a classic mercury-in-glass thermometer, 
    it absorbs some thermal energy. In a perfect scenario, the 
    absorption, which affects the temperature of the body, would also 
    be measured

Acceptable Level of Precision
Honesty
Performance Spaces
and more and more