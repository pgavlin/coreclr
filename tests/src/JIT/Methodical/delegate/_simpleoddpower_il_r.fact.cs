using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _delegate__simpleoddpower_il_r__simpleoddpower_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _delegate__simpleoddpower_il_r__simpleoddpower_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\delegate\\_simpleoddpower_il_r\\_simpleoddpower_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
