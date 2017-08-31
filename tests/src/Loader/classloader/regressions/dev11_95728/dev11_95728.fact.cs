using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev11_95728_dev11_95728_dev11_95728_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev11_95728_dev11_95728_dev11_95728_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev11_95728\\dev11_95728\\dev11_95728.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
