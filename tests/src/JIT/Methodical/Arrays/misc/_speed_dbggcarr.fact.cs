using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__speed_dbggcarr__speed_dbggcarr_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__speed_dbggcarr__speed_dbggcarr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_speed_dbggcarr\\_speed_dbggcarr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
