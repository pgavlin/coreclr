using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TSAmbiguities_CollapsedMethods_Override_HelloWorld_HelloWorld_
    {
        [OuterLoop]
        [Fact]
        public void _TSAmbiguities_CollapsedMethods_Override_HelloWorld_HelloWorld_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TSAmbiguities\\CollapsedMethods\\Override\\HelloWorld\\HelloWorld.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
