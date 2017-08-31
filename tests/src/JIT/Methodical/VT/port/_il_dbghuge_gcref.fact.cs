using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__il_dbghuge_gcref__il_dbghuge_gcref_
    {
        [Fact]
        public void _VT_port__il_dbghuge_gcref__il_dbghuge_gcref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_il_dbghuge_gcref\\_il_dbghuge_gcref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
