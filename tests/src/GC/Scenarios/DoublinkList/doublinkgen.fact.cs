using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_doublinkgen_doublinkgen_
    {
        [Fact]
        public void _DoublinkList_doublinkgen_doublinkgen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\doublinkgen\\doublinkgen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
