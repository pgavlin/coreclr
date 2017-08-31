using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_oponerror_ro_oponerror_ro_
    {
        [Fact]
        public void _eh_leaves_oponerror_ro_oponerror_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\oponerror_ro\\oponerror_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
