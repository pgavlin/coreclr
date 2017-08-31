using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__speed_relgcarr__speed_relgcarr_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__speed_relgcarr__speed_relgcarr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_speed_relgcarr\\_speed_relgcarr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
