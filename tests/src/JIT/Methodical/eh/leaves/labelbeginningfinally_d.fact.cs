using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_labelbeginningfinally_d_labelbeginningfinally_d_
    {
        [Fact]
        public void _eh_leaves_labelbeginningfinally_d_labelbeginningfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\labelbeginningfinally_d\\labelbeginningfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
