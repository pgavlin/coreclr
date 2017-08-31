using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _methodoverriding_regressions_dev10_432038_dev10_432038_dev10_432038_
    {
        [OuterLoop]
        [Fact]
        public void _methodoverriding_regressions_dev10_432038_dev10_432038_dev10_432038_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\methodoverriding\\regressions\\dev10_432038\\dev10_432038\\dev10_432038.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
