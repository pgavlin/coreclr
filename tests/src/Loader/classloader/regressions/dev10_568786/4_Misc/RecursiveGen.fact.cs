using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_568786_4_Misc_RecursiveGen_RecursiveGen_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_568786_4_Misc_RecursiveGen_RecursiveGen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_568786\\4_Misc\\RecursiveGen\\RecursiveGen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
