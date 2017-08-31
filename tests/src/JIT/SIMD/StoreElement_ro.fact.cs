using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _StoreElement_ro_StoreElement_ro_
    {
        [Fact]
        public void _StoreElement_ro_StoreElement_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\StoreElement_ro\\StoreElement_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
