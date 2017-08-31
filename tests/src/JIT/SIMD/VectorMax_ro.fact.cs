using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorMax_ro_VectorMax_ro_
    {
        [Fact]
        public void _VectorMax_ro_VectorMax_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMax_ro\\VectorMax_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
