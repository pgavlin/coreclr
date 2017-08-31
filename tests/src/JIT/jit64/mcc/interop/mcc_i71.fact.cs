using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _mcc_interop_mcc_i71_mcc_i71_
    {
        [ActiveIssue("needs triage")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i71_mcc_i71_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i71\\mcc_i71.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
