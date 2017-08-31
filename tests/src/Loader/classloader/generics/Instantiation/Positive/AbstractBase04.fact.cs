using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_AbstractBase04_AbstractBase04_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_AbstractBase04_AbstractBase04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\AbstractBase04\\AbstractBase04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
