using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _SingLinkList_singlinkgen_singlinkgen_
    {
        [Fact]
        public void _SingLinkList_singlinkgen_singlinkgen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\SingLinkList\\singlinkgen\\singlinkgen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
