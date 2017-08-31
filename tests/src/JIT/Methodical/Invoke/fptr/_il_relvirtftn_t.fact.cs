using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_relvirtftn_t__il_relvirtftn_t_
    {
        [Fact]
        public void _Invoke_fptr__il_relvirtftn_t__il_relvirtftn_t_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relvirtftn_t\\_il_relvirtftn_t.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
