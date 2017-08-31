using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadrgninfunclet_d_deadrgninfunclet_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadrgninfunclet_d_deadrgninfunclet_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadrgninfunclet_d\\deadrgninfunclet_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
