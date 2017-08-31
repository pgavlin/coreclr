using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Constraints_Regressions_dev10_512868_dev10_512868_dev10_512868_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Constraints_Regressions_dev10_512868_dev10_512868_dev10_512868_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Constraints\\Regressions\\dev10_512868\\dev10_512868\\dev10_512868.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
