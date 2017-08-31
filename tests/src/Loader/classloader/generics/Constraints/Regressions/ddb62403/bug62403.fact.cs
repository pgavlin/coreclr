using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Constraints_Regressions_ddb62403_bug62403_bug62403_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Constraints_Regressions_ddb62403_bug62403_bug62403_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Constraints\\Regressions\\ddb62403\\bug62403\\bug62403.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
