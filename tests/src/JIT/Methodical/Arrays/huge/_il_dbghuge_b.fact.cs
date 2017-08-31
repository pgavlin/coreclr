using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge__il_dbghuge_b__il_dbghuge_b_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_huge__il_dbghuge_b__il_dbghuge_b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge\\_il_dbghuge_b\\_il_dbghuge_b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
