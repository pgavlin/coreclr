using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_dbginstftn__il_dbginstftn_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_dbginstftn__il_dbginstftn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbginstftn\\_il_dbginstftn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
