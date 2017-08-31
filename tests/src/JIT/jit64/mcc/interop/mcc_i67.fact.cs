using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _mcc_interop_mcc_i67_mcc_i67_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _mcc_interop_mcc_i67_mcc_i67_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i67\\mcc_i67.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
