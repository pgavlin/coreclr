using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_trybodyinbetweencatchhandlers_r_trybodyinbetweencatchhandlers_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_trybodyinbetweencatchhandlers_r_trybodyinbetweencatchhandlers_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\trybodyinbetweencatchhandlers_r\\trybodyinbetweencatchhandlers_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
