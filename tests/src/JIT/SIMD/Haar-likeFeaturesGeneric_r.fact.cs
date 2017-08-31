using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Haar_likeFeaturesGeneric_r_Haar_likeFeaturesGeneric_r_
    {
        [Fact]
        public void _Haar_likeFeaturesGeneric_r_Haar_likeFeaturesGeneric_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Haar-likeFeaturesGeneric_r\\Haar-likeFeaturesGeneric_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
