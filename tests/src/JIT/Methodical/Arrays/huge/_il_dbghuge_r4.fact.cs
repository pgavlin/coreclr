using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge__il_dbghuge_r4__il_dbghuge_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_huge__il_dbghuge_r4__il_dbghuge_r4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge\\_il_dbghuge_r4\\_il_dbghuge_r4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
