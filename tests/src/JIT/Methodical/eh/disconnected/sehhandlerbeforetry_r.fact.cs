using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_sehhandlerbeforetry_r_sehhandlerbeforetry_r_
    {
        [Fact]
        public void _eh_disconnected_sehhandlerbeforetry_r_sehhandlerbeforetry_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\sehhandlerbeforetry_r\\sehhandlerbeforetry_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
