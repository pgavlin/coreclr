using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeGeneratorTests_TypeGeneratorTest683_Generated683_Generated683_
    {
        [ActiveIssue("6707")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _TypeGeneratorTests_TypeGeneratorTest683_Generated683_Generated683_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeGeneratorTests\\TypeGeneratorTest683\\Generated683\\Generated683.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
