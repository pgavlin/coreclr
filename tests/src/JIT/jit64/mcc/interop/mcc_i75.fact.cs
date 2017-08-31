using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _mcc_interop_mcc_i75_mcc_i75_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mcc_interop_mcc_i75_mcc_i75_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\mcc\\interop\\mcc_i75\\mcc_i75.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
