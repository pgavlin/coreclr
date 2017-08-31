using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge__il_relhuge_b__il_relhuge_b_
    {
        [Fact]
        public void _Arrays_huge__il_relhuge_b__il_relhuge_b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge\\_il_relhuge_b\\_il_relhuge_b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
