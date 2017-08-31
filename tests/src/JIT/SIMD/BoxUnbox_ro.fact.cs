using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _BoxUnbox_ro_BoxUnbox_ro_
    {
        [Fact]
        public void _BoxUnbox_ro_BoxUnbox_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\BoxUnbox_ro\\BoxUnbox_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
