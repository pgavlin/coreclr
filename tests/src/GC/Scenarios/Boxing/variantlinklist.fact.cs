using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_variantlinklist_variantlinklist_
    {
        [Fact]
        public void _Boxing_variantlinklist_variantlinklist_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\variantlinklist\\variantlinklist.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
