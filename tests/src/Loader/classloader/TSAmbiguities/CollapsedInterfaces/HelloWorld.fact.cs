using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TSAmbiguities_CollapsedInterfaces_HelloWorld_HelloWorld_
    {
        [Fact]
        public void _TSAmbiguities_CollapsedInterfaces_HelloWorld_HelloWorld_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TSAmbiguities\\CollapsedInterfaces\\HelloWorld\\HelloWorld.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
