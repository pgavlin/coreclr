using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Haar_likeFeaturesGeneric_ro_Haar_likeFeaturesGeneric_ro_
    {
        [Fact]
        public void _Haar_likeFeaturesGeneric_ro_Haar_likeFeaturesGeneric_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Haar-likeFeaturesGeneric_ro\\Haar-likeFeaturesGeneric_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
