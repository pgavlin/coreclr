using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_oponerror_r_oponerror_r_
    {
        [Fact]
        public void _eh_leaves_oponerror_r_oponerror_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\oponerror_r\\oponerror_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
