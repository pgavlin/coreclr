using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_leaveinsameregion_d_leaveinsameregion_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_leaveinsameregion_d_leaveinsameregion_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\leaveinsameregion_d\\leaveinsameregion_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
