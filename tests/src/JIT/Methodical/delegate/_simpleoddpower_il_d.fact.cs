using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _delegate__simpleoddpower_il_d__simpleoddpower_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _delegate__simpleoddpower_il_d__simpleoddpower_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\delegate\\_simpleoddpower_il_d\\_simpleoddpower_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
