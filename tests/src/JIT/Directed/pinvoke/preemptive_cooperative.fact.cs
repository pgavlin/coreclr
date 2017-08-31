using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinvoke_preemptive_cooperative_preemptive_cooperative_
    {
        [ActiveIssue("2434")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_preemptive_cooperative_preemptive_cooperative_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\preemptive_cooperative\\preemptive_cooperative.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
