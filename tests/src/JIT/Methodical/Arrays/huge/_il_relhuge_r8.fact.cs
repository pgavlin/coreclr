using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge__il_relhuge_r8__il_relhuge_r8_
    {
        [Fact]
        public void _Arrays_huge__il_relhuge_r8__il_relhuge_r8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge\\_il_relhuge_r8\\_il_relhuge_r8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
