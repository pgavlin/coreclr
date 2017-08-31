using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_dbggcarr__il_dbggcarr_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__il_dbggcarr__il_dbggcarr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_dbggcarr\\_il_dbggcarr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
