using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _RVAInit_extended_extended_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _RVAInit_extended_extended_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\extended\\extended.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
