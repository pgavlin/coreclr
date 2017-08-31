using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Vector3GetHash_r_Vector3GetHash_r_
    {
        [OuterLoop]
        [Fact]
        public void _Vector3GetHash_r_Vector3GetHash_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3GetHash_r\\Vector3GetHash_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
