using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_throw1dimarray_d_throw1dimarray_d_
    {
        [Fact]
        public void _eh_interactions_throw1dimarray_d_throw1dimarray_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\throw1dimarray_d\\throw1dimarray_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
