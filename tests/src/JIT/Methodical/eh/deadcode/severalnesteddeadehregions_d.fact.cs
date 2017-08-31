using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_severalnesteddeadehregions_d_severalnesteddeadehregions_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_severalnesteddeadehregions_d_severalnesteddeadehregions_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\severalnesteddeadehregions_d\\severalnesteddeadehregions_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
