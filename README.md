TSPLib.Net
==========

TSPLib.Net is a C# .Net wrapper library for [TSPLIB](http://comopt.ifi.uni-heidelberg.de/software/TSPLIB95/) (a library of sample instances for the TSP and related problems from various sources and of various types collected by Heidelberg university) that provides complete access to all the information provided in TSPLIB95 as at 12 Jan 2014.

### How do I get it?

Install it from [NuGet](https://www.nuget.org/packages/TSPLib.Net/), or download from [releases](https://github.com/goblincoding/TSPLib.Net/releases).

### TSPLIB95

The TSPLIB95 directory contains data files and best known solutions information for the:

1.	Symmetric Traveling Salesman Problem (TSP)
2.	Asymmetric Traveling Salesman Problem (ATSP)
3.	Hamiltonian Cycle Problem (HCP)
4.	Sequential Ordering Problem (SOP)
5. 	Capacitated Vehicle Routing Problem (CVRP)

(the original descriptions of problems, used functions and file formats are available in the [DOC.pdf](https://github.com/goblincoding/TSPLib.Net/blob/master/TSPLIB95/DOC.pdf) file contained in this directory)

### TspLibNet

TspLib95 provides the entry point to TSPLIB95 instances and should be considered the default starting point for any application making use of TSPLib.Net.  This class allows you to load instances by type, in total (entire library) or individually by name.  It furthermore provides access to lists of instances by type, all instances in total, or individual instances by name (where name is the name of the file containing the specific problem instance excluding the file extension).

Each TSPLIB95 instance is wrapped within a TspLib95Item which ultimately provides all the available information for the specific TSP problem it wraps. In other words, not only is the TSP graph accessible (through IProblem and ProblemBase), but also the best known solutions (if they exist) in the form of optimal tours and optimal tour distances.

IntelliSense should take you the rest of the way, but please see the source if anything is lacking.

### TspLibNetDemo

TspLibNetDemo is a basic little demo app that allows you to view information related to TSPLIB95 instances in a convenient GUI (the demo app lives in a completely separate solution from that of the library itself and therefore doesn't affect library usage or distribution).

## Licensing

TSPLib.Net is distributed under the MIT license.