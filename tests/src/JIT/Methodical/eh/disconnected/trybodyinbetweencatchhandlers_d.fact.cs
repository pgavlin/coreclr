using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_trybodyinbetweencatchhandlers_d_trybodyinbetweencatchhandlers_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_trybodyinbetweencatchhandlers_d_trybodyinbetweencatchhandlers_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\trybodyinbetweencatchhandlers_d\\trybodyinbetweencatchhandlers_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
