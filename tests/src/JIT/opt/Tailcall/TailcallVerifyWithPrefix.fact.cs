using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Tailcall_TailcallVerifyWithPrefix_TailcallVerifyWithPrefix_
    {
        [ActiveIssue("2420. x86 JIT doesn't support implicit tail call optimization or tail. call pop ret sequence")]//, TestArchitectures.X86)]
        [ActiveIssue("2420")]//, TestArchitectures.Arm)]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _Tailcall_TailcallVerifyWithPrefix_TailcallVerifyWithPrefix_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Tailcall\\TailcallVerifyWithPrefix\\TailcallVerifyWithPrefix.cmd");
        }
    }
}
