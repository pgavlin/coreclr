using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeGeneratorTests_TypeGeneratorTest682_Generated682_Generated682_
    {
        [ActiveIssue("6707")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _TypeGeneratorTests_TypeGeneratorTest682_Generated682_Generated682_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeGeneratorTests\\TypeGeneratorTest682\\Generated682\\Generated682.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
