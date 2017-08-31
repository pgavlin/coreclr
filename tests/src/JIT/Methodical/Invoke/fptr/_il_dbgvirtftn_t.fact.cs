using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_dbgvirtftn_t__il_dbgvirtftn_t_
    {
        [Fact]
        public void _Invoke_fptr__il_dbgvirtftn_t__il_dbgvirtftn_t_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbgvirtftn_t\\_il_dbgvirtftn_t.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
