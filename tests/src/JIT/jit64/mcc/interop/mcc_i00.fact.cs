using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _mcc_interop_mcc_i00_mcc_i00_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i00_mcc_i00_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i00\\mcc_i00.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
