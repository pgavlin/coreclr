using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_labelbeforefinally_d_labelbeforefinally_d_
    {
        [Fact]
        public void _eh_leaves_labelbeforefinally_d_labelbeforefinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\labelbeforefinally_d\\labelbeforefinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
