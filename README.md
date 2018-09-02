# dotnet-stack-trace-offsets-issue
After compiling for Release (I recommend turning JIT tiered comilation off with setting the environment variable `COMPlus_TieredCompilation` to 0) and running you can see that the exception stack trace would point the top of the function which is nowhere near the location of the crash.
