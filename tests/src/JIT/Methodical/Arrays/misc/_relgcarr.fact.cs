using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__relgcarr__relgcarr_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__relgcarr__relgcarr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_relgcarr\\_relgcarr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
