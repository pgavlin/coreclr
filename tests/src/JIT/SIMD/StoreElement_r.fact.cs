using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _StoreElement_r_StoreElement_r_
    {
        [OuterLoop]
        [Fact]
        public void _StoreElement_r_StoreElement_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\StoreElement_r\\StoreElement_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
