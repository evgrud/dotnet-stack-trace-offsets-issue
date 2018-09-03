# dotnet-stack-trace-offsets-issue
This program simply crashes and displays an exception after pressing enter.

After compiling for Release (I recommend turning JIT tiered comilation off with setting the environment variable `COMPlus_TieredCompilation` to 0) and running (and pressing enter in the console) you can see that the exception stack trace would point the top of the function which is nowhere near the location of the crash.

Relevant issue is: https://github.com/dotnet/coreclr/issues/19807
