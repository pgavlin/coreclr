using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _BoxUnbox_r_BoxUnbox_r_
    {
        [OuterLoop]
        [Fact]
        public void _BoxUnbox_r_BoxUnbox_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\BoxUnbox_r\\BoxUnbox_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
