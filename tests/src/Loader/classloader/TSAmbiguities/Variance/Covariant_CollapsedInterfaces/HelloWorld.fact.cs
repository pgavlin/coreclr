using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TSAmbiguities_Variance_Covariant_CollapsedInterfaces_HelloWorld_HelloWorld_
    {
        [OuterLoop]
        [Fact]
        public void _TSAmbiguities_Variance_Covariant_CollapsedInterfaces_HelloWorld_HelloWorld_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TSAmbiguities\\Variance\\Covariant_CollapsedInterfaces\\HelloWorld\\HelloWorld.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
