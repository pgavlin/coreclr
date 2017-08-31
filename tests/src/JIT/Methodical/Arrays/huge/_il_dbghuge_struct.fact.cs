using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge__il_dbghuge_struct__il_dbghuge_struct_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_huge__il_dbghuge_struct__il_dbghuge_struct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge\\_il_dbghuge_struct\\_il_dbghuge_struct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
