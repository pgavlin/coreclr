using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_mixedhandler_filterfiltercatchcatch_d_filterfiltercatchcatch_d_
    {
        [Fact]
        public void _eh_mixedhandler_filterfiltercatchcatch_d_filterfiltercatchcatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\mixedhandler\\filterfiltercatchcatch_d\\filterfiltercatchcatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
