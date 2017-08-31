using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TSAmbiguities_SameMethodImpl_CollapsedInterfaces_HelloWorld_HelloWorld_
    {
        [OuterLoop]
        [Fact]
        public void _TSAmbiguities_SameMethodImpl_CollapsedInterfaces_HelloWorld_HelloWorld_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TSAmbiguities\\SameMethodImpl\\CollapsedInterfaces\\HelloWorld\\HelloWorld.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
