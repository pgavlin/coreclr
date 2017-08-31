using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_severalnesteddeadehregions_r_severalnesteddeadehregions_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_severalnesteddeadehregions_r_severalnesteddeadehregions_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\severalnesteddeadehregions_r\\severalnesteddeadehregions_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
