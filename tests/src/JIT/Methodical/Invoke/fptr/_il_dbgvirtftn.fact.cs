using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_dbgvirtftn__il_dbgvirtftn_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_dbgvirtftn__il_dbgvirtftn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbgvirtftn\\_il_dbgvirtftn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
