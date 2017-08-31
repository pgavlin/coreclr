using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge__il_relhuge_r4__il_relhuge_r4_
    {
        [Fact]
        public void _Arrays_huge__il_relhuge_r4__il_relhuge_r4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge\\_il_relhuge_r4\\_il_relhuge_r4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
