using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _mcc_interop_mcc_i54_mcc_i54_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i54_mcc_i54_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i54\\mcc_i54.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
