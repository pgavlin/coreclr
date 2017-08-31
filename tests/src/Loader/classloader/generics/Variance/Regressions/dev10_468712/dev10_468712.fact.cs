using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_Regressions_dev10_468712_dev10_468712_dev10_468712_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_Regressions_dev10_468712_dev10_468712_dev10_468712_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\Regressions\\dev10_468712\\dev10_468712\\dev10_468712.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
