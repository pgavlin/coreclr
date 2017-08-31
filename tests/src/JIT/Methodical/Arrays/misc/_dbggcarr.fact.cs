using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__dbggcarr__dbggcarr_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__dbggcarr__dbggcarr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_dbggcarr\\_dbggcarr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
