using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge__il_dbghuge_objref__il_dbghuge_objref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_huge__il_dbghuge_objref__il_dbghuge_objref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge\\_il_dbghuge_objref\\_il_dbghuge_objref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
