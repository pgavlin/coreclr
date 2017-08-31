using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadrgninfunclet_r_deadrgninfunclet_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadrgninfunclet_r_deadrgninfunclet_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadrgninfunclet_r\\deadrgninfunclet_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
