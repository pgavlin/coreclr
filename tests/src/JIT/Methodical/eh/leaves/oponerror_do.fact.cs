using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_oponerror_do_oponerror_do_
    {
        [Fact]
        public void _eh_leaves_oponerror_do_oponerror_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\oponerror_do\\oponerror_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
