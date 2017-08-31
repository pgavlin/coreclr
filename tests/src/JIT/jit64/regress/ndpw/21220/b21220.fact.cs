using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_ndpw_21220_b21220_b21220_
    {
        [ActiveIssue("4851")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _regress_ndpw_21220_b21220_b21220_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ndpw\\21220\\b21220\\b21220.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
