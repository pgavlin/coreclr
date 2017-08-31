using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_14610_TestObjectGetTypeVirtual_TestObjectGetTypeVirtual_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_14610_TestObjectGetTypeVirtual_TestObjectGetTypeVirtual_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\14610\\TestObjectGetTypeVirtual\\TestObjectGetTypeVirtual.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
