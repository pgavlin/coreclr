using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_severaldeadehregions_d_severaldeadehregions_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_severaldeadehregions_d_severaldeadehregions_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\severaldeadehregions_d\\severaldeadehregions_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
