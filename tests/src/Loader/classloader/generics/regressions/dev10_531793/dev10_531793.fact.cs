using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_dev10_531793_dev10_531793_dev10_531793_
    {
        [Fact]
        public void _generics_regressions_dev10_531793_dev10_531793_dev10_531793_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\dev10_531793\\dev10_531793\\dev10_531793.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
