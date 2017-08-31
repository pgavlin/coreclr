using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_oponerror_d_oponerror_d_
    {
        [Fact]
        public void _eh_leaves_oponerror_d_oponerror_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\oponerror_d\\oponerror_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
