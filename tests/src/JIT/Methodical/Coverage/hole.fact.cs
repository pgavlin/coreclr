using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Coverage_hole_hole_
    {
        [Fact]
        public void _Coverage_hole_hole_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Coverage\\hole\\hole.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
