using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_mixedhandler_catchfiltercatch_d_catchfiltercatch_d_
    {
        [Fact]
        public void _eh_mixedhandler_catchfiltercatch_d_catchfiltercatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\mixedhandler\\catchfiltercatch_d\\catchfiltercatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
