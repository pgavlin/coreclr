using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _Vector3GetHash_ro_Vector3GetHash_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Vector3GetHash_ro_Vector3GetHash_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3GetHash_ro\\Vector3GetHash_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
