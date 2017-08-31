using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_throw2dimarray_d_throw2dimarray_d_
    {
        [Fact]
        public void _eh_interactions_throw2dimarray_d_throw2dimarray_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\throw2dimarray_d\\throw2dimarray_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
