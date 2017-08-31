using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_relvirtftn__il_relvirtftn_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relvirtftn__il_relvirtftn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relvirtftn\\_il_relvirtftn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
