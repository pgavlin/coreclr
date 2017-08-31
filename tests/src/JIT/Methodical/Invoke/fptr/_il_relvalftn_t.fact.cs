using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_relvalftn_t__il_relvalftn_t_
    {
        [Fact]
        public void _Invoke_fptr__il_relvalftn_t__il_relvalftn_t_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relvalftn_t\\_il_relvalftn_t.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
