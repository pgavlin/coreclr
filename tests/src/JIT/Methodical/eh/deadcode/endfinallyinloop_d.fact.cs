using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_endfinallyinloop_d_endfinallyinloop_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_endfinallyinloop_d_endfinallyinloop_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\endfinallyinloop_d\\endfinallyinloop_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
