using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_sehhandlerbeforetry_d_sehhandlerbeforetry_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_sehhandlerbeforetry_d_sehhandlerbeforetry_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\sehhandlerbeforetry_d\\sehhandlerbeforetry_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
